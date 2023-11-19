using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
     interface IAdd
    {
        double Add(double x, double y);
    }
    interface ISubstract
    {
        double Substract(double x, double y);
    }
    interface IMultiply
    {
        double Multiply(double x, double y);
    }
    interface IDivide
    {
        double Divide(double x, double y);
    }
}
