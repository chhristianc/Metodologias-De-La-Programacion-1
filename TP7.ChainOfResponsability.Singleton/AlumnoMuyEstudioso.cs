using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
        
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
