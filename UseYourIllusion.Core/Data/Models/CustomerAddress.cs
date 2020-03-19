using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class CustomerAddress : Base
    {
        public string ContactName { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string SpecialInstructions { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
