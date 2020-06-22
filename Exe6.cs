using System;

namespace DotNetSchool
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Input first number for adding: ");
            double firstNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number for adding: ");
            double secondNumber = Double.Parse(Console.ReadLine());
            double adding = firstNumber + secondNumber;

            Console.WriteLine();

            Console.WriteLine("Input first number for subtraction: ");
            double thirdnNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number for subtraction: ");
            double fourthNumber = Double.Parse(Console.ReadLine());
            double subtraction = thirdnNumber - fourthNumber;

            Console.WriteLine();

            Console.WriteLine("Input first number for multiplication: ");
            double fifthNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number for multiplication: ");
            double sixthNumber = Double.Parse(Console.ReadLine());
            double multiplication = fifthNumber * sixthNumber;

            Console.WriteLine();

            Console.WriteLine("Input first number for division: ");
            double seventhNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input second number for division: ");
            double eightthNumber = Double.Parse(Console.ReadLine());
            double division = seventhNumber / eightthNumber;

            Console.WriteLine();

            Console.WriteLine($"Result of\n {firstNumber} + {secondNumber} is {adding}\n {thirdnNumber} - {fourthNumber} is {subtraction}\n {fifthNumber} * {sixthNumber} is {multiplication}\n {seventhNumber} / {eightthNumber} is {division}"); 



        }
    }
}
