using System;

namespace TP6.Composite.TemplateMethod
{
    public class FabricaDeAlumnosMuyEstudiososCompuestos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            IAlumno compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.crearAleatorio(6);
                ((AlumnoCompuesto)compuesto).agregarHijo(a);
            }

            return compuesto;
        }

        public override Comparable crearPorTeclado()
        {
            IAlumno compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.creaPorTeclado(6);
                ((AlumnoCompuesto)compuesto).agregarHijo(a);
            }

            return compuesto;
        }
    }
}
