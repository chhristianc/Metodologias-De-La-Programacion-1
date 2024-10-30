namespace TP3.FactoryMethod.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparable com = FabricaDeComparables.creaAleatorio(3);

            Profesor profesor = (Profesor)FabricaDeComparables.creaAleatorio(3);

            Pila pila = new Pila();

            llenar(pila, 2);

            agregarAlumnosObservadores(pila, profesor);

            dictadoDeClases(profesor);
        }

        public static void llenar(Coleccionable c, int opc)
        {
            for(int i=0; i<20; i++)
            {
                Comparable com = FabricaDeComparables.creaAleatorio(opc);

                c.agregar(com);
            }
        }

        public static void informar(Coleccionable c, int opc)
        {
            Console.WriteLine("Cantidad de elementos: " + c.cuantos());
            Console.WriteLine("Mínimo: " + c.minimo());
            Console.WriteLine("Máximo: " + c.maximo());
            Comparable comparable = FabricaDeComparables.creaPorTeclado(opc);
            if (c.contiene(comparable))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }

        public static void dictadoDeClases(Profesor profesor)
        {
            for(int i=0; i<5; i++)
            {
                profesor.hablarALaClase();
                profesor.escribirEnElPizarrón();
            }
        }

        public static void agregarAlumnosObservadores(Coleccionable c, Profesor p)
        {
            Iterador ite = ((Iterable)c).crearIterador();

            ite.primero();

            while (!ite.fin())
            {
                p.agregarObservador((Alumno)ite.actual());
                ite.siguiente();
            }
        }
    }
}