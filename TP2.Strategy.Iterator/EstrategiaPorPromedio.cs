﻿using System;

namespace TP2.Strategy.Iterator
{
    public class EstrategiaPorPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() == a2.getPromedio();
        }
        public bool sosMenor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() < a2.getPromedio();
        }
        public bool sosMayor(Alumno a1, Alumno a2)
        {
            return a1.getPromedio() > a2.getPromedio();
        }
    }
}