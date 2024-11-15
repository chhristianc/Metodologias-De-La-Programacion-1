using System;

namespace TP6.Composite.TemplateMethod
{
    public interface EstrategiaDeComparacion
    {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
    }
}
