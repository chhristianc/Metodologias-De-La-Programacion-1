using System;
using System.Collections.Generic;

namespace TP1.RepasoPOO.Interfaces
{
    public class Pila : Coleccionable
    {
        List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
        }

        public void apilar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desapilar()
        {
            Comparable c = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);

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
            apilar(c);
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
    }
}