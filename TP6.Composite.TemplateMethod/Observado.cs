using System;

namespace TP6.Composite.TemplateMethod
{
    public interface Observado
    {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}