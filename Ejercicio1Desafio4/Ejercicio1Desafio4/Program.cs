using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorOrigen = new int[] { 1002, 104, 309, 500 };
            int[] vectorDestino = new int[4];
            int cont = 3;

            vectorDestino[0] = vectorOrigen[3];
            vectorDestino[1] = vectorOrigen[2];
            vectorDestino[2] = vectorOrigen[1];
            vectorDestino[3] = vectorOrigen[0];

            Console.WriteLine("Vector Origen");
            for (int i=0; vectorOrigen.Length>i;i++)
            {
                Console.WriteLine(i+" "+ vectorOrigen[i]);

            }
            Console.WriteLine("Vector Destino");
            for (int i = 0; vectorDestino.Length > i; i++)
            {
                Console.WriteLine(i + " " + vectorDestino[i]);

            }

        }
    }
}
