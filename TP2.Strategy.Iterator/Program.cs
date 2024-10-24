namespace TP2.Strategy.Iterator
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            // Imprimir elementos de cada Coleccionable

            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();

            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            llenarAlumnos(diccionario);

            Console.WriteLine("Elementos Pila");
            imprimirElementos(pila);
            Console.WriteLine();

            Console.WriteLine("Elementos Cola");
            imprimirElementos(cola);
            Console.WriteLine();

            Console.WriteLine("Elementos Conjunto");
            imprimirElementos(conjunto);
            Console.WriteLine();

            Console.WriteLine("Elementos Diccionario");
            imprimirElementos(diccionario);
            Console.WriteLine();


            // Comparar elementos de un Coleccionable

            Console.WriteLine("Comparación de los elementos de la Pila");
            Console.WriteLine();

            Console.WriteLine("Comparación por Nombre");
            cambiarEstrategia(pila, new EstrategiaPorNombre());
            informar(pila);
            Console.WriteLine();

            Console.WriteLine("Comparación por Legajo");
            cambiarEstrategia(pila, new EstrategiaPorLegajo());
            informar(pila);
            Console.WriteLine();

            Console.WriteLine("Comparación por Promedio");
            cambiarEstrategia(pila, new EstrategiaPorPromedio());
            informar(pila);
            Console.WriteLine();

            Console.WriteLine("Comparación por DNI");
            cambiarEstrategia(pila, new EstrategiaPorDni());
            informar(pila);
        }

        public static void llenarAlumnos(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable com = new Alumno(nombreRandom(), random.Next(1, 10000),
                    random.Next(1, 10000), random.Next(1, 10));

                c.agregar(com);
            }
        }

        public static void informar(Coleccionable c)
        {
            Console.WriteLine("Mínimo: " + c.minimo());
            Console.WriteLine("Máximo: " + c.maximo());
        }

        public static string nombreRandom()
        {
            string nombre = "";
            string letras = "abcdefghijklmnñopqrstuvwxyz";

            for (int i = 0; i < random.Next(4, 10); i++)
            {
                nombre += letras[random.Next(0, 27)];
            }

            return nombre;
        }

        public static void imprimirElementos(Coleccionable c)
        {
            Iterador ite = ((Iterable)c).crearIterador();

            ite.primero();

            while(!ite.fin())
            {
                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }

        public static void cambiarEstrategia(Coleccionable c, EstrategiaDeComparacion e)
        {
            Iterador ite = ((Iterable)c).crearIterador();

            ite.primero();

            while (!ite.fin())
            {
                ((Alumno)ite.actual()).setEstrategia(e);
                ite.siguiente();
            }
        }
    }
}