using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro4
{
    internal class Triangulo
    {
       public Triangulo() { }

       public double Base { set; get; }
       
       public double Altura { set; get; }

       public double Area
        {
            get { return (Base * Altura) / 2; }
        }
    }
}
