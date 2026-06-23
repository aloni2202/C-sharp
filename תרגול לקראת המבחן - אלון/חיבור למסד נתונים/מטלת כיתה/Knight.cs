namespace מטלת_כיתה
{
    public class Knight
    {
        string firstName;
        string lastName;
        string power;

        public Knight(string firstName , string lastName , string power)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.power = power; 
        }

        public string FirstName { get { return firstName; } }
    
        public string LastName { get { return lastName; } }
        public string Power { get { return power; } }
    }
}