using System;

namespace TP4.Adapter.Decorator
{
    public interface Observador
    {
        void actualizar(Observado o);
    }
}