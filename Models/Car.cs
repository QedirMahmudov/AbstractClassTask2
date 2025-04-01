using AbstractClass2.Models;

namespace AbstractClass2
{
    internal class Car : Vehicle
    {
        private int _doorCount;

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                _doorCount = value;
            }
        }
        public bool IsElectricCar { get; set; }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar == true)
            {
                Console.WriteLine("LoW");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"DoorCount: {DoorCount}, IsElectric: {IsElectricCar}");
        }
    }
}
