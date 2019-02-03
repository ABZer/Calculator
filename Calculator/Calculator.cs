using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            double powerRes = 1;

            for (int i = 0; i < exp; ++i)
            {
                powerRes = powerRes * x;
            }

            return powerRes;
        }
    }
}
