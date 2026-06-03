using SmartHomeAutomation.Interfaces;
using SmartHomeAutomation.Observers;
using SmartHomeAutomation.Sensors;

namespace SmartHomeAutomation.Controllers
{
    public class SmartHomeController
    {
        private readonly ILogger _logger;

        public SmartHomeController(
            TemperatureSensor temperatureSensor,
            MotionSensor motionSensor,
            SmartFan smartFan,
            SmartLight smartLight,
            NotificationService notification,
            ILogger logger)
        {
            _logger = logger;

            temperatureSensor.TempratureChanged += smartFan.Update;

            temperatureSensor.TempratureChanged += notification.TempratureNotification;

            motionSensor.MotionDetected += smartLight.MotionDetected;

            motionSensor.MotionDetected += notification.MotionNotification;

            _logger.Log("Smart Home Controller Initialized");
        }
    }
}