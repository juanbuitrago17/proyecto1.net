using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro5
{
    internal class claseAr
    {
        public  double Radio { get; set; }
        public double Area
        {
            get { return 3.1416 * (Radio * Radio); }
        }
        public double Peri
        {
            get { return (3.1416 * 3.1416)* Radio; }
        }
    }
}
