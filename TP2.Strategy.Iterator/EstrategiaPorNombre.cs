using System;

namespace TP2.Strategy.Iterator
{
    public class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getNombre() == a2.getNombre();
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().Length < a2.getNombre().Length;
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getNombre().Length > a2.getNombre().Length;
        }
    }
}