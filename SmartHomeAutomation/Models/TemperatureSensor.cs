using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartHomeAutomation.Delegates;

namespace SmartHomeAutomation.Sensors
{
    public class TemperatureSensor
    {
        private int _temperature;

        public event TempratureChangedHandler? TempratureChanged;

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;

            Console.WriteLine(
                $"\nTemperature Changed : {temperature}°C");

            TempratureChanged?.Invoke(temperature);
        }

        public int GetTemperature()
        {
            return _temperature;
        }
    }
}
