using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class QueueImplementController : ControllerBase
    {
        private readonly IQueueImplementService _queueService;

        public QueueImplementController(IQueueImplementService queueImplementService)
        {
            _queueService = queueImplementService;
        }

        [HttpGet("queueImplementation")]
        public ActionResult<IEnumerable<string>> GetQueueItems()
        {
            var queueItems = _queueService.GetQueueItems();
            return Ok(queueItems);
        }

        [HttpPost("queueImplementation")]
        public ActionResult AddQueueItem([FromBody, Required] string item)
        {
            _queueService.AddQueueItem(item);
            return Ok();
        }

        [HttpDelete("queueImpelementation")]
        public ActionResult RemoveQueueItem()
        {
            _queueService.RemoveQueueItem();
            return Ok();
        }
    }
}