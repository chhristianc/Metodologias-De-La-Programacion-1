using System;

namespace TP5.Proxy.Command
{
    public class IteradorDePila : Iterador
    {
        private Pila pila;
        private int indice;

        public IteradorDePila(Pila pila)
        {
            this.pila = pila;
            indice = 0;
        }

        public void primero()
        {
            indice = 0;
        }

        public void siguiente()
        {
            indice++;
        }

        public bool fin()
        {
            return indice >= pila.cuantos();
        }

        public Comparable actual()
        {
            return pila.getElementos()[indice];
        }


    }
}