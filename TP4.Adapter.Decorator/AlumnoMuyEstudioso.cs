using System;

namespace TP4.Adapter.Decorator
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
