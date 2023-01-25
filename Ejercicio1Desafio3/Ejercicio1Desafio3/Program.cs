using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1000;

            for (int i=1; i<13;i++)
            {
                int porcentaje = (valor*2)/100;
                valor += porcentaje;
                Console.WriteLine("mes: "+i +" valor: "+valor);

            }
        }
    }
}
