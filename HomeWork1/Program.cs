using System;
using Common;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number1;
            uint number2;
            uint number3;

            if (!Utils.TryEnterNumberFromConsole(out number1)||
                !Utils.TryEnterNumberFromConsole(out number2)||
                !Utils.TryEnterNumberFromConsole(out number3))
            {
                Console.Read();

                return;
            }

            uint temp =  (number1 > number2) ? number1 : number2; 
            uint numberMin = (temp > number3) ? number3 : temp;

            Console.WriteLine("Минимальное число: " + numberMin);

            PrintFibNumberLessThanNumber(number1);
            PrintFibNumberLessThanNumber(number2);
            PrintFibNumberLessThanNumber(number3);

            Console.Read();
        }

        static void PrintFibNumberLessThanNumber(uint number)
        {
            Console.Write("Числа Фибоначчи меньшие числа " + number.ToString() + ": ");
            uint firstFibNumber = 0;
            uint secondFibNumber = 1;
            if (number != 0)
            {
                Console.Write(firstFibNumber + " ");
            }

            while (secondFibNumber < number)
            {
                Console.Write(secondFibNumber + " ");
                uint nextSecondNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextSecondNumber;
            }

            Console.WriteLine();
        }
    }
}
