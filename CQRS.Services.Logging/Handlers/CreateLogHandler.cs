using System;
using System.Threading.Tasks;
using CQRS.Common.Commands;
using CQRS.Common.Events;
using RawRabbit;

namespace CQRS.Services.Logging.Handlers
{
    public class CreateLogHandler: ICommandHandler<CreateLog>
    {
        private readonly IBusClient _busClient;

        public CreateLogHandler(IBusClient buslient)
        {
            _busClient = buslient;
        }

        public async Task HandleAsync(CreateLog command)
        {
            Console.WriteLine($"Creating Log:{command.Name}");
            await _busClient.PublishAsync(new LogCreated(command.Id, command.Name, command.Description));

        }
    }
}