using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Interfaces
{
    internal interface IObserver
    {
        void Update(int value);
    }
}
