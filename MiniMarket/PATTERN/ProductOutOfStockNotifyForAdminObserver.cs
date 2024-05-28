using MiniMarket.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket.PATTERN
{
    public class ProductOutOfStockNotifyForAdminObserver : IObserver
    {
        public ProductOutOfStockNotifyForAdminObserver(ISubject subject)
        {
            subject.Register(this);
            SubjectForType = SubjectForType.Admin;
        }

        public SubjectForType SubjectForType { get; set; }

        public void Update(string messge)
        {
            NotifyForm frm = new NotifyForm();
            frm.SetAlertFor("Thông báo cho Quản Trị Viên");
            frm.ShowAlert(messge);
        }
    }
}
