using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class Order : Base
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public List<OrderAddress> Addresses { get; set; }
        public OrderShipment Shipment { get; set; }
    }
}
