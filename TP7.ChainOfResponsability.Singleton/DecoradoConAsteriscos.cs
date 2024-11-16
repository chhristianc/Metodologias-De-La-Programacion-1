using System;

namespace TP7.ChainOfResponsability.Singleton
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