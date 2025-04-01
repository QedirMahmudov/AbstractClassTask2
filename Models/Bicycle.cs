namespace AbstractClass2.Models
{
    internal class Bicycle : Vehicle
    {
        //Type??? 
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }

    }
}
