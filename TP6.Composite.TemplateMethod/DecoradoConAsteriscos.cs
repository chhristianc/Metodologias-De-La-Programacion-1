using System;

namespace TP6.Composite.TemplateMethod
{
    public class DecoradoConAsteriscos : AlumnoDecorator
    {
        public DecoradoConAsteriscos(IAlumno alumno) : base(alumno)
        {

        }

        public override string mostrarCalificacion()
        {
            string resultado = "***********************************************\n" +
                               "*    " + base.mostrarCalificacion() + "    *\n" +
                               "***********************************************";

            return resultado;
        }
    }
}