using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task_6
{
     interface IDrive
    {
        public int Kilometer { get; set; }

        void Drive(int kilometer);
    }
}
