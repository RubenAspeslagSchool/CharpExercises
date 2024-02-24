namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> myArray = new MyArray<int>(5);
            MyArray<string> str = new MyArray<string>(5);
        }
    }
}
