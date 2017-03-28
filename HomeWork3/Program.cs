using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");

            String inputStroka = Console.ReadLine();
            Work w = new Work(inputStroka);

            w.PrintPolindromTest();
            w.PrintHowManyWord();
            w.PrintInverse();

            Console.Read();
        }      
    }
}
