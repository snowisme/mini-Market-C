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
    public class UnitDAL
    {
        private static List<Unit> _units = new List<Unit>()
        {
            new Unit() { UnitId = 1, UnitName = "Kg"},
            new Unit() { UnitId = 2, UnitName = "Chiếc"},
            new Unit() { UnitId = 3, UnitName = "Thùng"},
        };

        public List<Unit> GetAll()
        {
            return _units;
        }

        public int Insert(Unit unit)
        {
            int newId = _units.Max(x => x.UnitId)
                + 1;
            unit.UnitId = newId;
            _units.Add(unit);
            return newId;
        }

        public int Update(Unit unit)
        {
            var old = _units
                .Where(x => x.UnitId == unit.UnitId)
                .FirstOrDefault();
            
            if (old != null)
            {
                old.UnitName = unit.UnitName;
                return 1;
            }
            return -1;
        }

        public int Delete(int unitId)
        {
            var old = _units
                .Where(x => x.UnitId == unitId)
                .FirstOrDefault();

            if (old != null)
            {
                _units.Remove(old);
                return 1;
            }
            return -1;
        }

        public List<Unit> SearchByName(string unitName)
        {
            return _units
                .Where(x => x.UnitName.Contains(unitName))
                .ToList();
        }
    }
}