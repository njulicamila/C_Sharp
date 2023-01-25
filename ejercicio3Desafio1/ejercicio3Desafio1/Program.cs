using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float remera = 59.90f;
            float pantalon = 99.90f;
            float campera = 149.90f;
            int IVA = 21;
            Console.WriteLine("Remera sin IVA: $" + remera);
            remera= remera + ((remera*IVA)/100);
            Console.WriteLine("Remera con IVA: $" + remera);

            Console.WriteLine("Pantalon sin IVA: $" + pantalon);
            pantalon = pantalon + ((pantalon*IVA)/100);
            Console.WriteLine("Pantalon con IVA: $" + pantalon);

            Console.WriteLine("Campera sin IVA: $" + campera);
            campera = campera+ ((campera*IVA)/100);
            Console.WriteLine("Campera con IVA: $" + campera);
        }
    }
}
