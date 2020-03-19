using System.Collections.Generic;

namespace UseYourIllusion.Core.Data.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ProductCategory> Categories { get; set; }
    }
}
