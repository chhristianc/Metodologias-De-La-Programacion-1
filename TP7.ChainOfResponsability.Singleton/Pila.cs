using System;
using System.Collections.Generic;

namespace TP7.ChainOfResponsability.Singleton
{
    public class Pila : Coleccionable, Iterable
    {
        List<Comparable> elementos;
        OrdenEnAula1 ordenInicio = null, ordenAulaLlena = null;
        OrdenEnAula2 ordenLlegaAlumno = null;

        public Pila()
        {
            elementos = new List<Comparable>();
        }

        public List<Comparable> getElementos()
        {
            return elementos;
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

            if (cuantos() == 1 && ordenInicio != null)
                ordenInicio.ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.ejecutar(c);

            if(cuantos() == 40 && ordenAulaLlena != null)
                ordenAulaLlena.ejecutar();
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
            return new IteradorDePila(this);
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }
    }
}