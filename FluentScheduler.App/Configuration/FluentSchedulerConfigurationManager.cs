using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FluentScheduler.App.Configuration
{
    public class FluentSchedulerConfigurationManager
    {
        public static IConfigurationRoot GetConfiguration()
        {
            var configuration = new ConfigurationManager()
                                               .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                                               .AddJsonFile("appsettings.json").Build();

            return configuration;
        }

        public static string GetConfigKeyValue(string key)
        {
            var value = GetConfiguration().GetSection(key).Value;
            return value;
        }
    }
}
