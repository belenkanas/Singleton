using System;

namespace Library
{
    public class Greeter
    {
        public Greeter() //Así no es posible crear instancias de la clase Greeter.
        {
            // Intentionally left blank
        }

        public void SayHiToTheWorld() //Método de instancia.
        {
            Console.WriteLine("Hello World!");
        }
    }
}
