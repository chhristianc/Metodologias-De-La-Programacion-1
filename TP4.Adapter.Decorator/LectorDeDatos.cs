using System;

namespace TP4.Adapter.Decorator
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un número");

            return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un texto");

            return Console.ReadLine();
        }
    }
}
