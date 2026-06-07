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
        

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
            
        }

        public DataTable RefreshTabel()
        {
            adtr = new SqlDataAdapter("SELECT * FROM TBitem", con);
            adtr.Fill(ds, "TBi");
            dt = ds.Tables["TBi"];
            return dt;
        }

        public DataTable ItemsTable()
        {
           
            return dt;
        }

        public DataTable FilterByAbovePrice(int price)
        {
            return dt;
        }

        public DataTable InsertItem(Item item)
        {
            DataRow dr = dt.NewRow(); //למה לא רושם את הששם של הטבלה שאני יצרתי 
            dr["Name"] = item.Name;
            dr["Description"] = item.Description;
            dr["Price"] = item.Price;
            dt.Rows.Add(dr); //למה לא רושם את הששם של הטבלה שאני יצרתי 
            RefreshTabel();

            return dt;
        }

        public DataTable DeleteItem(int code)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted && dt.Rows[i]["Code"] == code.ToString())
                {
                    dt.Rows[i].Delete();
                }
            }
       
            return dt;
        }

        public void UpdateDB(DataTable table)
        {
            //עדכון לתוך למסד הנתונים של הSQL
            new SqlCommandBuilder(adtr);
            adtr.Update(dt);
          
        }

  
    }
}
