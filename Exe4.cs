using System;

namespace DotNetSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstNumber = 2.5;

            double secondNumber = 3.9;

            double adding = firstNumber + secondNumber;
            double subtraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;

            Console.WriteLine($"Result of adding, subtraction, multiplication and division are " +
                $"\n\r{adding} \n{subtraction} \n{multiplication} \n{division}");

            
        }
    }
}
