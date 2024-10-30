using System;

namespace TP3.FactoryMethod.Observer
{
    public abstract class FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios generador;
        protected LectorDeDatos lector;

        public FabricaDeComparables()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }

        public static Comparable creaAleatorio(int opc)
        {
            FabricaDeComparables fabrica = null;

            switch(opc)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeProfesores();
                    break;

                default:
                    break;
            }

            return fabrica.crearAleatorio();
        }

        public static Comparable creaPorTeclado(int opc)
        {
            FabricaDeComparables fabrica = null;

            switch (opc)
            {
                case 1:
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
            }

            return fabrica.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}