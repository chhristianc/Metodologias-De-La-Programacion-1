using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}