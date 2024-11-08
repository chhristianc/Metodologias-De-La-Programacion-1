using System;

namespace TP4.Adapter.Decorator
{
    public class EstrategiaPorCalificacion : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() == ((IAlumno)c1).getCalificacion();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() < ((IAlumno)c1).getCalificacion();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() > ((IAlumno)c1).getCalificacion();
        }
    }
}
