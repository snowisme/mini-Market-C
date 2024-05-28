
using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket.DAL
{
    public class AccountDAL
    {
        public AccountDAL() { }

        private static List<Account> _accounts = new List<Account>()
        {
            new Account() { Username = "admin", Password = "admin" },
            new Account() { Username = "admin1", Password = "admin1" },
            new Account() { Username = "admin2", Password = "admin2" },
        };

        public List<Account> GetAll()
        {
            return _accounts;
        } 

        public int Insert(Account account)
        {
            if (!_accounts.Any(x => x.Username == account.Username))
            {
                _accounts.Add(account);
                return 1;
            }

            return -1;
        }

        public int Update(Account account)
        {
            var old = _accounts.FirstOrDefault(x => x.Username == account.Username);

            if (old != null)
            {
                old.Username = account.Username;
                old.Password = account.Password;
                return 1;
            }

            return -1;
        }

        public int Delete(string username)
        {
            var old = _accounts.FirstOrDefault(x => x.Username == username);

            if (old != null)
            {
                _accounts.Remove(old);
                return 1;
            }

            return -1;
        }

        public bool Exists(string username)
        {
            return _accounts.Any(x => x.Username == username);
        }

        public Account Login(string username, string password)
        {
            var account = _accounts.Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();

            return account;
        }
    }
}
