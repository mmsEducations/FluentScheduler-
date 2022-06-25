using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentScheduler.App.Job
{
    public class SchedulerJob : IJob
    {
        public void Execute()
        {
            var timeNow = $"The time is : { DateTime.Now: HH:mm:ss}";
            Console.WriteLine(timeNow);
        }
    }
}
