using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro3
{
    internal class Circulo
    {
        public double Radio { get; set; }

        public double GetArea
        {
            get { return 3.1416 * (Radio * Radio); } 
        }
        public double GetPeri 
        {
            get { return (3.1416 * 3.1416) * Radio; }
        }
    }
}
