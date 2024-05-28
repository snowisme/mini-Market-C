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
    public class OrderDetailDAL
    {
        ProductDAL _productDAL = new ProductDAL();

        private static List<OrderDetail> _orderDetails = new List<OrderDetail>()
        {
            new OrderDetail() { OrderId = 1, ProductId = 1, ProductName = "Product 1", Quantity = 1, Price = 5000},
            new OrderDetail() { OrderId = 1, ProductId = 2, ProductName = "Product 2", Quantity = 1, Price = 5000},
            new OrderDetail() { OrderId = 2, ProductId = 1, ProductName = "Product 1", Quantity = 1, Price = 5000},
            new OrderDetail() { OrderId = 2, ProductId = 3, ProductName = "Product 3", Quantity = 1, Price = 5000},
            new OrderDetail() { OrderId = 3, ProductId = 1, ProductName = "Product 1", Quantity = 1, Price = 5000},
            new OrderDetail() { OrderId = 3, ProductId = 3, ProductName = "Product 3", Quantity = 1, Price = 5000},
        };

        public int Insert(OrderDetail orderDetail)
        {
            _orderDetails.Add(orderDetail);
            int currentProductQty = _productDAL.SubtractQuantiy(orderDetail.ProductId, orderDetail.Quantity);
            
            if (currentProductQty <= 0)
            {
                Program.ProductQuantityChangeSubject
                    .SetNotifyMessage(string.Format("Sản phẩm {0}-{1} đã hết hàng !"
                    , orderDetail.ProductId, orderDetail.ProductName)
                    , PATTERN.SubjectForType.Admin);
            } 
            return 1;
        }

        public int Delete(int orderId)
        {
            List<OrderDetail> toRemove = _orderDetails.Where(x => x.OrderId ==  orderId)
                .ToList();
            foreach (var item in toRemove)
                _orderDetails.Remove(item);
            return 1;
        }

        public List<OrderDetail> GetByOrderId(int orderId)
        {
            return _orderDetails.Where(x => x.OrderId == orderId)
                .ToList();
        }
    }
}