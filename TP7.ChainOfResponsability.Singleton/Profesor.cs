﻿using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class Profesor : Persona, Observado
    {
        private int antiguedad;
        private bool hablando;
        private List<Observador> observadores;

        public Profesor(string nombre, int dni, int antiguedad ) : base( nombre, dni )
        {
            this.antiguedad = antiguedad;
            observadores = new List<Observador>();
        }

        public int getAntiguedad()
        {
            return antiguedad;
        } 

        public bool isHablando()
        {
            return hablando;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            hablando = true;
            notificar();
        }

        public void escribirEnElPizarrón()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            hablando = false;
            notificar();
        }

        public void agregarObservador(Observador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(Observador o)
        {
            observadores.Remove(o);
        }

        public void notificar()
        {
            foreach(Observador o in observadores)
            {
                o.actualizar(this);
            }
        }
    }
}