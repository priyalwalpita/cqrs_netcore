using System;
using System.Threading.Tasks;
using CQRS.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace CQRS.Api.Controllers
{
    [Route("[controller]")]
    public class LoggingController : Controller
    {
        private readonly IBusClient _busClient;

        public LoggingController(IBusClient busClient)
        {
            _busClient = busClient;
        }
        
        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateLog command)
        {
            command.Id = Guid.NewGuid().ToString();
            await _busClient.PublishAsync(command);

            return Accepted($"logging /{command.Id}");
        }
    }
}