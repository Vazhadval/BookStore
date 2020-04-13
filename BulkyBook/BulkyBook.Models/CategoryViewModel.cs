using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Models
{
    public class CategoryViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
