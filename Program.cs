using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_practica_03_ejercicio01
{
    class Program
    {


        private static int CantidadVocales(string cadena)
        {
            int v=0;

            for(int i = cadena.Length-1; i>=0; i--)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                    v += 1;
            }
            return v;
        }

        private static int CantidadVocales2(string cadena)
        {
            int v = 0;
            foreach(char letra in cadena)
            {
                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        v++;
                        break;
                    default:
                        break;
                }
            }

            return v;
        }
        static void Main1(string[] args)
        {
            string cad;
            Console.WriteLine("Digite una palabra: ");
            cad = Console.ReadLine();
            Console.WriteLine("La cantidad de vocales son: " + CantidadVocales(cad));
            Console.WriteLine("La cantidad de vocales utilizando foreach son: " + CantidadVocales2(cad));

            Console.Read();
        }
    }
}
