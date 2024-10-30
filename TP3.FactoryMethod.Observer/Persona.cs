using System;

namespace TP3.FactoryMethod.Observer
{
    public class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }

        public virtual bool sosIgual(Comparable c)
        {
            return dni == ((Persona)c).getDni();
        }

        public virtual bool sosMenor(Comparable c)
        {
            return dni < ((Persona)c).getDni();
        }

        public virtual bool sosMayor(Comparable c)
        {
            return dni > ((Persona)c).getDni();
        }

        public override string ToString()
        {
            return dni.ToString();
        }
    }
}