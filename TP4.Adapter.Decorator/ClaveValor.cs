using System;

namespace TP4.Adapter.Decorator
{
    public class ClaveValor : Comparable
    {
        private int clave;
        private Comparable valor;

        public ClaveValor(int clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public int getClave() 
        { 
            return clave; 
        }

        public Comparable getValor()
        {
            return valor;
        }

        public void setValor(Comparable c)
        {
            valor = c;
        }

        public bool sosIgual(Comparable c)
        {
            return valor.sosIgual(((ClaveValor)c).getValor());
        }

        public bool sosMenor(Comparable c)
        {
            return valor.sosMenor(((ClaveValor)c).getValor());
        }

        public bool sosMayor(Comparable c)
        {
            return valor.sosMayor(((ClaveValor)c).getValor());
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}