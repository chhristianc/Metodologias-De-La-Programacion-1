using System;

namespace TP6.Composite.TemplateMethod
{
    public class DecoradoConNotaEnLetras : AlumnoDecorator
    {
        public DecoradoConNotaEnLetras(IAlumno alumno) : base(alumno)
        {

        }

        public override string mostrarCalificacion()
        {
            string[] notas = { "CERO", "UNO", "DOS", "TRES", "CUATRO" , "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};

            string resultado = base.mostrarCalificacion();

            int calificacion = getCalificacion();

            resultado += " (" + notas[calificacion] + ")";

            return resultado;
        }
    }
}