using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace מטלת_כיתה
{
    internal class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=KnightsGUI;Integrated Security=True;Trust Server Certificate=True";
        string strCmd ;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            strCmd = "";
        }

        public string ReadKnightsTable()
        {
          

            try
            {
                string res = "";
                strCmd = "SELECT * FROM KnightsTable";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res += $"ID : {reader["ID"]} ,  First Name : {reader["FirstName"]} , Last Name : {reader["LastName"]} , Power : {reader["Power"]}";
                }

                return res;
            }
            catch (Exception ex)
            {
                return "Exception :" + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        public int AddKnightToDB(Knight knight)
        {
            try
            {
                strCmd = $"INSERT INTO KnightsTable(FirstName , LastName , Power) " +
                    $"VALUES('{knight.FirstName}' , '{knight.LastName}' , {knight.Power})";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex.Message}");
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public int DeleteKnightFromDB(int id)
        {
            try
            {
                strCmd = $"DELETE FROM KnightsTable " +
              $"WHERE ID = {id}";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
                return -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public string PrintKnightByPower(string power)
        {
            string res = "";
            try
            {
                strCmd = $"SELECT * FROM KnightsTable " +
                $"WHERE Power = {power}";
                cmd = new SqlCommand(strCmd, con);
                con.Open() ;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res += $"ID : {reader["ID"]} , First Name : {reader["FirstName"]} , Last Name : {reader["LastName"]} , Power : {reader["Power"]}";
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rxception : {ex.Message}");
                return "-1";
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                con.Close();
            }

        }
    }
}
