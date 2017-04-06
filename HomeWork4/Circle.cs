using System;

namespace HomeWork4
{
    class Circle : Figure
    {
        private double radius;

        public Circle(double radius, string name)
        {
            this.radius = radius;
        }

        public override bool IsError()
        {
            return (radius > 0);
        }

        public override string GetName()
        {
            return "Круг";
        }

        public override double PerimetrOfTheFigure()
        {
            return 2 * (Math.PI) * radius;
        }

        public override double AreaOfTheFigure()
        {
            return ((Math.PI) * Math.Pow(radius, 2));
        }
    }
}