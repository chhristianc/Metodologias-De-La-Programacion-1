using System;
using MetodologíasDeProgramaciónI;

namespace TP5.Proxy.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Aula aula = new Aula();

            pila.setOrdenInicio(new OrdenInicio(aula));
            pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            llenar(pila, 2);
            llenar(pila, 4);




            /* Ejercicio 2 TP5

            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            IAlumno alumno;
            Teacher teacher = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                alumno = new AlumnoProxy(aleatorio.stringAleatorio(6), 2);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            for (int i = 0; i < 10; i++)
            {
                alumno = new AlumnoProxy(aleatorio.stringAleatorio(6), 4);
                AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
                teacher.goToClass(adaptado);
            }

            teacher.teachingAClass();

            */


        }

        public static void llenar(Coleccionable c, int opc)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable com = FabricaDeComparables.crearAleatorio(opc);

                c.agregar(com);
            }
        }
    }
}