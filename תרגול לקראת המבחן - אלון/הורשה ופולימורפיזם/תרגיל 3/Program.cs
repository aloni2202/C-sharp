namespace תרגיל_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Alon", 22000);
            Mannager e2 = new Mannager("Asaf", 35000, 10);

            Employee[] employees = new Employee[] { e1, e2 };

            for (int i = 0; employees.Length > i; i++)
            {
                employees[i].Work();
                if (employees[i] is Mannager)
                {
                    Mannager m = (Mannager)employees[i];
                    m.AssignBonus();
                }
            }
        }
    }
}
