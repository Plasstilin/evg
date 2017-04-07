using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {            
            Car car = new Car(4,5);

            Console.WriteLine($"{car.ModelName} имеет {car.HowManyWheels} колёса и {car.HowManyDoors} дверей");

            foreach (Detail i in car.detailMas)
            {
                (i as IRotatable)?.Move();
                (i as IDoor)?.Open();
                (i as IDoor)?.Open();
            }

            Console.Read();
        }
    }    
}