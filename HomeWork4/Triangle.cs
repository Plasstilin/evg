using System;

namespace HomeWork4
{
    class Triangle : Figure
    {

        private double oneSide;
        private double twoSide;
        private double threeSide;

        public Triangle(double oneSide, double twoSide, double threeSide, string name)
        {
            this.oneSide = oneSide;
            this.twoSide = twoSide;
            this.threeSide = threeSide;
        }

        public override bool IsError()
        {
            return (oneSide > 0 && twoSide > 0 && threeSide > 0);
        }

        public override string GetName()
        {
            return "Треугольник";
        }

        public override double PerimetrOfTheFigure()
        {
            return oneSide + twoSide + threeSide;
        }

        public override double AreaOfTheFigure()
        {
            double temp = this.PerimetrOfTheFigure() / 2;
            return (Math.Sqrt(temp * ((temp - oneSide) * (temp - twoSide) * (temp - threeSide))));
        }
    }
}