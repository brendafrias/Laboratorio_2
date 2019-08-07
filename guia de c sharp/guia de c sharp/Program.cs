using System;

namespace guia_de_c_sharp
{
   
    class Ejercicios
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicios de la guia"; //es usado para poner titulo a la consola

           // Console.BackgroundColor = ConsoleColor.Red; usado para el color de fondo de las letras
            Console.ForegroundColor = ConsoleColor.Green; //usado para el color de las letras
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ejercicio 1");

            Console.Write("ingresar 5 numeros por consola guardarlos en una variable escalar. luego calcular el maximo y el minimo y el promedio de la suma de todos los numeros");
            Console.ReadKey();
            Console.Clear();

            int numeros;
            int i;
            int max=0;
            int min=99;
            int acumulador=0;
            float promedio = 0;
            
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                Console.WriteLine("Posicion actual {0}", i);
                numeros = Convert.ToInt32(Console.ReadLine());
                
                if (numeros > max)
                {
                    max = numeros;
                }

                if(numeros < min)
                {
                    min = numeros;
                }
                acumulador = numeros + acumulador;
            }
            promedio = acumulador / 5;
            Console.Clear();
            Console.WriteLine(" El numero maximo es: {0}, El numero minimo es: {1}, la suma de todos los numeros es: {2}, el promedio de los numeros es: {3}", max, min, acumulador, promedio);
            
            if (promedio == 0)
            {
                Console.WriteLine("Los numeros ingresados son todos cero y su promedio es cero");
            }

            ////////////////////////////////////////////////
            int num;
            bool flag;

            Console.WriteLine("Ingrese un numero, se mostraran los numeros primos hasta el numero ingresado: ");
            num = int.Parse(Console.ReadLine());

            for (int j = 1; j <= num; j++)
            {
                flag = true;

                for (int n = 2; n < j; n++)
                {
                    if (j % n == 0)
                    {
                        flag = false;

                    }
                }

                if (flag)
                {
                    Console.WriteLine("{0}", j);
                }

            }

            Console.ReadLine();
            //////////////////////////////////////////////////////////
            Console.Clear();
            int fechaNacDia;
            int fechaNacMes;
            int fechaNacAnio;
            int fechaActualDia;
            int fechaActualMes;
            int fechaActualAnio;

            int resultadoAnio;
            int resultadoMes;
            int resultadoDias;
            Console.WriteLine("ejercicio numero 7");

            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            Console.WriteLine("Dia: ");
            fechaNacDia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mes: ");
            fechaNacMes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anio: ");
            fechaNacAnio = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese la fecha actual: ");

            Console.WriteLine("Dia ");
            fechaActualDia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mes: ");
            fechaActualMes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Anio: ");
            fechaActualAnio = Convert.ToInt32(Console.ReadLine());



            resultadoAnio = fechaActualAnio - fechaNacAnio;
            resultadoAnio = resultadoAnio * 365;

            resultadoMes = fechaActualMes - fechaNacMes;
            resultadoMes = resultadoMes * 30;

            resultadoDias = fechaActualDia - fechaNacDia;
            resultadoDias = resultadoDias * 1;

            resultadoDias = resultadoDias + resultadoMes + resultadoAnio;

            Console.WriteLine("viste aproximadamente {0} dias", resultadoDias);






        }
    }
}
