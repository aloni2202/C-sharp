namespace מטלת_כיתה
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create RoundTable obj
            RoundTable knights = new RoundTable();

            // Printing knights from db
            Console.WriteLine(knights.ToString());

            // Adding a new knight to the array in RoundTable and to DB 
            knights.AddKnigt(new Knight("Low", "Grade", "Electric Knight"));

            // Printing after the cahanges
            Console.WriteLine(knights.ToString());

            // Delete a knight from DB only
            knights.DeleteKnightFromDB(1);

            // Printing after the cahanges
            Console.WriteLine(knights.ToString());

            // Printing knights by power
            Console.WriteLine(knights.PrintKnightByPower("fire knight"));
        }
    }
}
