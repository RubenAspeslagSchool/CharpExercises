using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise1
{
    internal class Exercise1
    {
        public static void Run() 
        {

            // 1A
            Console.WriteLine("---------------- 1A -------------");


            FactorialA fac = new FactorialA(5);
            Console.WriteLine(fac.Calculate());


            //1B
            Console.WriteLine("---------------- 1B -------------");

            FactorialB fac2 = new FactorialB() { Value = 6 };
            Console.WriteLine(fac2.Result);

            //1C
            Console.WriteLine("---------------- 1C -------------");
            Console.WriteLine(FactorialC.Calculate(5));



            Console.WriteLine("---------------- 1D -------------");

            Console.WriteLine(new FactorialD(5).Calculate());

            Console.WriteLine("---------------- 1E -------------");

            FactorialE fac5 = new FactorialE(5);
            Console.WriteLine(fac5.Result);

        }
    }
}
