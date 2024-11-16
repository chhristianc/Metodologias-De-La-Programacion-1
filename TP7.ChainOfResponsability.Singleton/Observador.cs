using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface Observador
    {
        void actualizar(Observado o);
    }
}