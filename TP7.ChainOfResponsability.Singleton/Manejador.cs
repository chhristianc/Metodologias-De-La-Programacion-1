using ObtencionDeDatos;
using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public abstract class Manejador
    {
        private Manejador sucesor;

        public Manejador(Manejador sucesor)
        {
            this.sucesor = sucesor;
        }


        //LectorDeDatos

        public virtual int numeroPorTeclado()
        {
            if(sucesor != null)
                return sucesor.numeroPorTeclado();
            return 0;
        }

        public virtual string stringPorTeclado()
        {
            if (sucesor != null)
                return sucesor.stringPorTeclado();
            return "";
        }


        //GeneradorDeDatosAleatorios

        public virtual int numeroAleatorio(int max)
        {
            if (sucesor != null)
                return sucesor.numeroAleatorio(max);
            return 0;
        }

        public virtual string stringAleatorio(int cant)
        {
            if (sucesor != null)
                return sucesor.stringAleatorio(cant);
            return "";
        }


        //LectorDeArchivos

        public virtual double numeroDesdeArchivo(double max)
        {
            if (sucesor != null)
                return sucesor.numeroDesdeArchivo(max);
            return 0;
        }

        public virtual string stringDesdeArchivo(int cant)
        {
            if (sucesor != null)
                return sucesor.stringDesdeArchivo(cant);
            return "";
        }
    }
}
