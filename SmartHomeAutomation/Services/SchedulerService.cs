using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Services
{
    public class SchedulerService
    {
        private readonly List<Timer> _timers = new();

        public void ScheduleTask(Action action,int delayInSeconds)
        {
            Timer timer = new(_ => action(), null, TimeSpan.FromSeconds(delayInSeconds), Timeout.InfiniteTimeSpan);
            _timers.Add(timer);
        }
    }
}
