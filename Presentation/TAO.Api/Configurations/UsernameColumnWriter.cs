using System.Data.SqlTypes;
using Serilog.Events;
using System.Data;
using Serilog.Core;

namespace TAO.Api.Configurations
{
    public class CustomUserNameColumn : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var (username, value) = logEvent.Properties.FirstOrDefault(x => x.Key == "UserName");

            if (value != null)
            {
                var getValue = propertyFactory.CreateProperty(username, value);

                logEvent.AddPropertyIfAbsent(getValue);
            }

        }

    }
}
