using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    abstract class  Figure
    {
        private string Name;

        public Figure(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name; // Console.WriteLine(Name);
        }

        public abstract uint PerimetrOfTheFigure();

        public abstract uint AreaOfTheFigure();

    }
}
