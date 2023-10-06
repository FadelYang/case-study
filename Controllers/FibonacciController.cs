using Microsoft.AspNetCore.Mvc;
using Services;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FibonacciController : ControllerBase
    {
        private readonly FibonacciService _fibonacciService;

        public FibonacciController(FibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        [HttpGet("fibonacciList")]
        public ActionResult<List<int>> GetFibonnaciNumberList(int iteration)
        {
            List<int> fibonacciList = _fibonacciService.GenerateFibonacciList(iteration);
            
            return fibonacciList;
        }
    }
}