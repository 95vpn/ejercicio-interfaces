using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sanción de velocidad: $300", "02-05-19" );

            av2.MostrarAviso();

            Console.WriteLine(av2.GetFecha());
        }
    }
}
