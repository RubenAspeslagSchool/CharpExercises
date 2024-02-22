using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactorialE(int value)
    {
        public int Result => Calculate();

        //public FactorialE( )
        //{
        //    this.Value = value;
        //}

        public int Calculate()
        {
            Console.WriteLine($"value: {value}");
            int factorial = 1;

            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
