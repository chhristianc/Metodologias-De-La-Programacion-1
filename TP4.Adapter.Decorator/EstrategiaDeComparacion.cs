using System;

namespace TP4.Adapter.Decorator
{
    public interface EstrategiaDeComparacion
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
