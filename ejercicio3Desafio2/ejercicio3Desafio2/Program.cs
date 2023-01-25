using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Aprobado = 4;
            int Promociona = 7;
            Console.Write("Ingrese su primer nota:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.Write("Ingrese su segunda nota:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            if (num1>=Aprobado & num2>=Aprobado)
            {
                int promedio = (num1+ num2) / 2;
                if(promedio < Promociona)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Promociona");
                }

            }
            else
            {
                Console.WriteLine("Recupera");
            }

        }
    }
}
