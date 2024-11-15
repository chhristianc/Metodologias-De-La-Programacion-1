using System;

namespace TP6.Composite.TemplateMethod
{
    public class FabricaDeAlumnosMuyEstudiososDecorados : FabricaDeAlumnosMuyEstudiosos
    {
        public override Comparable crearAleatorio()
        {
            AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso)base.crearAleatorio();

            IAlumno decorado = new DecoradoConLegajo(alumno);
            IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
            IAlumno decorado3 = new DecoradoConPromocion(decorado2);
            IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);

            return decorado4;
        }

        public override Comparable crearPorTeclado()
        {
            AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso)base.crearAleatorio();

            IAlumno decorado = new DecoradoConLegajo(alumno);
            IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
            IAlumno decorado3 = new DecoradoConPromocion(decorado2);
            IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);

            return decorado4;
        }
    }
}