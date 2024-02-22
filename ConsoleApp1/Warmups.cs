using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava
{
    internal class Warmups
    {

        public static void Run() 
        {
            Console.WriteLine("Warm Up");
            foreach (int i in Fibonacci(10))
            {
                Console.WriteLine(i);
            }
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
