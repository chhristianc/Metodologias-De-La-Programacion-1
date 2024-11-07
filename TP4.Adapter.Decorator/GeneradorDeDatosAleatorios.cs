using System;

namespace TP4.Adapter.Decorator
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random;

        public GeneradorDeDatosAleatorios() 
        {
            random = new Random();
        }

        public int numeroAleatorio(int max)
        {
            return random.Next(0,max);
        }

        public string stringAleatorio(int cant)
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