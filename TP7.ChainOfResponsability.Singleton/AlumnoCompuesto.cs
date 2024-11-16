using System;
using System.Collections.Generic;

namespace TP7.ChainOfResponsability.Singleton
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> hijos;

        public AlumnoCompuesto()
        {
            hijos = new List<IAlumno>();
        }

        public void agregarHijo(IAlumno a)
        {
            hijos.Add(a);
        }

        public string getNombre()
        {
            string nombre = "";

            foreach (IAlumno elem in hijos)
            {
                nombre += "\n" + elem.getNombre();
            }

            return nombre;
        }


        public int responderPregunta(int pregunta)
        {
            int[] respuestas = new int[3];

            foreach(IAlumno elem in hijos)
            {
                int respuesta = elem.responderPregunta(pregunta);
                respuestas[respuesta]++;
            }

            int maximo = respuestas.Max();

            List<int> masRespuestas = new List<int>();

            for(int i = 0; i<3; i++)
            {
                if (respuestas[i] == maximo)
                {
                    masRespuestas.Add(i);
                }
            }

            Random random = new Random();

            return masRespuestas[random.Next(0, masRespuestas.Count)];
        }

        public void setCalificacion(int calificacion)
        {
            foreach(IAlumno elem in hijos)
            {
                elem.setCalificacion(calificacion);
            }
        }

        public bool sosIgual(Comparable c)
        {
            foreach(IAlumno elem in hijos)
            {
                if(c.sosIgual(elem))
                    return true;
            }

            return false;
        }

        public bool sosMenor(Comparable c)
        {
            foreach(IAlumno elem in hijos)
            {
                if (c.sosMenor(elem))
                    return false;
            }

            return true;
        }

        public bool sosMayor(Comparable c)
        {
            foreach(IAlumno elem in hijos)
            {
                if (c.sosMayor(elem))
                    return false;
            }

            return true;
        }




        public int getLegajo()
        {
            return 0;
        }

        public int getDni()
        {
            return 0;
        }

        public double getPromedio()
        {
            return 0;
        }

        public string mostrarCalificacion()
        {
            string calificacionDeTodos = "";
            foreach (IAlumno alumno in hijos)
            {
                calificacionDeTodos += alumno.mostrarCalificacion() + "\n";
            }
            return calificacionDeTodos;
        }

        public int getCalificacion()
        {
            return 0;
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {

        }

        
    }
}
