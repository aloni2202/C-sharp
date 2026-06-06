using System;
using System.Collections.Generic;
using System.Text;

namespace task6___חלק_א
{
    internal class Store
    {
        Item[] items;
        DBConnection db;
        int count;
        public Store()
        {
            items = new Item[0];
            count = 0;
            db = new DBConnection();
        }
        public void AddItem(Item newItem)
        {
            int rowAffected = db.AddItemToDB(newItem);
            Console.WriteLine($"{rowAffected} row added ");
        }
        public void DeleteItem(int code)
        {
            int rowDeleted = db.DeleteItemFromDB(code);
            Console.WriteLine($"{rowDeleted} row deleted");
        }
        public override string ToString()
        {
            string list = db.ReadItemTable();
            if (list == "")
            {
                return "No Item";
            }
            else
            {
                for (int i = 0; i <= count; i++)
                {
                   
                } 
                return list;
            }
        }
    }
}