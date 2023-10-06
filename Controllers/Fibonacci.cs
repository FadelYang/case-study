using Microsoft.AspNetCore.Mvc;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("fibonacciList")]
        public ActionResult<List<int>> GetFibonnaciNumberList(int iteration)
        {
            List<int> fibonacciList = new();
            int a = 0;
            int b = 1;

            for (int i = 0; i < iteration; i++)
            { 
                int temp = a;
                a = b;
                b = temp + b;

                fibonacciList.Add(a);
            }

            return fibonacciList;
        }
    }
}