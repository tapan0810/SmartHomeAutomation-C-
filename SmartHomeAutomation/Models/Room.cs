using SmartHomeAutomation.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Models
{
    public class Room
    {
        public string Name { get; set; }
        public List<Device> Devices { get; set; }
        public Room(string name)
        {
            Name = name;
            Devices = new List<Device>();
        }

        public void AddDevice(Device device)
        {
            Devices.Add(device);
        }

        public void ShowDevices()
        {
            Console.WriteLine($"\nRoom : {Name}");

            foreach(var device in Devices)
            {
                Console.WriteLine(device.Name);
            }
        }
    }
}
