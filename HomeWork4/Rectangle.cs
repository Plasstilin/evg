using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Rectangle : Figure
    {
        private uint Length;
        private uint Widthe;

        public Rectangle(uint length, uint width, string name) : base(name)
        {
            this.Length = length;
            this.Widthe = width;
        }

        public override uint PerimetrOfTheFigure()
        {
            return 2 * (Length + Widthe);
        }

        public override uint AreaOfTheFigure()
        {
            return Length * Widthe;
        }
    }
}
