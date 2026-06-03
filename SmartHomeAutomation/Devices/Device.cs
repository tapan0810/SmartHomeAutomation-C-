using SmartHomeAutomation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Devices
{
    public abstract class Device : IDevice
    {
        public string Name { get; set; }
        public bool IsOn { get; protected set; }
        protected Device(string name)
        {
            Name = name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
