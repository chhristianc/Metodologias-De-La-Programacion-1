using System;

namespace TP3.FactoryMethod.Observer
{
    public class Numero : Comparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable c)
        {
            return getValor() == ((Numero)c).getValor();
        }

        public bool sosMenor(Comparable c)
        {
            return getValor() < ((Numero)c).getValor();
        }

        public bool sosMayor(Comparable c)
        {
            return getValor() > ((Numero)c).getValor();
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}