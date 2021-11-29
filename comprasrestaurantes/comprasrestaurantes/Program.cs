using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CANB, CANH, CANP;
            double APAGAR;
            string linea;
            const double PRECIOB = 1.000;
            const double PRECIOH = 2.000;
            const double PRECIOP = 1.200;
            Console.Write("CANTIDAD DE HAMBURGUESAS :"); linea = Console.ReadLine();
            CANH = byte.Parse(linea);
            Console.Write("CANTIDAD DE PAPAS :"); linea = Console.ReadLine();
            CANP = byte.Parse(linea);
            Console.Write("CANTIDAD DE BEBIDAS :"); linea = Console.ReadLine();
            CANB = byte.Parse(linea);
            Console.WriteLine();
            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB);
            Console.WriteLine("VALOR A PAGAR: " + APAGAR);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}