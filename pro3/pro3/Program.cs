using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Calculador del area y el perimetro de un circulo");
            Circulo Cir = new Circulo();
            double Radio;
            Console.WriteLine("Ingrese el valor del radio del circulo");
            Radio=double.Parse(Console.ReadLine());
            Cir.Radio = Radio;
            Console.WriteLine("El area del circulo es: " + Cir.GetArea);
            Console.WriteLine("El perimetro del circulo es: " + Cir.GetPeri);
            Console.ReadLine();
        }
    }
}
