using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class Carta
    {
        private string palo;
        private int valor;

        public Carta(string palo, int valor)
        {
            this.palo = palo;
            this.valor = valor;
        }

        public string getpalo()
        {
            return palo;
        }

        public int getValor()
        {
            return valor;
        }

        public string getValorYPalo()
        {
            return valor + " de " + palo;
        }
    }
}