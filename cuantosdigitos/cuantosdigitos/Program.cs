using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ejercicio_Propuesto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, Z, cont = 0;
            string linea;
            Console.Write("DIGITE NÚMERO:"); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            Z = linea.Length;
            I = Z;
            while ((I >= 1))
            {
                I--;
                cont++;
            }
            Console.WriteLine();
            Console.WriteLine("El numero ingresado tiene " + cont + "digitos");
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
