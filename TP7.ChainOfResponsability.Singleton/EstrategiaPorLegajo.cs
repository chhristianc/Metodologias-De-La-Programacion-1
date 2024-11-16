using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class EstrategiaPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() == ((IAlumno)c1).getLegajo();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() < ((IAlumno)c1).getLegajo();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() > ((IAlumno)c1).getLegajo();
        }

    }
}