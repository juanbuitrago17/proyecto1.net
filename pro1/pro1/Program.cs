using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Registro de estudiante");
            Estudiante Est = new Estudiante();
            String Nombre, Grado;
            int Edad;
            Console.WriteLine("Ingrese el nombre del estudiante");
            Nombre=(Console.ReadLine());
            Est.Nombre = Nombre;
            Console.WriteLine("Ingrese la edad del estudiante");
            Edad=int.Parse(Console.ReadLine());
            Est.Edad = Edad;
            Console.WriteLine("Ingrese el grado del estudiante");
            Grado= (Console.ReadLine());
            Est.Grado = Grado;
            Console.WriteLine("El estudiante se llama: "+ Est.Nombre + " y su edad es: " + Est.Edad + " años y el grado es: " + Est.Grado);
            Console.ReadLine();
        }
    }
}
 