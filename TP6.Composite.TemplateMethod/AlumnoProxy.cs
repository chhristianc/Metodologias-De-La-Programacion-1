using System;

namespace TP6.Composite.TemplateMethod
{
    public class AlumnoProxy : IAlumno
    {
        private IAlumno alumnoReal = null;
        private string nombre;
        private int queCrear;

        public AlumnoProxy(string nombre, int queCrear)
        {
            this.nombre = nombre;
            this.queCrear = queCrear;
        }

        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                Console.WriteLine("Instancia del Alumno real desde el Proxy");
                alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(queCrear);
            }

            return alumnoReal.responderPregunta(pregunta);
        }
        public int getCalificacion()
        {
            return alumnoReal.getCalificacion();
        }

        public void setCalificacion(int calificación)
        {
            alumnoReal.setCalificacion(calificación);
        }

        public string mostrarCalificacion()
        {
            return alumnoReal.mostrarCalificacion();
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getLegajo()
        {
            return alumnoReal.getLegajo();
        }

        public int getDni()
        {
            return alumnoReal.getDni();
        }

        public double getPromedio()
        {
            return alumnoReal.getPromedio();
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            alumnoReal.setEstrategia(e);
        }

        public bool sosIgual(Comparable c)
        {
            return alumnoReal.sosIgual(c);
        }

        public bool sosMenor(Comparable c)
        {
            return alumnoReal.sosMenor(c);
        }

        public bool sosMayor(Comparable c)
        {
            return alumnoReal.sosMayor(c); ;
        }
    }
}