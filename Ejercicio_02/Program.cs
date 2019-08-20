using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int numeros=0;
            int promedio=0;
            int minimo=9999;
            int maximo=0;


            int edad = 21;
            string nombre = "brenda";
            Console.Title = "Ejercicio 01";
            Console.WriteLine("Hello World");

            Console.WriteLine("{0} {1} ", edad, nombre);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numeros = Convert.ToInt16(Console.ReadLine());
               
                if (numeros > maximo)
                {
                    maximo = numeros;
                }
                if(numeros< minimo)
                {
                    minimo = numeros;
                }
                promedio = promedio + numeros;

             }
            promedio = promedio / 5;
            Console.WriteLine("El maximo es: {0} , el minimo es: {1}, el promedio es: {2}", maximo, minimo, promedio);
           
            Console.ReadKey();
            

            int cuadrado;
        int cubo;
        Console.WriteLine("Ingrese un numero para calcular su cuadrado");
            cuadrado = Convert.ToInt16(Console.ReadLine());
            if(cuadrado > 0)
            {

                cuadrado = cuadrado* cuadrado;
        Console.WriteLine("el numero al cuadrado es: {0}",cuadrado);
            }
            else
                {
                Console.WriteLine("Ingreso un numero negativo");
                }


Console.ReadKey();

            Console.WriteLine("Ahora ingrese un numero para calcular su cubo");
            cubo = Convert.ToInt16(Console.ReadLine());

            if(cubo > 0)
            {
                cubo = cubo* cubo * cubo;
Console.WriteLine("el numero al cubo es: {0}", cubo);
            }
            else
            {
                Console.WriteLine("Ingreso un numero negativo");
            }
            Console.ReadKey();
        }

        






            //////////////////////////////////////////////

        }
    }
