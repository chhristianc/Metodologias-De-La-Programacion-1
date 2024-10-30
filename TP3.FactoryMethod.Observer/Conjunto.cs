using System;
using System.Collections.Generic;

namespace TP3.FactoryMethod.Observer
{
    public class Conjunto : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        public List<Comparable> getElementos()
        {
            return elementos;
        }

        public void agregar(Comparable elemento)
        {
            if(!pertenece(elemento))
                elementos.Add(elemento);
        }

        public bool pertenece (Comparable elemento)
        {
            foreach (Comparable elem in elementos)
            {
                if (elem.sosIgual(elemento))
                    return true;
            }
            return false;
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

        public bool contiene(Comparable c)
        {
            foreach (Comparable elem in elementos)
            {
                if (elem.sosIgual(c))
                    return true;
            }
            return false;
        }

        public Comparable verElemento(int posicion)
        {
            return elementos[posicion];
        }

        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }
    }
}