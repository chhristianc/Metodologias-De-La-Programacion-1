using System;

namespace TP2.Strategy.Iterator
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;
        private EstrategiaDeComparacion estrategia;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new EstrategiaPorDni();
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, (Alumno)c);
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, (Alumno)c);
        }

        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, (Alumno)c); ;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " Dni: " + dni + " Legajo: " + legajo + " Promedio: " + promedio;
        }
    }
}