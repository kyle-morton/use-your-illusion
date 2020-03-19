using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class Customer : Base
    {
        public string Name { get; set; }
        public string CustomerNumber { get; set; }
        public List<Order> Orders { get; set; }
        public List<CustomerAddress> Addresses { get; set; }
    }
}
