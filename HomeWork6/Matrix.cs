﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreatMatrix()
        {
            matrix = new int[line, column];
            Random r = new Random();
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = r.Next(-100, 100);
                }
            }
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
    }
}
