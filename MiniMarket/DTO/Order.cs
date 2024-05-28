using System;

namespace MiniMarket.DTO
{
    public class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
