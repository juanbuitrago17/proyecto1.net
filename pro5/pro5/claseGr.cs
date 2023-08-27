using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro5
{
    internal class claseGr
    {
        public double Celcius { get; set; }
        public double Fahre
        {
            get { return (Celcius * 9/5)+32; }
        }
    }
}
