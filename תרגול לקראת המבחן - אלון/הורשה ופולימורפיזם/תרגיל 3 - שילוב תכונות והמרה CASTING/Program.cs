namespace תרגיל_3___שילוב_תכונות_והמרה_CASTING
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("Alon", 22000);
            Manager e2 = new Manager("Asaf", 35000, 10);

            Employee[] employees = new Employee[] { e1, e2 };
           
            for (int i = 0;employees.Length > i; i++)
            {
                employees[i].Work();
                if (employees[i] is Manager)
                {
                    Manager m = (Manager)employees[i];
                    m.AssignBonus();
                }
            }
        }
    }
}

