using System;

namespace TP4.Adapter.Decorator
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
                case 4:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
                case 5:
                    fabrica = new FabricaDeAlumnosDecorados();
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnosMuyEstudiososDecorados();
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
                case 3:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
                case 5: 
                    fabrica = new FabricaDeAlumnosDecorados();
                    break;
                case 6:
                    fabrica = new FabricaDeAlumnosMuyEstudiososDecorados();
                    break;
            }

            return fabrica.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}