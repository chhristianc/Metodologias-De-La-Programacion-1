using System;

namespace TP6.Composite.TemplateMethod
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