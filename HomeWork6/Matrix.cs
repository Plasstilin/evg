using System;

namespace HomeWork6
{
    class Matrix
    {
        uint line;
        uint column;
        int[,] matrix;

        public Matrix(uint line, uint column)
        {
            this.line = line;
            this.column = column;
        }

        public static class Utils
        {
            public static bool TryEnterNumberFromConsole(out int number)
            {
                Console.Write("Введите число: ");
                string numberAsString = Console.ReadLine();

                if (!(int.TryParse(numberAsString, out number)))
                {
                    Console.Write("Ввели не число");
                    return false;
                }
                return true;
            }
        }

        public int[,] CreatMatrix()
        {
            matrix = new int[line, column];
            Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < line; i++)
            {

                for (int j = 0; j < column; j++)
                {

                    matrix[i, j] = r.Next(-100, 100);
                }
            }
            return matrix;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void AmountMatrixs(int[,] a, int[,] b)
        {
            matrix = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = a[i, j] + b[i, j];
                }
            }
        }

        public void Multiplication(int[,] a, int[,] b)
        {
            matrix = new int[line, column];

            for (uint i = 0; i < line; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    for (uint r = 0; r < column; r++)
                    {
                        matrix[i, j] += a[i, r] * b[r, j];
                    }
                }
            }
        }

        public void MultiplicationNumber(int[,] a, int number)
        {
            matrix = new int[line, column];

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = a[i, j] * number;
                }
            }
        }

        public void Transpon(int[,] a)
        {
            matrix = new int[column, line];

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    matrix[i, j] = a[j, i];
                    Console.Write(matrix[i, j] + " \t ");
                }
                Console.WriteLine();
            }
        }
    }
}