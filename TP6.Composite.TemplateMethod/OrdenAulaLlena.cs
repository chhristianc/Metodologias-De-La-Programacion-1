using System;

namespace TP6.Composite.TemplateMethod
{
    public class OrdenAulaLlena : OrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.claseLista();
        }
    }
}