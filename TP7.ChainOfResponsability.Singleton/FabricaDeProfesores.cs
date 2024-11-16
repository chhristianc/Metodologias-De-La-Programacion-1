using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Profesor(responsable.stringAleatorio(6), responsable.numeroAleatorio(10000),
                responsable.numeroAleatorio(40));
        }

        public override Comparable crearPorTeclado()
        {
            return new Profesor(responsable.stringPorTeclado(), responsable.numeroPorTeclado(),
                responsable.numeroPorTeclado());
        }

        public override Comparable crearDesdeArchivo()
        {
            return new Profesor(responsable.stringDesdeArchivo(6), (int)responsable.numeroDesdeArchivo(10000),
                (int)responsable.numeroDesdeArchivo(40));
        }
    }
}