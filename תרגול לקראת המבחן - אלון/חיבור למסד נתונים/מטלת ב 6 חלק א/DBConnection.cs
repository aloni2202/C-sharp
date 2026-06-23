using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace מטלת_ב_6_חלק_א
{
    internal class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=DBitems;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadItemTable()
        {
            try
            {
                string res = "";
                strCmd = "SELECT * FROM TBItem";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res += $"Item Code : {reader["CODE"].ToString()}\n Name : {reader["NAME"]}\n Description : {reader["DESC"]}\n Price : {reader["PRICE"].ToString()}\n";
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "-1";
            }
            finally
            {
                if (reader != null)
                {
                    con.Close();
                }
            }
        }
        public int AddItemToDB(Item item)
        {
            try
            {
                strCmd = $"INSERT INTO TBIems (NAME , DESC , PRICE)" +
                $"VALUES('{item.Name}' , '{item.Descripion}' , '{item.Price}')";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int DeleteItemFromDB(int code)
        {
            try
            {
                strCmd = $"DELETE FROM TBItem " +
                $"WHERE CODE = {code}";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
