using System;
using Common;
namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint lenghtMas;

            if (!Utils.TryEnterNumberFromConsole(out lenghtMas))
            {
                Console.Read();
                return;
            }

            int[] masLenghtMas;
            masLenghtMas = CreatMas(lenghtMas);

            SortAndPrintMas(masLenghtMas, lenghtMas);

            Console.Read();
        }
       
        static int[] CreatMas(uint lenght)
        {
            Console.WriteLine("Массив длиной " + lenght + ":");

            int[] mas = new int[lenght];
            Random r = new Random();

            for (int i = 0; i < lenght; i++)
            {
                mas[i] = r.Next(0, 100);
                Console.Write(mas[i] + " ");
            }
            return mas;
        }

        static void SortAndPrintMas(int[] mas, uint leghtSortMas)
        {
            Console.WriteLine();
            Console.WriteLine("Массив после пузырьковой сортировки:");

            int[] sortMas = new int[leghtSortMas];
            sortMas = mas;
            int temp;
            for (int i = 0; i < sortMas.Length; i++)
            {
                for (int j = i + 1; j < sortMas.Length; j++)
                {
                    if (sortMas[i] > sortMas[j])
                    {
                        temp = sortMas[i];
                        sortMas[i] = sortMas[j];
                        sortMas[j] = temp;
                    }
                }
            }
            for (int i = 0; i < sortMas.Length; i++)
            {
                Console.Write(sortMas[i] + " ");
            }
        }
    }
}