using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace BulkyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public OrderDetailsViewModel OrderViewModel { get; set; }
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Details")]
        public IActionResult Details(string stripeToken)
        {
            OrderHeader orderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == OrderViewModel.OrderHeader.Id,
                                                includeProperties: "ApplicationUser");
            if (stripeToken != null)
            {
                //process the payment
                var options = new ChargeCreateOptions
                {
                    Amount = Convert.ToInt32(orderHeader.OrderTotal * 100),
                    Currency = "gel",
                    Description = "Order ID : " + orderHeader.Id,
                    Source = stripeToken
                };

                var service = new ChargeService();
                Charge charge = service.Create(options);

                if (charge.Id == null)
                {
                    orderHeader.PaymentStatus = Constants.PaymentStatusRejected;
                }
                else
                {
                    orderHeader.TransactionId = charge.Id;
                }
                if (charge.Status.ToLower() == "succeeded")
                {
                    orderHeader.PaymentStatus = Constants.PaymentStatusApproved;

                    orderHeader.PaymentDate = DateTime.Now;
                }

                _unitOfWork.Save();

            }
            return RedirectToAction("Details", "Order", new { id = orderHeader.Id });
        }



        public IActionResult Details(int id)
        {
            OrderViewModel = new OrderDetailsViewModel()
            {
                OrderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == id, includeProperties: "ApplicationUser"),
                OrderDetails = _unitOfWork.OrderDetails.GetAll(o => o.OrderId == id, includeProperties: "Product")

            };

            return View(OrderViewModel);
        }


        [Authorize(Roles = Constants.Role_Admin + "," + Constants.Role_Employee)]
        public IActionResult StartProcessing(int id)
        {
            OrderHeader orderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == id);
            orderHeader.OrderStatus = Constants.StatusInProcess;
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = Constants.Role_Admin + "," + Constants.Role_Employee)]
        [HttpPost]
        public IActionResult ShipOrder()
        {
            OrderHeader orderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == OrderViewModel.OrderHeader.Id);
            orderHeader.TrackingNumber = OrderViewModel.OrderHeader.TrackingNumber;
            orderHeader.Carrier = OrderViewModel.OrderHeader.Carrier;
            orderHeader.OrderStatus = Constants.StatusShipped;
            orderHeader.ShippingDate = DateTime.Now;

            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = Constants.Role_Admin + "," + Constants.Role_Employee)]
        public IActionResult CancelOrder(int id)
        {
            OrderHeader orderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == id);

            if (orderHeader.PaymentStatus == Constants.PaymentStatusApproved)
            {
                var options = new RefundCreateOptions
                {
                    Amount = Convert.ToInt32(orderHeader.OrderTotal * 100),
                    Reason = RefundReasons.RequestedByCustomer,
                    Charge = orderHeader.TransactionId
                };

                var service = new RefundService();
                Refund refund = service.Create(options);

                orderHeader.OrderStatus = Constants.StatusRefunded;
                orderHeader.PaymentStatus = Constants.StatusRefunded;
            }
            else
            {
                orderHeader.OrderStatus = Constants.StatusCancelled;
                orderHeader.PaymentStatus = Constants.StatusCancelled;
            }

            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetOrderList(string status)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            IEnumerable<OrderHeader> orderHeaderList;

            if (User.IsInRole(Constants.Role_Admin) || User.IsInRole(Constants.Role_Employee))
            {
                orderHeaderList = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApplicationUser");
            }
            else
            {
                orderHeaderList = _unitOfWork.OrderHeader.GetAll(u => u.ApplicationUserId == claim.Value, includeProperties: "ApplicationUser");
            }


            switch (status)
            {
                case "pending":
                    orderHeaderList = orderHeaderList.Where(o => o.PaymentStatus == Constants.PaymentStatusDelayedPayment);
                    break;
                case "inprocess":
                    orderHeaderList = orderHeaderList.Where(o => o.OrderStatus == Constants.StatusApproved ||
                                                            o.OrderStatus == Constants.StatusInProcess ||
                                                            o.OrderStatus == Constants.StatusPending);
                    break;
                case "completed":
                    orderHeaderList = orderHeaderList.Where(o => o.OrderStatus == Constants.StatusShipped);
                    break;
                case "rejected":
                    orderHeaderList = orderHeaderList.Where(o => o.OrderStatus == Constants.StatusCancelled ||
                                                            o.OrderStatus == Constants.StatusRefunded ||
                                                            o.OrderStatus == Constants.PaymentStatusRejected);
                    break;
                default:
                    break;
            }


            return Json(new { data = orderHeaderList });
        }

        #endregion
    }
}