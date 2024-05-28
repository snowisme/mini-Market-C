namespace MiniMarket.DTO
{
    public class ImportDetail
    {
        public int ImportId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; } = 0;
    }
}
