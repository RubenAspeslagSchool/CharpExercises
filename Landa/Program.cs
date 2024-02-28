namespace Landa
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 16 ,17,28,29,35,55,73,82 };
            int oddLoc = list.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddLoc);

            IEnumerable<int> ints = list; //TODO: 

        }

        static IEnumerable<int> Filter(this IEnumerable<int> list, Func<int, bool> selector)
        {
            foreach (int x in list)
            {
                if (selector(x)) yield return x;
            }
        }
    }
}
