namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(12345 , 20000);
            a1.Withdraw(double.Parse(Console.ReadLine()));

            VipAccount vip1 = new VipAccount(11111, 20000);
            vip1.Withdraw(double.Parse(Console.ReadLine()));
        }
    }
}
