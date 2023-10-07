using System;
using Calculator;

class Program
{
    static void Main(string[] args)
    {
        MyCalculator calculator = new MyCalculator();
        
        double result = calculator.Add(5, 7);
        Console.WriteLine($"Result of addition: {result}");
    }
}