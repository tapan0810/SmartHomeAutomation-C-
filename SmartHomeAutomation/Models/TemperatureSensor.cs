using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeAutomation.Delegates;

namespace SmartHomeAutomation.Models
{
    public class TemperatureSensor
    {
        private int _temprature;

        public event TempratureChangedHandler? TempratureChanged;

        public void SetTemprature(int temprature)
        {
            _temprature = temprature;

            Console.WriteLine($"Temperature Sensor: Current Temprature = {_temprature}°C");

            TempratureChanged?.Invoke(temprature);
        }

        public int GetTemprature()
        {
            return _temprature;
        }

    }
}
