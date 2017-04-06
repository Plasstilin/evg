
namespace HomeWork4
{
    class Sector : Figure
    {
        private double arcsLength;
        private double radius;

        public Sector(double Length, double Radius, string name)
        {
            this.radius = Radius;
            this.arcsLength = Length;
        }

        public override bool IsError()
        {
            return (arcsLength > 0 && radius > 0);
        }

        public override string GetName()
        {
            return "Сектор";
        }

        public override double PerimetrOfTheFigure()
        {
            return arcsLength * 2 * radius;
        }

        public override double AreaOfTheFigure()
        {
            return arcsLength * radius / 2;
        }
    }
}