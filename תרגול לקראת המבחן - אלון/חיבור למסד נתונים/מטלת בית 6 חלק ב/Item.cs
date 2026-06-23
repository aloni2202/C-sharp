using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_בית_6_חלק_ב
{
    internal class Item
    {
        public int ItemCode { get; set; }
        public string Name { get; set; }
        public string Descripion { get; set; }
        public double Price { get; set; }

        public Item(int code, string name, string description, double price)
        {
            ItemCode = code;
            Name = name;
            Descripion = description;
            Price = price;
        }
        public Item(string name, string description, double price)
        {
            Name = name;
            Descripion = description;
            Price = price;
        }
    }
}
