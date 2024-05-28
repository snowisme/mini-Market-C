using MiniMarket.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.PATTERN
{
    public class ProductQuantityChangeNotifyForCustomerObserver : IObserver
    {
        public int customerId { get; set; }
        public SubjectForType SubjectForType { get; set; }
        public delegate void ProductInStockDelegate();
        public event ProductInStockDelegate ProductInStockHandler;
        public ProductQuantityChangeNotifyForCustomerObserver(int customerId, ISubject subject)
        {
            this.customerId = customerId;
            subject.Register(this);
            SubjectForType = SubjectForType.Customer;
        }

        public void Update(string messge)
        {
            NotifyForm frm = new NotifyForm();
            frm.SetAlertFor("Thông báo cho Khách Hàng");
            frm.ShowAlert(messge);
            if (ProductInStockHandler != null)
            {
                ProductInStockHandler();
            } 
        }
    }
}
