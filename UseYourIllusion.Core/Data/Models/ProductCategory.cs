using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class ProductCategory : Base
    {
        public int ProductId { get; set; }
        public ProductCategoryType CategoryTypeId { get; set; }
    }
}
