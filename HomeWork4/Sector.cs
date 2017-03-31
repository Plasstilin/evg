using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Sector : Figure
    {
        private uint Length;
        private uint Radius;

        public Sector(uint Length, uint Radius, string name) : base(name)
        {
            this.Radius = Radius;
            this.Length = Length;
        }

        public override uint PerimetrOfTheFigure()
        {
            return Length * 2 * Radius;
        }

        public override uint AreaOfTheFigure()
        {
            return Length * Radius / 2;
        }
    }
}
