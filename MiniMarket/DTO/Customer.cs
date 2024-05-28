namespace MiniMarket.DTO
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }
    }
}
