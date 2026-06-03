using SmartHomeAutomation.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Factories
{
    public static class DeviceFactory
    {
        public static Device CreateDevice(
            string type,
            string name)
        {
            return type.ToLower() switch
            {
                "fan" => new Fan(name),

                "light" => new Light(name),

                _ => throw new ArgumentException(
                    "Invalid Device Type")
            };
        }
    }
}
