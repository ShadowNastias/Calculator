using System;

namespace Calculator
{
    static class Program
    {
        private static void Main(string[] args)
        {
            MyCalculator calculator = new MyCalculator();
            
            Console.WriteLine("Enter the first number:");
            var num1 = Convert.ToDouble(Console.ReadLine());
        
            while (true)
            {
                Console.WriteLine("Enter operation (+,-,*./) or press Esc to finish:");

                var pressedKey = Console.ReadKey(intercept: true);
                
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Shut down...");
                    break; ;
                }

                var operation = Console.ReadLine();
                
                if (operation != "+" &&
                    operation != "-" &&
                    operation != "*" && 
                    operation != "/")
                {
                    Console.WriteLine("Invalid operation. Use +, -, *, or /.");
                }
                
                Console.WriteLine("Enter next number:");
                var num2 = Convert.ToDouble(Console.ReadLine());
                    
                switch (operation)
                {
                    case "+":
                        num1 = calculator.Add(num1, num2);
                        break;
                    case "-":
                        num1 = calculator.Subtract(num1, num2);
                        break;
                    case "*":
                        num1 = calculator.Multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero."); 
                            continue;
                        }
                        num1 = calculator.Devide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Use +, -, *, or /.");
                        break;
                }
            
                Console.WriteLine($"Current result: {num1}");

            }
        
            Console.WriteLine($"Final result: {num1}");
        }
    }
}