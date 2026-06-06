using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Task_6___חלק_ב
{
    internal class Store
    {
        DBConnection db;
        DataTable dt;

        public Store()
        {
            db = new DBConnection();
        }

        public DataTable KnightTable()
        {

        }
        public DataTable FilterByAbovePrice(int price)
        {

        }

        public DataTable InsertItem(Item item)
        {
            db.InsertItem(item);
            return dt;
        }
        public DataTable DeleteItem(int code)
        {
            db.DeleteItem(code);
            return dt;
        }

        public DataTable Update (DataTable table)
        {
            
        }
    }
}
