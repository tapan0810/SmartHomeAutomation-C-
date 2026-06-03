using SmartHomeAutomation.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Observers
{
    public class SmartLight
    {
        private readonly Light _light;

        public SmartLight(Light light)
        {
            _light = light;
        }

        public void MotionDetected(string location)
        {
            Console.WriteLine($"SmartLight: Motion Activated at {location}!");

            _light.TurnOn();

            _light.SetBrightness(75);
        }
    }
}
