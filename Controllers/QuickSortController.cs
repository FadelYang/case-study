using Microsoft.AspNetCore.Mvc;
using Services;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class QuickSortController : ControllerBase
    {
        private readonly IQuickSortService _quickSortService;

        public QuickSortController(IQuickSortService quickSortService)
        {
            _quickSortService = quickSortService;
        }


        [HttpGet("getSortedData")]
        public ActionResult<int[]> GetSortedData([FromBody] int[] arr)
        {
            var sorted = _quickSortService.QuickSort(arr, 0, arr.Length - 1);

            return sorted;
        }
        
    }
}