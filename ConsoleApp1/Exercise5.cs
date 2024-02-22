using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava
{
    internal class Exercise5
    {
        public static void Run() 
        {
            Dictionary<String, int> words = new Dictionary<string, int>();
            string str = "";
            while (str != "stop")
            {
               str = Console.ReadLine();
                foreach (var word in str.Split(" "))
                {
                    if (words.ContainsKey(word))
                    {
                        words[word]++;
                    } else
                    {
                        words.Add(word, 1);
                    }
                }
            }
            Console.WriteLine("FREQUENCY TABLE");
            Console.WriteLine("-----------------");
            foreach (string word in words.Keys)
            {
                Console.WriteLine($"{word}:  {words[word]}");
            }

            
        }
    }
}
