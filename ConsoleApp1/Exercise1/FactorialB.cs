using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise1
{
    public class FactorialB
    {
        private int _value;
        private int _result;


        public int Value { get; init; }

        public int Result { get => Calculate(); }



        public int Calculate()
        {
            int factorial = 1;

            for (int i = 1; i <= Value; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
