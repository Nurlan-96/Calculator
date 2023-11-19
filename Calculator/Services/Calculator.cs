using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Calc : IAdd, ISubstract, IMultiply, IDivide
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Can't divide by zero. Please write a different value for 'y'");
                int newY= int.Parse(Console.ReadLine());
                return x/newY;
            }
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return (x * y);
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }
    }
}
