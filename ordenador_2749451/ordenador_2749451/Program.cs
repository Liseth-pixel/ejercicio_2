using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador_2749451
{
    public class Program
    {
        static void Main(string[] args)
        {
            ordenadorr Ordenador1 = new ordenadorr("HP", "Intel(R) Core(TM) i7-3520M CPU 2.90GHz 2.90 GHz", "12.0GB DDR3", "KINGSTON SA400S37480G ATA Device");
            Console.WriteLine("Descripción del ordenador:");
            Console.WriteLine("Marca: " + Ordenador1.Marca);
            Console.WriteLine("Procesador: " + Ordenador1.Procesador);
            Console.WriteLine("Memoria: " + Ordenador1.Memoria);
            Console.WriteLine("Disco Duro: " + Ordenador1.DiscoDuro);
            Ordenador1.MayorCapacidad(100);
            Ordenador1.MenorCapacidad(100);
        }
    }
}
