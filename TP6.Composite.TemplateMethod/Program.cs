using System;
using MetodologíasDeProgramaciónI;

namespace TP6.Composite.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            JuegoDeCartasPlantilla juego = new JuegoDeCartasConcreto();

            juego.jugar();



            /* Ejercicio 2

            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            IAlumno alumno;
            Teacher teacher = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                alumno = new AlumnoProxy(aleatorio.stringAleatorio(6), 7);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            for (int i = 0; i < 10; i++)
            {
                alumno = new AlumnoProxy(aleatorio.stringAleatorio(6), 8);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            teacher.teachingAClass();

            */
        }
    }
}