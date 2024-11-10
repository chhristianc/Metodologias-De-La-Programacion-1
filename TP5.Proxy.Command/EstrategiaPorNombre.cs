using System;

namespace TP5.Proxy.Command
{
    public class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Persona)c1).getNombre() == ((Persona)c1).getNombre();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Persona)c1).getNombre().Length < ((Persona)c2).getNombre().Length;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Persona)c1).getNombre().Length > ((Persona)c2).getNombre().Length;
        }
    }
}