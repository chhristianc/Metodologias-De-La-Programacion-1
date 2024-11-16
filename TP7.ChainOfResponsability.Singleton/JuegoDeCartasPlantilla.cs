using System;
using System.Collections.Generic;

namespace TP7.ChainOfResponsability.Singleton
{
    public abstract class JuegoDeCartasPlantilla
    {
        protected List<Carta> mazo;
        protected Jugador jugador1;
        protected Jugador jugador2;

        public void jugar()
        {
            mezclarMazo();

            while (quedanCartas())
            {
                repartirCartas();
                tomarCartas();
                descartarCartas();
            }

            verificarGanador();
        }

        public abstract void mezclarMazo();
        public abstract void repartirCartas();
        public abstract bool quedanCartas();
        public abstract void tomarCartas();
        public abstract void descartarCartas();
        public abstract void verificarGanador();
    }
}