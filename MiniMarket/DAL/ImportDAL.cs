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
    public class ImportDAL
    {
        private static List<Import> _imports = new List<Import>()
        {
            new Import() { ImportId = 1, Username = "admin", ImportDate = DateTime.Now },
            new Import() { ImportId = 2, Username = "admin", ImportDate = DateTime.Now },
            new Import() { ImportId = 3, Username = "admin", ImportDate = DateTime.Now }
        };

        public List<Import> GetAll()
        {
            return _imports;
        }

        public int Insert(Import import)
        {
            int newId = _imports.Max(x => x.ImportId) + 1;
            import.ImportId = newId;
            _imports.Add(import);
            return newId;
        }

        public int Update(Import import)
        {
            var old = _imports.Where(x => x.ImportId == import.ImportId)
                .FirstOrDefault();
            if (old != null)
            {
                old.Username = import.Username;
                old.ImportDate = import.ImportDate;
                return old.ImportId;
            }

            return -1;
        }

        public int Delete(int importId)
        {
            var old = _imports.Where(x => x.ImportId == importId)
               .FirstOrDefault();
            if (old != null)
            {
                _imports.Remove(old);
                return old.ImportId;
            }

            return -1;
        }
    }
}