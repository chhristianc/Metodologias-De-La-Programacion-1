using System;

namespace TP4.Adapter.Decorator
{
    public class IteradorDeCola : Iterador
    {
        private Cola cola;
        private int indice;

        public IteradorDeCola(Cola cola)
        {
            this.cola = cola;
            primero();
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
            return indice >= cola.cuantos();
        }

        public Comparable actual()
        {
            return cola.getElementos()[indice];
        }
    }
}