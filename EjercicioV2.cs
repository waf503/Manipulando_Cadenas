using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_practica_03_ejercicio01
{
    
    class EjercicioV2
    {
        private static int CantidadVocales2(string cadena)
        {
            int v = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena.Substring(i, 1) == "a" || cadena.Substring(i, 1) == "e" || cadena.Substring(i, 1) == "i" || cadena.Substring(i, 1) == "o" || cadena.Substring(i, 1) == "u")
                    v += 1;
            }

            return v;
        }
        static void Main1(string[] args)
        {
            string cad;
            Console.WriteLine("Digite una palabra: ");
            cad = Console.ReadLine();
            Console.Write("La cantidad de vocales son: " + CantidadVocales2(cad));
            Console.Read();
        }
    }
}
