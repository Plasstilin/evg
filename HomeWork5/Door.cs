using System;

namespace HomeWork5
{
    class Door : Car, IDoor
    {
        private uint numberDoors;
        private bool openDoor = true;

        public Door(uint numberDoors)
        {
            this.numberDoors = numberDoors;
        }

        public uint NumberDoors
        {
            get { return numberDoors; }
        }

        public override string Name
        {
            get { return "Дверь"; }
        }

        public string IsOpenDoor
        {
            get
            {
                return openDoor ? string.Format("открыта") : string.Format("закрыта");
            }
        }

        public void Open()
        {
            Console.WriteLine($"{Name} машины {ModelName} {IsOpenDoor}");
            openDoor = false;
        }
    }
}