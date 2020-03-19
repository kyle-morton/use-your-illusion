using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public enum OrderAddressType
    {
        [Display(Name = "Delivery")]
        Delivery = 1,

        [Display(Name = "Billing")]
        Billing = 2,
    }
}
