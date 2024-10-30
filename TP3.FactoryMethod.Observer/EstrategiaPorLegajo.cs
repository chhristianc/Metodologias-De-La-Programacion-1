using System;

namespace TP3.FactoryMethod.Observer
{
    public class EstrategiaPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() == ((Alumno)c1).getLegajo();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c1).getLegajo();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() > ((Alumno)c1).getLegajo();
        }

    }
}