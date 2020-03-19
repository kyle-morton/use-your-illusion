namespace UseYourIllusion.Core.Data.Models
{
    public class OrderAddress : Base
    {
        public string ContactName { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string SpecialInstructions { get; set; }
        public OrderAddressType TypeId { get; set; }

        public int OrderId { get; set; }
        public virtual Order Customer { get; set; }
    }
}
