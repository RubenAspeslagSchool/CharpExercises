using System.Security.Principal;
using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- warmup ------");
            Console.WriteLine(new Warmup().Run("10,5,0,8,10,1,4,0,10,1"));

           new Exercise1BasicQueries().Run();
          new Exercises2CustomClass().Run();
        }

        
        
    }
}
