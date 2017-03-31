using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Circle : Figure
    {
        private uint Radius;

        public Circle(uint radius, string name) : base(name)
        {
            this.Radius = radius;
        }

        public override uint PerimetrOfTheFigure()
        {
            return 2 * (uint)(Math.PI) * Radius;
        }

        public override uint AreaOfTheFigure()
        {
            return (uint)((Math.PI) * Math.Pow(Radius, 2));
        }
    }
}
