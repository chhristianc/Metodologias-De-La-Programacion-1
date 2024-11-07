﻿using System;

namespace TP4.Adapter.Decorator
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Alumno(generador.stringAleatorio(6), generador.numeroAleatorio(10000),
                generador.numeroAleatorio(10000), generador.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno(lector.stringPorTeclado(),lector.numeroPorTeclado(),
                lector.numeroPorTeclado(),lector.numeroPorTeclado());
        }
    }
}