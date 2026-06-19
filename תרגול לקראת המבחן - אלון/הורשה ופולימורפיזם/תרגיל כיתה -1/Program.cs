namespace תרגיל_כיתה__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("mazda" , 2008 , 2);
            c1.PrintDetails();
            Car c2 = new Car("toyota" , 2020 ,  5);
            c2.PrintDetails();
        }
    }
}
