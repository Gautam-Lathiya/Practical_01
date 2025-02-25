using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = ReadNumber("Enter the first number : ");
            int num2 = ReadNumber("Enter the second number : ");
            Console.WriteLine($"The sum of {num1} and {num2} is {Calculator.Add(num1, num2)}");
            Console.WriteLine($"The subtraction of {num1} and {num2} is {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"The multiplication of {num1} and {num2} is {Calculator.Multiply(num1, num2)}");
            try
            {
                Console.WriteLine($"The division of {num1} and {num2} is {Calculator.Divide(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int ReadNumber(string msg)
        {
            Console.WriteLine(msg);
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid integer : ");
            }

            return number;
        }
    }
}
