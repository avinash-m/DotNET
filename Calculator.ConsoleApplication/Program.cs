using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Addition(firstNumber, secondNumber);
            Subtraction(firstNumber, secondNumber);
            Division(firstNumber, secondNumber);
            Remainder(firstNumber, secondNumber);
            Console.WriteLine("--------------");
            Console.ReadKey();
        }

        static void Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine($"Addition of numbers: { sum }");
        }

        // Durga Subtraction code

        static void Subtraction(double firstNumber, double secondNumber)
        {
            double subtract = firstNumber - secondNumber;
            Console.WriteLine("Subtraction of Numbers: {0}", subtract);                
        }

        // Avinash
        static void Division(double firstNumber, double secondNumber)
        {
            double quotient = firstNumber / secondNumber;
            Console.WriteLine($"Division of Numbers: {quotient:0.000}");
        }

        static void Remainder(double firstNumber, double secondNumber)
        {
            double remainder = firstNumber % secondNumber;
            Console.WriteLine($"Remainder of Numbers: {remainder:0.000}");
        }
    }

    
}
