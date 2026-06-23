using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_כיתה
{
    internal class RoundTable
    {
        Knight[] Knights;
        DBConnection DB;

        public RoundTable()
        {
            Knights = new Knight[0];
            DB = new DBConnection();
        }

        public void AddKnigt(Knight knight)
        {
            Knight[] temp = (Knight[])Knights.Clone();
            Knights = new Knight[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                Knights[i] = temp[i];
            }
            Knights[Knights.Length - 1] = knight;
            Console.WriteLine($"{DB.AddKnightToDB(knight)} New knight Added !");
        }

        public void DeleteKnightFromDB(int id)
        {
            Console.WriteLine($"{DB.DeleteKnightFromDB(id)} Knight Deleted !"); ;
        }

        public string PrintKnightByPower(string power)
        {
            return DB.PrintKnightByPower(power);
        }

        public override string ToString()
        {
            return DB.ReadKnightsTable();
        }

    }
}