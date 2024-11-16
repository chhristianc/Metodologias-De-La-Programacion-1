using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((Alumno)c);
        }
    }
}