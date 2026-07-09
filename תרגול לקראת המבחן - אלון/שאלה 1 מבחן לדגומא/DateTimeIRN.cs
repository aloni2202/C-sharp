using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_1_מבחן_לדגומא
{
    internal class DateTimeIRN : IndexedRandomNumber
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTimeIRN(int ind) : base(ind)
        {
            Date = DateTime.Now.ToShortDateString();
            Time = DateTime.Now.ToShortDateString();
        }

        public override string ToString()
        {
            return base.ToString() + $" Date : {Date} Time : {Time} ";
        }
    }
}
