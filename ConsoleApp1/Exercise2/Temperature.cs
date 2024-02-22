using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise2
{
    internal class Temperature
    {
        private double _Celsius;
        private double _Fahrenheit;
        private double _Kelvin;


        public double Celsius
        {
            get { return _Celsius; }
            init 
            {
                _Celsius = value;
                _Fahrenheit = _Celsius * 9.0 / 5.0 + 32;
                _Kelvin = _Celsius + 273.15;
            }
        }

        public double Fahrenheit 
        {
            get { return _Fahrenheit;}
            init 
            {
                _Fahrenheit = value;
                _Celsius = (_Fahrenheit - 32) * 5.0 / 9.0;
                _Kelvin = (_Fahrenheit - 32) * 5.0 / 9.0 + 273.15;
            }
        }
        public double Kelvin 
        { 
            get { return _Kelvin; }
            init 
            {
                _Kelvin = value;
                _Celsius = _Kelvin - 273.15;
                _Fahrenheit = (_Kelvin - 273.15) * 9.0 / 5.0 + 32;
            }
        }

        public void Deconstruct (out double c,out double f,out double k)  
        {
            c = Celsius;
            f = Fahrenheit;
            k = Kelvin;
        }
    }
}
