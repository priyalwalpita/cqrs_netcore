using System;
using System.Threading.Tasks;
using CQRS.Common.Events;

namespace CQRS.Api.Handlers
{
    public class LogCreatedHandler: IEventHandler<LogCreated>
    {
        public async Task HandleAsync(LogCreated log)
        {
            await Task.CompletedTask;
            Console.WriteLine("Logging created:" + log.Id);
        }
    }
}