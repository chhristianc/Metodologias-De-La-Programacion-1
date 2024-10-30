using System;

namespace TP3.FactoryMethod.Observer
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}