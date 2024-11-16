using System;
using System.Collections.Generic;

namespace TP7.ChainOfResponsability.Singleton
{
    public class JuegoDeCartasConcreto : JuegoDeCartasPlantilla
    {
        public JuegoDeCartasConcreto()
        {
            mazo = new List<Carta>();
            cargarMazo();
            cargarJugadores();
        }


        public override void mezclarMazo()
        {
            Random random = new Random();

            for (int i = 0; i < mazo.Count; i++)
            {
                int nuevoLugar = random.Next(0, mazo.Count);
                Carta carta = mazo[i];
                mazo[i] = mazo[nuevoLugar];
                mazo[nuevoLugar] = carta;
            }
        }

        public override void repartirCartas()
        {
            for (int i = 0; i < 6; i++)
            {
                jugador1.tomarCarta(mazo[mazo.Count - 1]);
                mazo.Remove(mazo[mazo.Count - 1]);
                jugador2.tomarCarta(mazo[mazo.Count - 1]);
                mazo.Remove(mazo[mazo.Count - 1]);
            }
        }

        public override bool quedanCartas()
        {
            if (mazo.Count > 0)
                return true;

            else return false;
        }

        public override void tomarCartas()
        {
        }

        public override void descartarCartas()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Comienza una nueva ronda");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Suma puntos quien tira la carta con mayor valor");
            Console.WriteLine("***********************************************");
            Console.WriteLine();

            for (int i = 0; i<6; i++)
            {
                jugarMano();
            }

            Console.WriteLine("Finalízó esta ronda");
            Console.WriteLine("***********************");
            Console.WriteLine("Resultados parciales: ");
            Console.WriteLine("{0}: {1} puntos", jugador1.getNombre(), jugador1.getPuntos());
            Console.WriteLine("{0}: {1} puntos", jugador2.getNombre(), jugador2.getPuntos());
            
            Console.ReadKey(true);
            Console.Clear();
        }

        public override void verificarGanador()
        {
            Console.WriteLine("Resultado Final");
            Console.WriteLine("{0}: {1} puntos", jugador1.getNombre(), jugador1.getPuntos());
            Console.WriteLine("{0}: {1} puntos", jugador2.getNombre(), jugador2.getPuntos());
            Console.WriteLine("**************************");

            if (jugador1.getPuntos() > jugador2.getPuntos())
                Console.WriteLine(jugador1.getNombre() + " ganó el juego");

            else if (jugador1.getPuntos() < jugador2.getPuntos())
                Console.WriteLine(jugador2.getNombre() + " ganó el juego");

            else
                Console.WriteLine("Empate");

        }

        public void cargarMazo()
        {
            string[] palos = { "Basto", "Copa", "Espada", "Oro" };

            foreach (string elem in palos)
            {
                for (int i = 1; i < 13; i++)
                {
                    mazo.Add(new Carta(elem, i));
                }
            }
        }

        public void jugarMano()
        {
            Console.WriteLine("Turno de " + jugador1.getNombre());
            Console.ReadKey(true);
            Carta carta1 = jugador1.tirarCarta();
            Console.Clear();
            Console.WriteLine("Turno de " + jugador2.getNombre());
            Console.ReadKey(true);
            Carta carta2 = jugador2.tirarCarta();
            Console.Clear();

            Console.WriteLine(jugador1.getNombre() + " eligió el " + carta1.getValorYPalo());
            Console.WriteLine(jugador2.getNombre() + " eligió el " + carta2.getValorYPalo());
            Console.WriteLine();

            if (carta1.getValor() > carta2.getValor())
            {
                Console.WriteLine(jugador1.getNombre() + " suma un punto");
                jugador1.sumarPunto();
            }

            else if (carta1.getValor() < carta2.getValor())
            {
                Console.WriteLine(jugador2.getNombre() + " suma un punto");
                jugador2.sumarPunto();
            }

            else
                Console.WriteLine("Ningún jugador suma puntos");

            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Resultados parciales: ");
            Console.WriteLine("{0}: {1} puntos", jugador1.getNombre(), jugador1.getPuntos());
            Console.WriteLine("{0}: {1} puntos", jugador2.getNombre(), jugador2.getPuntos());
            Console.ReadKey();
            Console.Clear();
        }

        public void cargarJugadores()
        {
            Console.WriteLine("Ingrese el nombre del primer jugador");
            jugador1 = new Jugador(Console.ReadLine(), 1);
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            jugador2 = new Jugador(Console.ReadLine(), 2);
            Console.Clear();
        }
    }
}