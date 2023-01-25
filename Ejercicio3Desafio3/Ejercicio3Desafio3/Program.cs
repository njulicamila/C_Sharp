using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            string contraseña = "1234";
            string contraUsuario="";
            while(cant <3 & contraseña != contraUsuario)
{
                Console.WriteLine("Contraseña: ");
                contraUsuario = Convert.ToString(Console.ReadLine());
                Console.WriteLine(Environment.NewLine);

                if (contraseña==contraUsuario)
                {
                    Console.WriteLine("Bienvenido!");

                }
                else
                {
                    if (cant==0)
                    {
                        Console.WriteLine("Tienes dos chanches más!");
                    }
                    if (cant==1)
                    {
                        Console.WriteLine("ATENCION!! Ultima oportunidad");

                    }
                    if(cant==2)
                    {
                        Console.WriteLine("Tres veces fallida");

                    }
                }
             cant++;

            }
        }
    }
}
