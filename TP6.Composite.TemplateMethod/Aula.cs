using MetodologíasDeProgramaciónI;
using System;

namespace TP6.Composite.TemplateMethod
{
    public class Aula
    {
        private Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("Comienzo de la clase!!!");

            teacher = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno)
        {
            teacher.goToClass(new AlumnoAdapter(alumno));
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }
}
