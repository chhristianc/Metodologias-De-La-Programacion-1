using System;
using System.Collections.Generic;

namespace TP2.Strategy.Iterator
{
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public List<Comparable> getElementos()
        {
            return elementos;
        }

        public void encolar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desencolar()
        {
            Comparable c = elementos[0];

            elementos.RemoveAt(0);

            return c;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable min = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMenor(min))
                    min = elementos[i];
            }

            return min;
        }

        public Comparable maximo()
        {
            Comparable max = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMayor(max))
                    max = elementos[i];
            }

            return max;
        }

        public void agregar(Comparable c)
        {
            encolar(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elem in elementos)
            {
                if (elem.sosIgual(c))
                    return true;
            }
            return false;
        }

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }
    }
}
