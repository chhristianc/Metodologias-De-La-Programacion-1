using System;
using ObtencionDeDatos;
using MetodologíasDeProgramaciónI;

namespace TP7.ChainOfResponsability.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            IAlumno alumno;
            Teacher teacher = new Teacher();
            AlumnoAdapter adaptado;


            //Creación de 5 alumnos aleatoriamente

            for (int i = 0; i < 5; i++)
            {
                alumno = (AlumnoDecorator)FabricaDeComparables.crearAleatorio(5);
                adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }


            //Creación de 2 alumnos muy estudiosos por teclado

            for (int i = 0; i < 2; i++)
            {
                alumno = (AlumnoDecorator)FabricaDeComparables.creaPorTeclado(6);
                adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }


            //Creación de cinco alumnos que forman un compuesto desde el archivo

            alumno = (AlumnoCompuesto)FabricaDeComparables.crearDesdeArchivo(7);
            adaptado = new AlumnoAdapter(alumno);
            teacher.goToClass(adaptado);

            teacher.teachingAClass();
        }
    }
}