using System;
using Microsoft.Extensions.Logging;

namespace Sheenam.Api.Broker.LoggingBroker
{
    public interface ILoggingBroker
    {
        void LogError(Exception exception);
        void LogCritical(Exception exception);
    }
}
