namespace תרגיל_בית_3___פולימורפיזם
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(12345, 10000);
            a.Withdraw(3333);
            VipAccount v = new VipAccount(1235, 10000);
            v.Withdraw(150);
        }
    }
}
