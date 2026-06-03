using SmartHomeAutomation.Devices;
using SmartHomeAutomation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Observers
{
    public class SmartFan : IObserver
    {
        private readonly Fan _fan;

        public SmartFan(Fan fan)
        {
            _fan = fan;
        }

           //if (message.Contains("Motion Detected"))
           //     {
           //         _fan.TurnOn();
           //         _fan.SetSpeed(3);
           //     }
           //     else if (message.Contains("No Motion"))
           //     {
           //         _fan.TurnOff();
           //     }

        void IObserver.Update(int value)
        {

            if (value > 30)
            {
                _fan.TurnOn();

                _fan.SetSpeed(5);
            }
            else
            {
                _fan.TurnOff();
            }
        }
    }
}
