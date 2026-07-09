namespace תרגיל_כיתה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Smartphone s= new Smartphone();
            StartCahrging(s);
            ElectricCar car= new ElectricCar();
            StartCahrging(car);
        }

        static void StartCahrging(IRechargeable device)
        {
                device.Recharge();
        }
    }
}

