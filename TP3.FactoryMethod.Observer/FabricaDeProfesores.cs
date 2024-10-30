using System;

namespace TP3.FactoryMethod.Observer
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Profesor(generador.stringAleatorio(6), generador.numeroAleatorio(10000),
                generador.numeroAleatorio(40));
        }

        public override Comparable crearPorTeclado()
        {
            return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(),
                lector.numeroPorTeclado());
        }
    }
}