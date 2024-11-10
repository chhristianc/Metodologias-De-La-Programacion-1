using System;

namespace TP5.Proxy.Command
{
    public interface Observador
    {
        void actualizar(Observado o);
    }
}