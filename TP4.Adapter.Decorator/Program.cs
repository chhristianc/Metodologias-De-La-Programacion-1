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
                alumno = (IAlumno)FabricaDeComparables.creaAleatorio(5);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            for (int i = 0; i < 10; i++)
            {
                alumno = (IAlumno)FabricaDeComparables.creaAleatorio(6);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            teacher.teachingAClass();
        }
    }
}