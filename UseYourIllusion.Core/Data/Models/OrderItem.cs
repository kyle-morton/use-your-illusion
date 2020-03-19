using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class OrderItem : Base
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public float Price { get; set; }
    }

}
