using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro2
{
    internal class ConversorTemperatura
    {
        public double Celsius { get; set; }

        public double Getfahre
        {
            get { return (Celsius * 9 /5)+32; }
        }
    }
}
