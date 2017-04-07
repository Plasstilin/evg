using System;
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
            Console.WriteLine("Введите число строк матрицы: ");
            uint howManyLine = Convert.ToUInt32 (Console.ReadLine());  
            
            Console.WriteLine("Введите число столбцов матрицы: ");
            uint howManyСolumn = Convert.ToUInt32(Console.ReadLine());

            Matrix A = new Matrix(howManyLine, howManyСolumn);

            Console.WriteLine("Создана матрица А");

            A.CreatMatrix();
            A.PrintMatrix();
          
            Matrix B = new Matrix(howManyLine, howManyСolumn);

            Console.WriteLine("Создана матрица B");

            B.CreatMatrix();   
            B.PrintMatrix();

            Console.Read();
        }
    }
}
