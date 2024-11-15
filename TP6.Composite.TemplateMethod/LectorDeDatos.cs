using System;

namespace TP6.Composite.TemplateMethod
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
