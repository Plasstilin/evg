using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите число строк матрицы: ");
            uint howManyLine = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы: ");
            uint howManyСolumn = Convert.ToUInt32(Console.ReadLine());

            Matrix A = new Matrix (howManyLine, howManyСolumn);
           
            Console.WriteLine("Создана матрица А");
           int[,] a = A.CreatMatrix();
            A.PrintMatrix();

            Console.WriteLine("Создана матрица B");
            int [,] b = A.CreatMatrix();
            A.PrintMatrix();

            Console.WriteLine("Сумма А и B");           
            A.AmountMatrixs(a, b);
            A.PrintMatrix();

            Console.WriteLine("Произведение А и B");
            if (howManyLine == howManyСolumn)
            {
                A.Multiplication(a, b);
                A.PrintMatrix();
            } else
            {
                Console.WriteLine("Учи матчасть!! Нельзя такие матрицы умножать друг на друга!");
            }

            Console.WriteLine("Произведение матрицы А и числа");          
            if (!Matrix.Utils.TryEnterNumberFromConsole(out number))
            {
                Console.Read();
                return;
            }
            A.MultiplicationNumber(a, number);
            A.PrintMatrix();

            Console.WriteLine("Транспонирование матрицы А ");
            A.Transpon(a);
           
            Console.Read();
        }
    }
}