using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Devices
{
    public class Fan : Device
    {
        public int Speed { get; private set; }

        public Fan(string name) : base(name) { }



        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} Fan OFF");
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} Fan ON");
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
            Console.WriteLine($"{Name} Speed set to {Speed} ");
        }
    }
}
