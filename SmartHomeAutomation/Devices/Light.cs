using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Devices
{
    public class Light : Device
    {
        public int Brightness { get; private set; }

        public Light(string name) : base(name) { }

        public override void TurnOn()
        {
            IsOn = true;

            Console.WriteLine($"{Name} is ON");
        }

        public override void TurnOff()
        {
            IsOn = false;

            Console.WriteLine($"{Name} is OFF");
        }

        public void SetBrightness(int brightness)
        {
            Brightness = brightness;

            Console.WriteLine($"{Name} Brightness = {brightness}%");
        }
    }
}
