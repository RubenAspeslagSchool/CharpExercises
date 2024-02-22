using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    internal class Exercise1Yield
    {
        public static void Run() 
        {
            Console.WriteLine("-------------- Exercise 1");

            Console.WriteLine("--- Exercise 1A");
            Fibonacci(10)
               .ToList()
               .ForEach(number => Console.WriteLine(number));
           
            
            Console.WriteLine("--- Exercise 1B");
            Console.WriteLine("Please enter a text: ");
            string myText = Console.ReadLine().Trim().ToLower();
            string myReversedText = string.Concat(Reverse(myText));

            Console.WriteLine($"The text {myText} is {(myText == myReversedText ? "a" : "not a")} palindrome");
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

       

        private static IEnumerable<Char> Reverse(string myText)
        {
            for (int i = myText.Length - 1; i >= 0; i--)
            {
                yield return myText[i];
            }
        }
    }
}
