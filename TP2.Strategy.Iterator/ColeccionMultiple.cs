using System;

namespace TP2.Strategy.Iterator
{
    public class ColeccionMultiple : Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }
        public Comparable minimo()
        {
            Comparable min = pila.minimo();

            if (cola.minimo().sosMenor(min))
                min = cola.minimo();

            return min;
        }

        public Comparable maximo()
        {
            Comparable max = pila.maximo();

            if (cola.maximo().sosMayor(max))
                max = cola.maximo();

            return max;
        }

        public void agregar(Comparable c) { }

        public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}
