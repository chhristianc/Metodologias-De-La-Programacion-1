using System;

namespace TP6.Composite.TemplateMethod
{
    public class FabricaDeAlumnosDecorados : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            Alumno alumno = (Alumno)base.crearAleatorio();

            IAlumno decorado = new DecoradoConLegajo(alumno);
            IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
            IAlumno decorado3 = new DecoradoConPromocion(decorado2);
            IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);

            return decorado4;
        }

        public override Comparable crearPorTeclado()
        {
            Alumno alumno = (Alumno)base.crearPorTeclado();

            IAlumno decorado = new DecoradoConLegajo(alumno);
            IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
            IAlumno decorado3 = new DecoradoConPromocion(decorado2);
            IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);

            return decorado4;
        }
    }
}