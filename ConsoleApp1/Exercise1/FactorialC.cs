using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise1
{
    public class FactorialC
    {
        public static int Calculate(int value)
        {
            int factorial = 1;

            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
