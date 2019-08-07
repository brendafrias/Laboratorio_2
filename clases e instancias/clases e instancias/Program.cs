using System;

namespace clases_e_instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ventana calculadora = new ventana();

            calculadora.Cerrar();//se muestra porque es publico
            calculadora.Maximizar();// se muestra porque es publico
            //no podemos acceder a minimizar porque es un metodo privado.
        }
    }


    class ventana
    {
        //Atributos: private solo se puede acceder en ese bloque, static puede cambiarse desde cualquier clase,
        //y public se puede acceder de cualquier parte del programa

        //Metodos suelen ser publicos para ser llamados por otras clases.
        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro");
        }

        private void Minimizar()
        {
            Console.WriteLine("Se minimizo la ventana");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se maximzo");
        }
    }
}
