using System;

namespace TP5.Proxy.Command
{
    public class IteradorDeDiccionario : Iterador
    {
        private Diccionario diccionario;
        private int indice;

        public IteradorDeDiccionario(Diccionario diccionario)
        {
            this.diccionario = diccionario;
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
            return indice >= diccionario.cuantos();
        }

        public Comparable actual()
        {
            return ((ClaveValor)diccionario.getElementos().verElemento(indice));
        }
    }
}