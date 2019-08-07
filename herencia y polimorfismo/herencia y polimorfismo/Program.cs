using System;

namespace herencia_y_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1Hijo Herencia = new Class1Hijo(); // construimos un objeto para poder usar los atributos
            Herencia.Saludar(); // Herencia es de la clase hijo y usa los atributos de la clase padre porque los heredo
            Herencia.Despedida();
            Console.ReadKey();
            //Console.WriteLine("Hello World!");

            Class1rectangulo rectangulo = new Class1rectangulo();
            rectangulo.Area(34,56);

            Class1triangulo triangulo = new Class1triangulo();
            triangulo.Area(34,56);

            Console.ReadKey();
        }
    }

    
}
