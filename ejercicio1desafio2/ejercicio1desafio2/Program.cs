using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Aprobado = 4;
            int Promociona = 7;

            Console.WriteLine("Ingrese su nota:");
            int notaIngresada= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            if(notaIngresada<Aprobado)
            {
                Console.WriteLine("Debe RECUPERAR");
            }
            else {
                if ( notaIngresada < Promociona)
                    {
                     Console.WriteLine("APROBADO");
                    }
                else
                    {
                     Console.WriteLine("PROMOCIONA");
                    }
            }
        }
    }
}
