﻿using System;

namespace TP4.Adapter.Decorator
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso(generador.stringAleatorio(6), generador.numeroAleatorio(10000),
                generador.numeroAleatorio(10000), generador.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(lector.stringPorTeclado(), lector.numeroPorTeclado(),
                lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}