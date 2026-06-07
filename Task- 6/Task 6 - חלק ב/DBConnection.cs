using Microsoft.Data.SqlClient;
using System.Data;

namespace Task_6___חלק_ב
{
    internal class DBConnection
    {
        string strCon = @"Data Source=DESKTOP-CLD11U2\SQLEXPRESS;Initial Catalog=Task 6;Integrated Security=True;Trust Server Certificate=True";
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
            dt = ds.Tables["TBi"];
        }

        public DataTable RefreshTableFromSQL()
        {
            adtr = new SqlDataAdapter("SELECT * FROM TBitems", con);
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
            dt = RefreshTableFromSQL();
            DataRow dr = dt.NewRow(); //למה לא רושם את השם של הטבלה שאני יצרתי 
            dr["Name"] = item.Name;
            dr["Description"] = item.Description;
            dr["Price"] = item.Price;
            dt.Rows.Add(dr); //למה לא רושם את הששם של הטבלה שאני יצרתי 
                             // להציג את הנתונים שהוכנסו
            return dt;
        }

        public DataTable DeleteItem(int code)
        {
            dt = RefreshTableFromSQL();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted && dt.Rows[i]["Code"].ToString() == code.ToString())
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
