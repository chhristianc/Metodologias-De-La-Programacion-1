using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(responsable.numeroAleatorio(100));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(responsable.numeroPorTeclado());
        }

        public override Comparable crearDesdeArchivo()
        {
            return new Numero((int)responsable.numeroDesdeArchivo(100));
        }
    }
}