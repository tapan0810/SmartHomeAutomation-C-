using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Observers
{
    public class NotificationService
    {
        public void TempratureNotification(int temprature)
        {
            Console.WriteLine($"notification: Temprature Alert! Current Temprature = {temprature}°C");
        }

        public void MotionNotification(string location)
        {
            Console.WriteLine($"notification: Motion Detected at {location}!");
        }
    }
}
