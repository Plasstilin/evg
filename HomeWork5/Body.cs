using System;

namespace HomeWork5
{
    class Body : Car, IRotatable, IDoor
    {
        public void Move()
        {
            Console.WriteLine($"Машина {ModelName} едет");
        }

        public void Open()
        {
            Console.WriteLine("Увы, это не дверь");
        }
    }
}