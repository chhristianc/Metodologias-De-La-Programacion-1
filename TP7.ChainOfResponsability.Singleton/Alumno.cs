using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class Alumno : Persona, Observador, IAlumno
    {
        private int legajo;
        private int calificacion;
        private double promedio;
        private EstrategiaDeComparacion estrategia;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new EstrategiaPorLegajo();
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public int getCalificacion()
        {
            return calificacion;
        }

        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);
        }

        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c); ;
        }

        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención");
        }

        public void distraerse()
        {
            Random random = new Random();

            List<string> distracciones = new List<string>{ 
                "Mirando el celular",
                "Dibujando en el margen de la carpeta",
                "Tirando aviones de papel"
            };

            Console.WriteLine(distracciones[random.Next(0,3)]);
        }

        public void actualizar(Observado o)
        {
            if (((Profesor)o).isHablando())
            {
                prestarAtencion();
            }
            else
            {
                distraerse();
            }
        }

        public virtual int responderPregunta(int pregunta)
        {
            Random random = new Random();

            return random.Next(1,3);
        }

        public string mostrarCalificacion()
        {
            return nombre + "   " + calificacion;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " Dni: " + dni + " Legajo: " + legajo + " Promedio: " + promedio;
        }
    }
}