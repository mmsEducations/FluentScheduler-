using FluentScheduler.App.Configuration;
using FluentScheduler.App.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentScheduler.App.Scheduler
{
    public class FluentSchedulerRegistery : Registry
    {
        //Job'ın Hangi ayarlara göre ne zaman çalışacağını belirtir
        public FluentSchedulerRegistery()
        {
            var interval = int.Parse(FluentSchedulerConfigurationManager.GetConfigKeyValue("JobIntervalForEvrySeconds"));

            Schedule<SchedulerJob>()
                    .NonReentrant() // Çalışma anında job'ın  tek bir instance üzerinden çalışmasını sağlar 
                    .ToRunNow()    //Hemen çalıştır 
                    .AndEvery(interval).Seconds();  //Interval
        }
    }
}
 