using System;

namespace DotNetSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input second number: ");
            double secondNumber = Double.Parse(Console.ReadLine());

            double adding = firstNumber + secondNumber;
            double subtraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;

            Console.WriteLine($"Result of adding, subtraction, multiplication and division are " +
                $"\n\r{adding} \n{subtraction} \n{multiplication} \n{division}");



        }
    }
}
