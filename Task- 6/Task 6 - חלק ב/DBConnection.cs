using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Task_6___חלק_ב
{
    internal class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=Task6;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {

        }

        public DataTable ItemsTable()
        {
            
        }

        public DataTable FilterByAbovePrice(int price)
        {

        }

        public DataTable InsertItem(Item item)
        {

        }

        public DataTable DeleteItem(int code)
        {

        } 

        public void UpdateDB(DataTable table)
        {

        }
    }
}
