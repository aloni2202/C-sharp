using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace task6___חלק_א
{
    internal class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=Task6;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable TBitems;
        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadItemTable()
        {
            string res = "";
            try
            {
                con.Open();
                strCmd = "SELECT*" +
                "FROM TBitems";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item items = new Item(
                    reader["Name"].ToString(),
                    reader["Description"].ToString(),
                    int.Parse(reader["Price"].ToString()));
                    items.ItemCode = int.Parse(reader["Code"].ToString());
                    res += items.ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return res;
        }
        public int AddItemToDB(Item item)
        {
            try
            {
                con.Open();
                strCmd = $"insert into TBitems (Name, Description, Price) " +
                    $"values ('{item.Name}', '{item.Description}', {item.Price})";
                cmd = new SqlCommand(strCmd, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                if (con != null)
                    con.Close();

            }
        }
        public int DeleteItemFromDB(int Code)
        {
            try
            {
                con.Open();
                strCmd = $"delete from TBitems where code = {Code} ";
                cmd = new SqlCommand(strCmd, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
