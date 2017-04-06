using System;

namespace HomeWork5
{
    class Wheel : Car, IRotatable
    {
        private uint numberWheel;

        public Wheel(uint numberWheel)
        {
            this.numberWheel = numberWheel;
        }

        public override string Name
        {
            get { return "Колесо"; }
        }

        public uint NumberWheel
        {
            get { return numberWheel; }
        }

        public void Move()
        {
            Console.WriteLine($"{Name} №{NumberWheel} машины {ModelName} вращается");
        }      
    }
}