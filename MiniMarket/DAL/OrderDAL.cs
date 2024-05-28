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
    
    public class OrderDAL
    {
        private OrderDetailDAL _orderDetailDAL = new OrderDetailDAL();

        private static List<Order> _orders = new List<Order>()
        {
            new Order() { OrderId = 1, CustomerId = 1, CustomerName = "Phương Anh", OrderDate = DateTime.Now, TotalPrice = 10000 },
            new Order() { OrderId = 2, CustomerId = 2, CustomerName = "Trọng Nghĩa", OrderDate = DateTime.Now, TotalPrice = 10000 },
            new Order() { OrderId = 3, CustomerId = 3, CustomerName = "Hoàng Quân", OrderDate = DateTime.Now, TotalPrice = 10000 },
        };

        public List<Order> GetAll()
        {
            return _orders;
        }

        public int CreateOrder(Order order, List<OrderDetail> orderDetails)
        {
            int newId = _orders.Max(x => order.OrderId) + 1;
            order.OrderId = newId;
            _orders.Add(order);

            foreach (var detail in orderDetails)
            {
                detail.OrderId = newId;
                _orderDetailDAL.Insert(detail);
            }

            return newId;
        }

        public int UpdateOrder(Order order, List<OrderDetail> orderDetails)
        {
            var old = _orders.Where(x => x.OrderId == order.OrderId)
                .FirstOrDefault();
            
            if (old != null)
            {
                old.CustomerId = order.CustomerId;
                old.OrderDate = order.OrderDate;
                old.TotalPrice = order.TotalPrice;

                _orderDetailDAL.Delete(old.OrderId);

                foreach (var detail in orderDetails)
                {
                    detail.OrderId = old.OrderId;
                    _orderDetailDAL.Insert(detail);
                }

                return 1;
            }

            return -1;
        }

        public int DeleteOrder(int orderId)
        {
            var old = _orders.Where(x => x.OrderId == orderId)
                .FirstOrDefault();

            if (old != null)
            {
                
                _orderDetailDAL.Delete(old.OrderId);

                _orders.Remove(old);
                return 1;
            }

            return -1;
        }
    }
}