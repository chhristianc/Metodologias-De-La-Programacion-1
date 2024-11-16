using System;
using System.Collections.Generic;

namespace TP7.ChainOfResponsability.Singleton
{
    public class Jugador : Persona
    {
        private int puntos;
        private List<Carta> cartas;

        public Jugador(string nombre, int dni) : base(nombre, dni)
        {
            puntos = 0;
            cartas = new List<Carta>();
        }

        public int getPuntos()
        {
            return puntos;
        }

        public void tomarCarta(Carta carta)
        {
            cartas.Add(carta);
        }

        public void sumarPunto()
        {
            puntos++;
        }

        public Carta tirarCarta()
        {
            Console.WriteLine("Elegí la carta que querés tirar");
            Console.WriteLine();
            for (int i = 0; i < cartas.Count; i++)
            {
                Console.WriteLine(i + " - " + cartas[i].getValor() + " de " + cartas[i].getpalo());
            }

            int eleccion = int.Parse(Console.ReadLine());

            Carta carta = cartas[eleccion];

            cartas.RemoveAt(eleccion);

            return carta;
        }
    }
}