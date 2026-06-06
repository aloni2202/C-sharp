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
            return dt;

        }
        public DataTable FilterByAbovePrice(int price)
        {
            return dt;
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
            db.UpdateDB(table);
            return dt;
        }
    }
}
