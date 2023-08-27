using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Convertidor de grados celcius a grados fahrenheit");
            ConversorTemperatura Tem = new ConversorTemperatura();
            double Celsius;
            Console.WriteLine("Ingrese los grados celsius a convertir");
            Celsius=double.Parse(Console.ReadLine());
            Tem.Celsius = Celsius;
            Console.WriteLine("Los grados celcius " +Tem.Celsius  +" °C convertidos son: " + Tem.Getfahre  + " °F");
            Console.ReadLine();
        }
    }
}
