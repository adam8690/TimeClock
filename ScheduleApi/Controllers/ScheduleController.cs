using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleApi.Storage;

namespace ScheduleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {

        private readonly ILogger<ScheduleController> _logger;
        private readonly FileWriter _writer;

        public ScheduleController(ILogger<ScheduleController> logger, FileWriter writer)
        {
            _logger = logger;
            _writer = writer;
        }

        [HttpGet]
        public Schedule Get()
        {
            return _writer.ReadFromJsonFile();
        }

        [HttpPost]
        public StatusCodeResult Post([FromBody] Schedule schedule)
        {
            _writer.WriteToJsonFile(schedule);
            return new StatusCodeResult(200);
        }
    }
}
