using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_2
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public bool IsFamily { get; set; }

        public Contact(string name , string adress , string phone , bool isFamily)
        {
            Name = name;
            Adress = adress;
            Phone = phone;
            IsFamily = isFamily;
        }

        public override string ToString()
        {
            return $"{Name}\t {Adress}\t {Phone}\t {(IsFamily ? "From Family" : "not From Family" )}";
        }


    }
}
