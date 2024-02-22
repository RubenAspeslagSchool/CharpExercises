using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactorialD(int value)
    {
        public int Calculate()
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
