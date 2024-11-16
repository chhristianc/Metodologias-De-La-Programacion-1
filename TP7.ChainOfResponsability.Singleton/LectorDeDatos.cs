using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class LectorDeDatos : Manejador
    {
        private static LectorDeDatos unicaInstancia = null;

        private LectorDeDatos(Manejador manejador) : base(manejador)
        {
        }

        public static LectorDeDatos getInstance(Manejador manejador)
        {
            if (unicaInstancia == null)
                unicaInstancia = new LectorDeDatos(manejador);
            return unicaInstancia;
        }

        public override int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un número");

            return int.Parse(Console.ReadLine());
        }

        public override string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un texto");

            return Console.ReadLine();
        }
    }
}
