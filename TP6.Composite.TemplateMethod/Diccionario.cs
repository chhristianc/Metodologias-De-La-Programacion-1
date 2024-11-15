using System;
using System.Collections.Generic;

namespace TP6.Composite.TemplateMethod
{
    public class Diccionario : Coleccionable, Iterable, Ordenable
    {
        private Conjunto elementos;
        OrdenEnAula1 ordenInicio = null, ordenAulaLlena = null;
        OrdenEnAula2 ordenLlegaAlumno = null;

        public Diccionario()
        {
            elementos = new Conjunto();
        }

        public Conjunto getElementos()
        {
            return elementos;
        }

        public void agregar(int clave, Comparable valor)
        {
            bool existe = false;

            foreach (ClaveValor elem in elementos.getElementos())
            {
                if (elem.getClave() == clave)
                {
                    elem.setValor(valor);
                    existe = true;
                }
            }

            if (!existe)
            {
                ClaveValor elemento = new ClaveValor(clave, valor);
                elementos.agregar(elemento);
                if (cuantos() == 1 && ordenInicio != null)
                    ordenInicio.ejecutar();

                if (ordenLlegaAlumno != null)
                    ordenLlegaAlumno.ejecutar(elemento);

                if (cuantos() == 40 && ordenAulaLlena != null)
                    ordenAulaLlena.ejecutar();
            }
        }

        public Comparable valorDe(int clave)
        {
            foreach(ClaveValor elem in elementos.getElementos())
            {
                if(elem.getClave() == clave)
                    return elem.getValor();
            }

            return null;
        }

        public int cuantos()
        {
            return elementos.cuantos();
        }

        public Comparable minimo()
        {
            Comparable min = ((ClaveValor)elementos.getElementos()[0]).getValor();

            for (int i = 1; i < elementos.cuantos(); i++)
            {
                if (((ClaveValor)elementos.verElemento(i)).getValor().sosMenor(min))
                    min = ((ClaveValor)elementos.verElemento(i)).getValor();
            }

            return min;
        }

        public Comparable maximo()
        {
            Comparable max = ((ClaveValor)elementos.getElementos()[0]).getValor();

            for (int i = 1; i < elementos.cuantos(); i++)
            {
                if (((ClaveValor)elementos.verElemento(i)).getValor().sosMayor(max))
                    max = ((ClaveValor)elementos.verElemento(i)).getValor();
            }

            return max;
        }

        public void agregar(Comparable c)
        {
            ClaveValor elemento = new ClaveValor(getClaveMayor()+1, c);
            elementos.agregar(elemento);

            if (cuantos() == 1 && ordenInicio != null)
                ordenInicio.ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.ejecutar(elemento);

            if (cuantos() == 40 && ordenAulaLlena != null)
                ordenAulaLlena.ejecutar();
        }

        public bool contiene(Comparable c)
        {
            foreach (ClaveValor elem in elementos.getElementos())
            {
                if (elem.getValor().sosIgual(c))
                    return true;
            }

            return false;
        }

        public int getClaveMayor()
        {
            int claveMayor = 0;

            foreach(ClaveValor elem in elementos.getElementos())
            {
                if (elem.getClave() > claveMayor)
                    claveMayor = elem.getClave();
            }

            return claveMayor;
        }

        public Iterador crearIterador()
        {
            return new IteradorDeDiccionario(this);
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