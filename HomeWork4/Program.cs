using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(5, 6, "Прямоугольник");
            Sector sector = new Sector(8, 15, "Сектор");
            Circle circle = new Circle(10, "Круг");
            Triangle triangle = new Triangle(8, 5, 9, "Треугольник");

            Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", rectangle.GetName(), rectangle.AreaOfTheFigure(), rectangle.PerimetrOfTheFigure());          
            Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", sector.GetName(), sector.AreaOfTheFigure(), sector.PerimetrOfTheFigure());         
            Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", circle.GetName(), circle.AreaOfTheFigure(), circle.PerimetrOfTheFigure());
            Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", triangle.GetName(), triangle.AreaOfTheFigure(), triangle.PerimetrOfTheFigure());

            Console.Read();
        }
    }
}
