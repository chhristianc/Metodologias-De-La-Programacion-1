using System;

namespace TP7.ChainOfResponsability.Singleton
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