namespace תרגיל_כיתה_2
{
    internal class Program
    {
        static void StartCharging(IRechargeable device)
        {
            device.Recharege();
        }
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone();
            StartCharging(phone);
            ElectricCar electricCar = new ElectricCar();
            StartCharging(electricCar);
        }
    }
}
