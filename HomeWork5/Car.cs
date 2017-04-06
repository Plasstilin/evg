
namespace HomeWork5
{
    public class Car : Detail
    {

        string modelName = "Брусничка";
        uint howManyWheels;
        uint howManyDoors;
        public Detail[] detailMas = new Detail [3] ;

        public Car()
        {
        }

        public Car(uint howManyWheels, uint howManyDoors)
        {

            this.howManyWheels = howManyWheels;
            this.howManyDoors = howManyDoors;

            detailMas[0] = new Wheel(4);
            detailMas[1] = new Door(5);
            detailMas[2] = new Body();
            
        }

        public override string Name
        {
            get { return "Автомобиль"; }
        }

        public override uint Weight { get; set; }

        public string ModelName
        {
             get { return modelName; }
            set { value = modelName; }
        }

        public uint HowManyWheels
        {
            get { return howManyWheels; }
        }

        public uint HowManyDoors
        {
            get { return howManyDoors; }
        }
    }
}
