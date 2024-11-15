using System;

namespace TP6.Composite.TemplateMethod
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}