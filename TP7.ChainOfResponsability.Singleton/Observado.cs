using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface Observado
    {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}