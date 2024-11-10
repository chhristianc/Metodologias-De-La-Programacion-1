using System;

namespace TP5.Proxy.Command
{
    public class IteradorDeConjunto : Iterador
    {
        private Conjunto conjunto;
        private int indice;

        public IteradorDeConjunto(Conjunto conjunto)
        {
            this.conjunto = conjunto;
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
            return indice >= conjunto.cuantos();
        }

        public Comparable actual()
        {
            return conjunto.getElementos()[indice];
        }
    }
}