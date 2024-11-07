using System;
using MetodologíasDeProgramaciónI;

namespace TP4.Adapter.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlumno alumno;
            Teacher teacher = new Teacher();

            for(int i=0; i<10; i++)
            {
                alumno = (IAlumno)FabricaDeComparables.creaAleatorio(2);
                IAlumno decorado = new DecoradoConLegajo(alumno);
                IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
                IAlumno decorado3 = new DecoradoConPromocion(decorado2);
                IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);
                AlumnoAdapter adaptado = new AlumnoAdapter(decorado4);
                teacher.goToClass(adaptado);
            }

            for (int i = 0; i < 10; i++)
            {
                alumno = (IAlumno)FabricaDeComparables.creaAleatorio(4);
                IAlumno decorado = new DecoradoConLegajo(alumno);
                IAlumno decorado2 = new DecoradoConNotaEnLetras(decorado);
                IAlumno decorado3 = new DecoradoConPromocion(decorado2);
                IAlumno decorado4 = new DecoradoConAsteriscos(decorado3);
                AlumnoAdapter adaptado = new AlumnoAdapter(decorado4);
                teacher.goToClass(adaptado);
            }

            teacher.teachingAClass();
        }
    }
}