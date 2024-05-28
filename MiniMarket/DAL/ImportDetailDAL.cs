using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniMarket.DAL
{
    public class ImportDetailDAL
    {
        private static List<ImportDetail> _importDetais = new List<ImportDetail>()
        {
            new ImportDetail() { ImportId = 1, ProductId = 1, ProductName = "Product 1", Quantity = 1 },
            new ImportDetail() { ImportId = 1, ProductId = 2, ProductName = "Product 2", Quantity = 1 },
            new ImportDetail() { ImportId = 1, ProductId = 3, ProductName = "Product 3", Quantity = 1 },
            new ImportDetail() { ImportId = 2, ProductId = 1, ProductName = "Product 1", Quantity = 1 },
            new ImportDetail() { ImportId = 2, ProductId = 2, ProductName = "Product 2", Quantity = 1 },
            new ImportDetail() { ImportId = 2, ProductId = 3, ProductName = "Product 3", Quantity = 1 },
            new ImportDetail() { ImportId = 3, ProductId = 1, ProductName = "Product 1", Quantity = 1 },
            new ImportDetail() { ImportId = 3, ProductId = 2, ProductName = "Product 2", Quantity = 1 },
            new ImportDetail() { ImportId = 3, ProductId = 3, ProductName = "Product 3", Quantity = 1 },
        };

        public List<ImportDetail> GetAll()
        {
            return _importDetais;
        }

        public int Insert(ImportDetail importDetail)
        {
            _importDetais
                .Add(importDetail);
            return 1;
        }

        public List<ImportDetail> GetByImportId(int importId)
        {
            return _importDetais
                .Where(x => x.ImportId == importId)
                .ToList();
        }
    }
}