using System;
using System.Collections.Generic;
using System.Text;

namespace herencia_y_polimorfismo
{
    class Class1triangulo : Class1rectangulo
    {
        public void Area( int Base , int Altura)
        {
            Console.WriteLine("El area del triangulo es: " + ((Base * Altura) / 2));
        }
    }
}
