using Microsoft.AspNetCore.Mvc;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class QuickSortController : ControllerBase
    {
        [HttpGet("getSortedData")]
        public ActionResult<int[]> GetSortedData([FromBody] int[] arr)
        {
            var sorted = QuickSort(arr, 0, arr.Length - 1);

            return sorted;
        }
        public static int[] QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partion(arr, start, end);
                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }

            return arr;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Partion(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIndex = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] < pivot)
                {
                    swapIndex++;
                    Swap(arr, i, swapIndex);
                }
            }

            Swap(arr, start, swapIndex);
            return swapIndex;
        }
    }
}