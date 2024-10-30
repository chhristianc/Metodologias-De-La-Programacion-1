using System;

namespace TP3.FactoryMethod.Observer
{
    public interface Observado
    {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}