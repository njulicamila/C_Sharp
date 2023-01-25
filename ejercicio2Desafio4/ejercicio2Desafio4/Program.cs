using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] facturacion = { 100, 200, 150, 240, 360, 170, 180, 430, 350, 220, 440, 460 };
            int[] trimestre = new int[5];
            int total1 = 0, total2 = 0, total3 = 0, total4 = 0;
            for (int n = 0; n < facturacion.Length; n++)
            {
                if (n < 3)
                {
                    total1 = total1 + facturacion[n];
                }
                if (n >2 & n < 6)
                {
                    total2 = total2 + facturacion[n];
                }
                if (n > 7 & n < 9)
                {
                    total3 = total3 + facturacion[n];
                }
                if (n > 10)
                {
                    total4 = total4 + facturacion[n];
                }
            }
            trimestre[1] = total1;
            trimestre[2] = total2;
            trimestre[3] = total3;
            trimestre[4] = total4;
            for (int n = 1; n < trimestre.Length; n++)
            {
                Console.WriteLine("Trimestre: " + n + " Factura: " + trimestre[n]);
            }
            Console.ReadKey();
        }
    }
}
