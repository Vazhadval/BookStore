#pragma checksum "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869e75243a665daeb436e744c5218832c31038a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869e75243a665daeb436e744c5218832c31038a2", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b283f6c8c7163b5f5d1f909d7b66a1ed4e3ccc1", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869e75243a665daeb436e744c5218832c31038a25337", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869e75243a665daeb436e744c5218832c31038a25599", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"container backgroundWhite\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header bg-light text-light ml-0 row container\">\r\n                <div class=\"col-12 col-md-6\">\r\n                    <h1 class=\"text-primary\">");
#nullable restore
#line 10 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                        Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <p class=\"text-primary\">");
#nullable restore
#line 11 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                       Write(Model.Product.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-12 col-md-6 text-md-right pt-4\">\r\n                    <span class=\"badge badge-success pt-2\" style=\"height:30px;\">");
#nullable restore
#line 14 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                                           Write(Model.Product.CoverType.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    <span class=\"badge badge-warning pt-2\" style=\"height:30px;\">");
#nullable restore
#line 15 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                                           Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-8 col-lg-8"">

                            <div class=""row pl-2"">
                                <h5 class=""text-muted"">ISBN : ");
#nullable restore
#line 24 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                         Write(Model.Product.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <h5 class=\"pb-2\" style=\"color:orange\">List Price: <strike>$ ");
#nullable restore
#line 27 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                                                       Write(Model.Product.ListPrice.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strike></h5>
                            </div>
                            <div class=""row text-center pl-2"">
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>Quantity</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>1-49</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>50-99</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>100+</div>
                                </div>
                            </div>
                            <div class=""row text-center pl-2"" style=""color:maroon; font-weight:bold"">
                                <div class=""p-1 col-2 bg");
                WriteLiteral(@"-secondary"">
                                    <div style=""color:green;"">Price</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary"">
                                    <div style=""color:green;"">");
#nullable restore
#line 48 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                         Write(Model.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"p-1 col-2 bg-secondary\">\r\n                                    <div style=\"color:green;\">");
#nullable restore
#line 51 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                         Write(Model.Product.Price50.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"p-1 col-2 bg-secondary\">\r\n                                    <div style=\"color:green;\">");
#nullable restore
#line 54 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                                         Write(Model.Product.Price100.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <p class=\"pt-3\">");
#nullable restore
#line 58 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
                                           Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <div class=""row pl-2"">
                                <div class=""col-2 text-primary""><h4>Count</h4></div>
                                <div class=""col-10""><input class=""form-control"" /></div>
                            </div>
                        </div>
                        <div class=""col-12 col-lg-3 offset-lg-1 text-center"">
                            <img");
                BeginWriteAttribute("src", " src=\"", 3767, "\"", 3796, 1);
#nullable restore
#line 66 "E:\Projects\C# Projects\Udemy .net core course\BookStore\BulkyBook\BulkyBook\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3773, Model.Product.ImageUrl, 3773, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""100%"" class=""rounded"" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 pb-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869e75243a665daeb436e744c5218832c31038a214911", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-md-6 pb-1"">

                        <button type=""submit"" value=""Add to Cart"" class=""btn btn-primary btn-square btn-lg form-control"" style=""height:50px;"">Add to Cart</button>

                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
