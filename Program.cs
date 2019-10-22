using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanchaFutbol.Class;

namespace CanchaFutbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();
            Console.WriteLine(factura.Cancha);
            factura.Cancha = "Futbol";
            factura.Horas = 3;
            factura.Descuento = 10;
            factura.Pagado = 40;
            Console.WriteLine(factura.Horas);
            Console.WriteLine(factura.Costo);
            Console.WriteLine(factura.Cancha);
            Console.ReadLine();

           

        }
    }
}
