using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorModulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] cursos = { "Desarrollo Web con HTML", "Introducción a POO", "C# para no programadores", "Introducción a Bases de Datos y SQL", "Introducción a Git" };
            string[] cursosIngresados = new string[cursos.Length];
            Console.WriteLine("Nombre: ");
            string nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Apellido: ");
            string apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Edad:");
            int edad = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Correo:");
            string correo = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>Datos del Alumno<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad:" + edad);
            Console.WriteLine("Correo:" + correo);
            Console.WriteLine("Si los datos son correctos presiona tecla S, en el caso que no presione tacla N");
            char letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.Clear();

            
                if (letra == 's' | letra == 'S')
                {
                    Console.WriteLine(">>>>>Selecciona el código de la carrera elegida<<<<");
                    Console.WriteLine("1. Programacion PHP");
                    Console.WriteLine("2. Programacion JAVA");
                    Console.WriteLine("3. Programacion .NET");
                    int codigocarrera = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Environment.NewLine);

                    Console.Clear();

                while (true)
                {
                    switch (codigocarrera)
                    {
                        case 1:
                            Console.WriteLine(">>>>>>>>>>>>>>Comprobante de inscripción<<<<<<<<<<<<<<");
                            Console.WriteLine("Alumno: " + nombre + apellido);
                            Console.WriteLine("Correo: " + correo);
                            Console.WriteLine("Carrera: Programacion NET");
                            break;

                        case 2:
                            Console.WriteLine(">>>>>>>>>>>>>>Comprobante de inscripción<<<<<<<<<<<<<<");
                            Console.WriteLine("Alumno: " + nombre + apellido);
                            Console.WriteLine("Correo: " + correo);
                            Console.WriteLine("Carrera: Programacion Java");
                            break;

                        case 3:
                            Console.WriteLine(">>>>>>>>>>>>>>Comprobante de inscripción<<<<<<<<<<<<<<");
                            Console.WriteLine("Alumno: " + nombre + apellido);
                            Console.WriteLine("Correo: " + correo);
                            Console.WriteLine("Carrera: Programacion PHP");
                            break;

                        default:
                            Console.WriteLine("Carrera inexistente");
                            Console.WriteLine("Datos incorrectos. Ejecutar  aplicación nuevamente");
                            continue;

                    }
                    break;
                }

                Console.WriteLine("Seleccione uno o varios cursos ");


                while (true)
                {
                    for (int i = 0; i < cursos.Length; i++)
                    {
                        Console.WriteLine("{i + 1}: {cursos[i]}");
                    }

                    int codigoCurso = Convert.ToInt32(Console.ReadLine());

                    if (codigoCurso < 1 || codigoCurso > cursos.Length - 1)
                    {
                        Console.WriteLine("Error: El código del curso elegido no corresponde a un curso existente. Seleccione nuevamente");
                        continue;
                    }

                    cursosIngresados[codigoCurso - 1] = cursos[codigoCurso - 1];

                    Console.WriteLine("¿Desea seguir ingresando  cursos? Presione 'S' para seguir o 'N' para finalizar");

                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta == "s")
                    {
                        continue;
                    }

                    Console.Clear();
                    break;
                }


                Console.WriteLine("Cursos elegidos: ");
                for (int i = 0; i < cursosIngresados.Length; i++)
                {
                    if (!string.IsNullOrEmpty(cursosIngresados[i]))
                    {
                        Console.WriteLine($"{i + 1}: {cursosIngresados[i]}");
                    }

                }

                

            }

        }
    }
}



    







        
    
