using System;

namespace TP6.Composite.TemplateMethod
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}
