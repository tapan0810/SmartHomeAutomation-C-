using SmartHomeAutomation.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Sensors
{
    public class MotionSensor
    {
        public event MotionDetectedHandler? MotionDetected;

        public void DetectMotion(string location)
        {
            Console.WriteLine($"Motion Detected at {location}!");
            MotionDetected?.Invoke(location);
        }
    }
}
