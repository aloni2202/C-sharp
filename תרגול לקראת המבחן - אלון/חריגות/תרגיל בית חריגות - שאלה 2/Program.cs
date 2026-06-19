namespace תרגיל_בית_חריגות___שאלה_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 10000;
            string ID;
            string creditCard;
            double amountToGet = 0;

            try
            {
                Console.WriteLine("Please enter your ID : ");
                ID = Console.ReadLine();
                if (ID.Length != 9)
                {
                    throw new OverflowException();
                }
                Console.WriteLine("please enter your numbers of your credit card : ");
                creditCard = Console.ReadLine();
                if (creditCard.Length != 16)
                {
                    throw new OverflowException();
                }
                Console.WriteLine("Enter the amount that you want to get : ");
                amountToGet = double.Parse(Console.ReadLine());
                if (amountToGet > balance)
                {
                    throw new FormatException();
                }
                balance -= amountToGet;
                Console.WriteLine($"Account Balance : {balance}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Something wrong with the length of your credit card/ID ");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("you dont have enough cash in your account ...");
            }
            finally
            {
                Console.WriteLine("Press any key to continue ...");
            }
        }
    }
}
