using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactorialA
    {
        public int Value { get; set; }

        public FactorialA(int value)
        {
                Value = value;  
        }

        public int Calculate()
        {
            int factorial = 1;

            for (int i = 1; i <= Value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

public int CalculateJB()
{
    int factorial = Value;

    for (int i = Value - 1; i >= 1; i--)
    {
        factorial *= i;
    }

    return factorial;
}

    }
}
