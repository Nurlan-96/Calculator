using Calculator.Services;

Calc calc1 = new ();
Console.WriteLine(calc1.Multiply(10, 5));
Console.WriteLine(calc1.Substract(10, 5));
Console.WriteLine(calc1.Add(10, 5));
Console.WriteLine(calc1.Divide(10, 0));