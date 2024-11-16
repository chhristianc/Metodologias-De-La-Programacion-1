using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}
