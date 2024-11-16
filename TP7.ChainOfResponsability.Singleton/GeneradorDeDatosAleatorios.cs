using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class GeneradorDeDatosAleatorios : Manejador
    {
        private static GeneradorDeDatosAleatorios unicaInstancia = null;

        private Random random;

        private GeneradorDeDatosAleatorios(Manejador manejador) : base(manejador) 
        {
            random = new Random();
        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador manejador)
        {
            if (unicaInstancia == null)
                unicaInstancia = new GeneradorDeDatosAleatorios(manejador);
            return unicaInstancia;
        }

        public override int numeroAleatorio(int max)
        {
            return random.Next(0,max);
        }

        public override string stringAleatorio(int cant)
        {
            string letras = "abcdefghijklmnñopqrstuvwxyz";
            string texto = "";

            for(int i=0;i<cant;i++)
            {
                texto += letras[random.Next(0,27)];
            }

            return texto;
        }
    }
}