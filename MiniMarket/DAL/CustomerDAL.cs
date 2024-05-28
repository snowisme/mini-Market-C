using MiniMarket.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace MiniMarket.DAL
{
    public class CustomerDAL
    {

        private static List<Customer> _customers = new List<Customer>()
        {
            new Customer() { CustomerId = 1, CustomerName = "Phương Anh", Phone = "111111", Address = "Hà Nội", Gender = "Nữ", Password = "123"},
            new Customer() { CustomerId = 2, CustomerName = "Trọng Nghĩa", Phone = "222222", Address = "Hải Phòng", Gender = "Nam", Password = "123"},
            new Customer() { CustomerId = 3, CustomerName = "Hoàng Quân", Phone = "222222", Address = "TP HCM", Gender = "Nam", Password = "123"},
        };

        public CustomerDAL() { }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public int Insert(Customer customer)
        {
            int newId = _customers.Max(x => x.CustomerId) + 1;
            customer.CustomerId = newId;
            _customers.Add(customer);

            return newId;
        }

        public int Update(Customer customer)
        {
            var oldCustomer = _customers.Where(x => x.CustomerId == customer.CustomerId)
                .FirstOrDefault();

            if (oldCustomer != null)
            {
                oldCustomer.Address = customer.Address;
                oldCustomer.CustomerName   = customer.CustomerName;
                oldCustomer.Phone = customer.Phone;
                oldCustomer.Password = customer.Password;
                oldCustomer.Gender = customer.Gender;

                return oldCustomer.CustomerId;
            }

            return -1;
        }

        public int Delete(int customerId)
        {
            var oldCustomer = _customers.Where(x => x.CustomerId == customerId)
                 .FirstOrDefault();

            if (oldCustomer != null)
            {
                _customers.Remove(oldCustomer);
                return 1;
            }

            return -1;
        }

        public List<Customer> SearchByName(string customerName)
        {
            return _customers.Where(x => x.CustomerName.Contains(customerName)).ToList();
        }

        public Customer Login(string phone, string password)
        {
            return _customers.Where(x => x.Phone == phone && x.Password == password)
                .FirstOrDefault();
        }
    }
}