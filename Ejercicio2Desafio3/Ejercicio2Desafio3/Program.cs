using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1000;
            int mes = 1;

             while (valor < 1200 & mes <13){
                int porcentaje = (valor * 3) / 100;
                valor += porcentaje;
                mes++;

            }
            Console.WriteLine("mes: " + mes + " valor: " + valor);

        }
    }
}
