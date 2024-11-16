using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            IAlumno compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.crearAleatorio(5);
                ((AlumnoCompuesto)compuesto).agregarHijo(a);
            }

            return compuesto;
        }

        public override Comparable crearPorTeclado()
        {
            IAlumno compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.creaPorTeclado(5);
                ((AlumnoCompuesto)compuesto).agregarHijo(a);
            }

            return compuesto;
        }

        public override Comparable crearDesdeArchivo()
        {
            IAlumno compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.crearDesdeArchivo(5);
                ((AlumnoCompuesto)compuesto).agregarHijo(a);
            }

            return compuesto;
        }
    }
}