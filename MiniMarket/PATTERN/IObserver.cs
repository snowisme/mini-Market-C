using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket.PATTERN
{
    public interface  IObserver
    {
        SubjectForType SubjectForType { get; set; }
        void Update(string messge);
    }
}
