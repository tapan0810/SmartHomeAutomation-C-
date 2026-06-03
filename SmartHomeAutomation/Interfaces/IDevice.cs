using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Interfaces
{
    internal interface IDevice
    {
        String Name { get; set; }
        bool IsOn { get; protected set; }

        void TurnOn();
        void TurnOff();
    }
}
