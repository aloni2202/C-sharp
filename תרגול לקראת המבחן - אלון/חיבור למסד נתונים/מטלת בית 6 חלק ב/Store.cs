using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace מטלת_בית_6_חלק_ב
{
    internal class Store
    {
        DBConnection DB;

        public Store()
        {
            DB = new DBConnection();
        }

        public DataTable ItemTable()
        {
            return DB.ItemsTable();
        }

        public DataTable FilterByAbovePrice(int price)
        {
            return DB.FilterByAbovePrice(price);
        }

        public DataTable InsertItem(Item item)
        {
            return DB.InsertItem(item);
        }
        public DataTable DeleteItem(int code)
        {
            return DB.DeleteItem(code);
        }
        public void Update(DataTable table)
        {
           
        }
    }
    }

