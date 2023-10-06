namespace Services
{
    public class FibonacciService
    {
        public List<int> GenerateFibonacciList(int iteration)
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