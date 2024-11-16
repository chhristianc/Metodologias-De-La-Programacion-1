using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class EstrategiaPorPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getPromedio() == ((IAlumno)c2).getPromedio();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getPromedio() < ((IAlumno)c2).getPromedio();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getPromedio() > ((IAlumno)c2).getPromedio();
        }
    }
}