using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("A32", "Samsung");
            Console.WriteLine("Ingrese su número de télefono:");
            t1.NumeroTelefonico = Console.ReadLine();

            Console.WriteLine("Ingrese su código de operador:");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine(t1.Llamar());
            Console.WriteLine(t1.Llamar("Nico"));

            Console.ReadKey();
        }
    }
}
