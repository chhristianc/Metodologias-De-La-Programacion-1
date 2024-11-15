using System;

namespace TP6.Composite.TemplateMethod
{
    public abstract class AlumnoDecorator : IAlumno
    {
        protected IAlumno adicional;

        public AlumnoDecorator(IAlumno a)
        {
            adicional = a;
        }

        public int responderPregunta(int pregunta)
        {
            return adicional.responderPregunta(pregunta);
        }

        public int getCalificacion()
        {
            return adicional.getCalificacion();
        }

        public void setCalificacion(int calificación)
        {
            adicional.setCalificacion(calificación);
        }

        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }

        public string getNombre()
        {
            return adicional.getNombre();
        }

        public int getLegajo()
        {
            return adicional.getLegajo();
        }

        public int getDni()
        {
            return adicional.getDni();
        }

        public double getPromedio()
        {
            return adicional.getPromedio();
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            adicional.setEstrategia(e);
        }

        public  bool sosIgual(Comparable c)
        {
            return adicional.sosIgual(c);
        }

        public bool sosMenor(Comparable c)
        {
            return adicional.sosMenor(c);
        }

        public bool sosMayor(Comparable c)
        {
            return adicional.sosMayor(c);
        }
    }
}
