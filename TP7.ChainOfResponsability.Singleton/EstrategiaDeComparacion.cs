using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface EstrategiaDeComparacion
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
