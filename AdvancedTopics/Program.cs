namespace AdvancedTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1A
            Fibonacci(10)
                .ToList()
                .ForEach(number => Console.WriteLine(number));
        }

        static IEnumerable<int> Fibonacci(int count)
        {
            int a = 0,
            b = 1;

            for (int i = 0; i < count; i++)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
