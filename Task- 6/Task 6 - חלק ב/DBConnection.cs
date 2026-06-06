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
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;
        int res;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
        }

        public DataTable ItemsTable()
        {
            try
            {
                con.Open();
                strCmd = @"select * from TBitem";
                cmd = new SqlCommand(strCmd, con);
                ds = new DataSet();

                return dt;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        public DataTable FilterByAbovePrice(int price)
        {
            return dt;
        }

        public DataTable InsertItem(Item item)
        {
            ExcNonQ($"INSERT INTO TBitems" +
                $"(Name ,Desscription , Price)" +
                $"VALUES('{item.Name}' , '{item.Description}' , '{item.Price}')");
            if (res == 0)
            {
                MessageBox.Show("ERROR ! ");
            }
            return dt;
        }

        public DataTable DeleteItem(int code)
        {
            ExcNonQ("DELETE TBitems" +
                $"where code = '{code}'");
            if (res == 0)
            {
                MessageBox.Show("invalid value :(");
            }
            return dt;
        }

        public void UpdateDB(DataTable table)
        {
            ExcNonQ($"UPDATE TBitems" +
                $"SET Name = '{Data}'");
        }

        public int ExcNonQ(string sqlComm)
        {
            con = new SqlConnection(strCon);
            con.Open();
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
