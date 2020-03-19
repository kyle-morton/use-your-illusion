using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class OrderShipment : Base
    {
        public float Weight { get; set; }
        public int LengthInInches { get; set; }
        public int HeightInInches { get; set; }
        public int WidthInInches { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
