using System;

namespace MiniMarket.DTO
{
    public class Import
    {
        public Import()
        {
            ImportDate = DateTime.Now;    
        }

        public int ImportId { get; set; }
        public string Username { get; set; }
        public DateTime ImportDate { get; set; }
    }
}
