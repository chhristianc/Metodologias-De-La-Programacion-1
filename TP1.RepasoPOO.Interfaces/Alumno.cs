using System;

namespace TP1.RepasoPOO.Interfaces
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public override bool sosIgual(Comparable c)
        {
            return legajo == ((Alumno)c).getLegajo();
        }

        public override bool sosMenor(Comparable c)
        {
            return legajo < ((Alumno)c).getLegajo();
        }

        public override bool sosMayor(Comparable c)
        {
            return legajo > ((Alumno)c).getLegajo();
        }

        public override string ToString()
        {
            return legajo.ToString();
        }
    }
}