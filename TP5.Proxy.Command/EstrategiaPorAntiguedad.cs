﻿using System;

namespace TP5.Proxy.Command
{
    public class EstrategiaPorAntiguedad : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).getAntiguedad() == ((Profesor)c2).getAntiguedad();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).getAntiguedad() < ((Profesor)c2).getAntiguedad();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Profesor)c1).getAntiguedad() > ((Profesor)c2).getAntiguedad();
        }
    }
}
