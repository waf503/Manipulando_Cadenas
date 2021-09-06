using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_practica_03_ejercicio01
{
    class Ejercicio2
    {
        static void Main5(string[] args)
        {
            StringBuilder cad = new StringBuilder();

            Console.Write("Digite una  palabra: ");
            cad.AppendLine(Console.ReadLine());
            Console.Write("Digite otra palabra: ");
            cad.AppendLine(Console.ReadLine());

            foreach(char letra in cad.ToString())
            {
                Console.WriteLine($"{letra}");
            }
            //Console.WriteLine($"La cadena: \n{cad}");
            Console.Read();
        }
    }
}
