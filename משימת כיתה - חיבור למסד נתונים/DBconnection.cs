using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace משימת_כיתה___חיבור_למסד_נתונים
{
    internal class DBconnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\\SQLEXPRESS;Initial Catalog=KnightsGUI;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBconnection()
        {
            con = new SqlConnection(strCon);
        }
         public string ReadKnightsTable()
        {
            string res = "";
            try
            {
                con.Open();
                strCmd = @"select *
                          from KnightsTable";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
              
            }
            
            
            return res;
        }

        public int AddKnightToDB(Knight knight)
        {
            return 1;
        }

        public int DeleteKnightFromDB(int id)
        {
            return 1;
        }
        public string PrintKnightByPower(int power) 
        {
            return "";
        }
    }
}
