using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(9, 6, "название фигуры");
            Sector sector = new Sector(5, 15, "название фигуры");
            Circle circle = new Circle(10, "название фигуры");
            Triangle triangle = new Triangle(8, -9, 9, "название фигуры");

            Console.WriteLine(rectangle.IsError()
                ? string.Format("{0}:\nПлощадь = {1}. Периметр = {2}\n", rectangle.GetName(), rectangle.AreaOfTheFigure(), rectangle.PerimetrOfTheFigure())
                : string.Format("{0}:\nЗначение должно быть больше 0\n", rectangle.GetName()));

            Console.WriteLine(sector.IsError() ?
                $"{sector.GetName()} :\nПлощадь = {sector.AreaOfTheFigure()}. Периметр = {sector.PerimetrOfTheFigure()} \n" 
                : $"{sector.GetName()}:\nЗначение должно быть больше 0\n"); 
            
            if (circle.IsError())
            {
                Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", circle.GetName(), circle.AreaOfTheFigure(), circle.PerimetrOfTheFigure());
            }
            else Console.WriteLine("{0}:\nЗначение должно быть больше 0\n", circle.GetName());

            if (triangle.IsError())
            {
                Console.WriteLine("{0}:\nПлощадь = {1}. Периметр = {2}\n", triangle.GetName(), triangle.AreaOfTheFigure(), triangle.PerimetrOfTheFigure());
            }
            else Console.WriteLine("{0}:\nЗначение должно быть больше 0\n", triangle.GetName());
           
            Console.Read();
        }
    }
}