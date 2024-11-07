using System;

namespace TP4.Adapter.Decorator
{
    public class DecoradoConPromocion : AlumnoDecorator
    {
        public DecoradoConPromocion(IAlumno alumno) : base(alumno)
        {

        }

        public override string mostrarCalificacion()
        {
            int calificacion = getCalificacion();
            string estado;

            if (calificacion < 4)
                estado = "DESAPROBADO";

            else if (4 <= calificacion && calificacion < 7)
                estado = "APROBADO";

            else
                estado = "PROMOCIÓN";

            string resultado = base.mostrarCalificacion();

            resultado += " (" + estado + ")";

            return resultado;
        }
    }
}