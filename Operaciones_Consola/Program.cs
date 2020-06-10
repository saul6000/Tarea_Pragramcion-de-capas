using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarea_operaciones.Operaciones K = new Tarea_operaciones.Operaciones();
            double k=0;
            Console.WriteLine("Escriba el numero para identificar si es par o impar ");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine(K.paroinpar(k,""));
            Console.WriteLine("Escriba un numero para saber que mes del año es ");
            k = double.Parse(Console.ReadLine());
            Console.WriteLine(K.mes(k, ""));
            Console.ReadKey();
        }
    }
}
