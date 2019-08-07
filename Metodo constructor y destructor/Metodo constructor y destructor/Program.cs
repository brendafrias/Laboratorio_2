using System;

namespace Metodo_constructor_y_destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ventana calculadora = new ventana();
            //calculadora.Mostrar();
            Console.ReadKey();
        }
    }

    class ventana
    {
        private int ancho, altura;
        private string color;

        public ventana()
        {
            ancho = 15;
            altura = 20;
            color = "rojo";
            Console.WriteLine("funciona");// este metodo constructor se va a llamar siempre
        }

        public void Mostrar()
        {
            Console.WriteLine("la division de la ventana es: " + ancho + "x" + altura + " y su color es: " + color);
        }

        ~ventana()
        {
            System.Diagnostics.Trace.WriteLine("se destruyeron los recursos"); // es necesario usar esta linea de codigo para mostrar un mensaje por consola
        }// usado como destructor para liberar
    }
}
