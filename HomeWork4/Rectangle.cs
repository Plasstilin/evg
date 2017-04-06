
namespace HomeWork4
{
    class Rectangle : Figure
    {
        private double length;
        private double widthe;

        public Rectangle(double length, double widthe, string name)
        {           
            this.length = length;
            this.widthe = widthe;
        }

        public override bool IsError()
        {
            return (length > 0 && widthe > 0);
        }

        public override string GetName()
        { 
            return "Прямоугольник";
        }
     
        public override double PerimetrOfTheFigure()
        {          
           return 2 * (length + widthe);
        }

        public override double AreaOfTheFigure()
        {
            return length * widthe;
        }
    }
}