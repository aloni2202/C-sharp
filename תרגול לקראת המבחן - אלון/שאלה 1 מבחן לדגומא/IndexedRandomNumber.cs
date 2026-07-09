using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_1_מבחן_לדגומא
{
    internal class IndexedRandomNumber : RandomNumber
    {
        public int Index { get; set; }       
        public IndexedRandomNumber(int ind)
        {
            Index = ind;
        }
        public override string ToString()
        {
            return base.ToString() + $" index number : {Index.ToString()} , ";
        }
}
}
