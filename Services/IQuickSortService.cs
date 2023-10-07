namespace Services
{
    public interface IQuickSortService
    {
        int[] QuickSort(int[] arr, int start, int end);

        void Swap(int[] arr, int i, int j);

        int Partion(int[] arr, int start, int end);
    }
}