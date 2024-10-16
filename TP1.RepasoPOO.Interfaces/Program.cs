namespace TP1.RepasoPOO.Interfaces
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            informar(multiple);
        }

        public static void llenarPersonas(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Persona(nombreRandom(), random.Next(1, 10000));
                c.agregar(comparable);
            }
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
            Console.WriteLine("Cantidad de elementos: " + c.cuantos());
            Console.WriteLine("Mínimo: " + c.minimo());
            Console.WriteLine("Máximo: " + c.maximo());
            Console.WriteLine("Ingrese el legajo del alumno para verificar si está en la colección");
            Comparable com = new Alumno("", 1, int.Parse(Console.ReadLine()), 10);
            if (c.contiene(com))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
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

        public static void llenar(Coleccionable c)
        {
            for (int i = 0; i < 20; i++)
            {
                c.agregar(new Numero(random.Next(0, 100)));
            }
        }
    }
}