using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_practica_03_ejercicio01
{
    class Ejercicio04
    {
        private static String Ordenar(String cad)//Recivimos la cadena y le llamamos cad
        {
            StringBuilder cad2 = new StringBuilder(cad);//creamos un objeto de tipo StringBuilder para copiar la cadena, ya que este objeto lo podemos alterar y una cadena no.
            int i, j; // variables para controlar los bucles for               
            char temp;//variable char para tomar un caracter de la cadena 
            for (i = 0; i < cad.Length; i++)
            {
                for (j = 0; j < cad.Length - 1; j++)//colocamos cad.Length-1 ya que cuando llegamos al final de la cadena ya no tenemos con quien mas comparar, entonces ahi finaliza el ciclo 
                {
                    if (cad2[j] > cad2[j + 1])//comparamos el caracter actual con el siguiente, si este es mayor se hace el intercambio
                    {
                        temp = cad2[j];
                        cad2[j] = cad2[j + 1];
                        cad2[j + 1] = temp;
                    }
                }
            }
            return cad2.ToString();
        }
        static void Main(string[] args)
        {
            String cadena;//variable que almacena la cadena

            Console.Write("Ingrese una cadena: ");
            cadena = Console.ReadLine();//asignacion a la variable

            Console.WriteLine($"La cadena ordenada: {Ordenar(cadena)}");//llamamos a la funcion ordenanr y le pasamos como parametro la cadena.

            Console.Read();


        }
    }
}
