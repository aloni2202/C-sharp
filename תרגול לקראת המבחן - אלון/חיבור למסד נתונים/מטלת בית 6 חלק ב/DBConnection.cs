using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace מטלת_בית_6_חלק_ב
{
    internal class DBConnection
    {
        string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=DBitems;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            ds = new DataSet();
        }

        public DataTable ItemsTable()
        {
            try
            {
                ds.Clear();
                strCmd = "SELECT * FROM TBItem";
                cmd = new SqlCommand(strCmd, con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "T1");
                dt = ds.Tables["T1"];
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public DataTable FilterByAbovePrice(int price)
        {
            ds = new DataSet();

            cmd = new SqlCommand("P_Item_By_Above_Price", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parPrice = new SqlParameter("@Price", SqlDbType.Float);
            parPrice.Value = price;
            parPrice.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(parPrice);

            SqlParameter parReturn = new SqlParameter();
            parReturn.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(parReturn);

            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Filter");

            return ds.Tables["Filter"];
        }

        public DataTable InsertItem(Item item)
        {
            dt = ds.Tables["T1"];
            if (dt == null)
            {
                MessageBox.Show("NULL Table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            DataRow dr = dt.NewRow();
            dr["NAME"] = item.Name;
            dr["DESC"] = item.Descripion;
            dr["PRICE"] = item.Price;

            dt.Rows.Add(dr);

            UpdateDB(dt);

            return ItemsTable();
        }

        public DataTable DeleteItem(int code)
        {
            dt = ds.Tables["T1"];
            if (dt == null)
            {
                MessageBox.Show("NULL", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted || dt.Rows[i]["CODE"].ToString() == code.ToString())
                {
                    dt.Rows[i].Delete();
                    break;
                }
                else
                {
                    Console.WriteLine("Items not found");
                }
            }
            UpdateDB(dt);
            return ItemsTable();
        }

        public void UpdateDB(DataTable table)
        {
            new SqlCommandBuilder(adapter);
            adapter.Update(table);
        }
    }
}
