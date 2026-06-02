using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6___חלק_ב
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
        public Item(int code, string name, string description, int price)
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
