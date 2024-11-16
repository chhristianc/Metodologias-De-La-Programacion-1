using System;
using MetodologíasDeProgramaciónI;

namespace TP7.ChainOfResponsability.Singleton
{
    public class AlumnoAdapter : Student
    {
        private IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public IAlumno getAlumno()
        {
            return alumno;
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }
        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }
        public bool equals(Student student)
        {
            return alumno.sosIgual(((AlumnoAdapter)student).getAlumno());
        }
        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AlumnoAdapter)student).getAlumno());
        }
        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AlumnoAdapter)student).getAlumno());
        }
    }
}
