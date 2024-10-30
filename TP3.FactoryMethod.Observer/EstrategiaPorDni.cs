using System;

namespace TP3.FactoryMethod.Observer
{
    public class EstrategiaPorDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDni() == ((Alumno)c2).getDni();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDni() < ((Alumno)c2).getDni();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDni() > ((Alumno)c2).getDni();
        }
    }
}
