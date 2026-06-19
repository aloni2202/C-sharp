namespace חריגות_תרגיל_בית__שאלה_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers;
            double liters;
            try
            {
                Console.WriteLine("Please enter the KM that you drive : ");
                kilometers = double.Parse(Console.ReadLine());

                if (kilometers > 999 || kilometers <= 0)
                {
                    throw new IndexOutOfRangeException();
                }

                Console.WriteLine("Please enter how much liters you refuel : ");
                liters = double.Parse(Console.ReadLine());

                double fuelEconomy = kilometers / liters;

                Console.WriteLine($"Kilometers is : {fuelEconomy} km per liter");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The input is not in format please try again ...");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The kilometers is not in the range ...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
