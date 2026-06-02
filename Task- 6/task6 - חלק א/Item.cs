using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace task6___חלק_א
{
    internal class Item 
    {
        public int ItemCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Item(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public Item(int code , string name, string description, int price)
        {
            ItemCode = code;
            Name = name;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"Code:{ItemCode} Name :{Name} Description: {Description} Price: {Price}";
        }

    }
}
