
namespace HomeWork4
{
    class Figure
    {

        public virtual bool IsError()
        {
            return false;
        }

        public virtual string GetName()
        {
            return "Неизвестная фигура";
        }

        public virtual double PerimetrOfTheFigure()
        {
            return 0;
        }

        public virtual double AreaOfTheFigure()
        {
            return 0;
        }
    }
}
