using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.Write("Ingrese otro numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);


           // Console.Write("Los numeros ingresados: "+num1 );
            //Console.WriteLine(" y "+num2);

            if (num1 > num2)
            {
                int suma = num1+num2;
                int dif = num1 - num2;
                Console.WriteLine("La suma es: " + suma);
                Console.WriteLine("La diferencia es: " + dif);
            }
            else
            {
                int producto = num1 * num2;
                int div = num2/num2;
                Console.WriteLine("El producto es: "+ producto);
                Console.WriteLine("La división es: " + div);
            }
        }
    }
}
