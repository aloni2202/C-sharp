using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_ב_6_חלק_א
{
    internal class Store
    {

        DBConnection DB;

        public Store()
        {
            DB = new DBConnection();
        }

        public string AddItem(Item item)
        {
            int res = DB.AddItemToDB(item);
            if (res != 0)
            {
                return "1 item added";
            }
            else
            {
                return "no item added";
            }
        }
        public string DeleteItem(int code)
        {
            int res = DB.DeleteItemFromDB(code);
            if (res != 0)
            {
                return "1 row deletes";
            }
            else
            {
                return "no row deleted";
            }
        }
        public override string ToString()
        {
            string list = DB.ReadItemTable();
            if (list == "")
            {
                return "No items";
            }
            else
            {
                return list;
            }
        }
    

    }
}
