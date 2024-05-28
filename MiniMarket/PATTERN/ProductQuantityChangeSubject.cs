using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket.PATTERN
{
    public class ProductQuantityChangeSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _message;

        public ProductQuantityChangeSubject()
        {
        }

        public void SetNotifyMessage(string message, SubjectForType type)
        {
            _message = message;
            // Gửi thông báo đến tất cả observer
            Notify(type);
        }

        public void Notify(SubjectForType type)
        {
            foreach (IObserver observer in _observers)
            {
                if (type == observer.SubjectForType)
                {
                    observer.Update(_message);
                } 
            }
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
