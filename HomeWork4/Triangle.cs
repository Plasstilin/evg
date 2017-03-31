using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Triangle : Figure
    {

        private uint OneSide;
        private uint TwoSide;
        private uint ThreeSide;

        public Triangle(uint OneSide, uint TwoSide, uint ThreeSide, string name) : base(name)
        {
            this.OneSide = OneSide;
            this.TwoSide = TwoSide;
            this.ThreeSide = ThreeSide;
        }

        public override uint PerimetrOfTheFigure()
        {
            return OneSide + TwoSide + ThreeSide;
        }

        public override uint AreaOfTheFigure()
        {
            uint var = this.PerimetrOfTheFigure() / 2;
            return (uint)(Math.Sqrt(var * ((var - OneSide) * (var - TwoSide) * (var - ThreeSide))));
        }
    }
}
