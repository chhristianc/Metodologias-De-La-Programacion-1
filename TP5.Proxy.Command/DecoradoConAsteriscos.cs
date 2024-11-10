using System;

namespace TP5.Proxy.Command
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