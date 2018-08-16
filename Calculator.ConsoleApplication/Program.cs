using System;

namespace Calculator.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculator App ***");
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());            
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            // Avinash Program code------------------------------------

            Console.WriteLine("\n--------------Avinash Math Operations---------------------");

            MathOperations.Addition(firstNumber, secondNumber);
            MathOperations.Subtraction(firstNumber, secondNumber);
            MathOperations.Multiplication(firstNumber, secondNumber);
            MathOperations.Division(firstNumber, secondNumber);
            
            Console.WriteLine("-----------------------------------------------------------");

            // Durga Program code------------------------------------


            Console.WriteLine("\n--------------Durga Math Operations---------------------\n");

            DurgaMathOperations mathoperations = new DurgaMathOperations();

            mathoperations.addition(firstNumber, secondNumber);
            mathoperations.subtraction(firstNumber, secondNumber);
            mathoperations.multiplication(firstNumber, secondNumber);
            mathoperations.division(firstNumber, secondNumber);
            mathoperations.Reminder(firstNumber, secondNumber);

            Console.WriteLine("\nPress any key to continue....................");
            Console.ReadKey();
        }
    }

    
}
