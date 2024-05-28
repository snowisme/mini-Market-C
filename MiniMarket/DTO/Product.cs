namespace MiniMarket.DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public string Image { get; set; }
        public bool Deleted { get; set; }
    }
}
