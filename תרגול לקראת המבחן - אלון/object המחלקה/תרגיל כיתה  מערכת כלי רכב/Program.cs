namespace תרגיל_כיתה__מערכת_כלי_רכב
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("342-09-401", 120);
            Bicycle b1 = new Bicycle("NO PLATE", 30);
            Car c2 = new Car("83-348-81", 100);

            Vehicle[] vehicles = new Vehicle[3] { c1, b1, c2 };

            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine("---------");
                vehicles[i].ToString();
                vehicles[i].Move();
                if (vehicles[i] is Car)
                {
                    ((Car)vehicles[i]).TurnOnAirConditioner();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Testing equals : ");
            Car car1 = new Car("999-99-999", 100);
            Car car2 = new Car("999-99-999", 50);
            Console.WriteLine();
            Console.WriteLine($"Are you equal ? {car1.Equals(car2)}");
        }
    }
}
