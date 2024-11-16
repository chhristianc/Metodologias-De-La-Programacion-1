﻿using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public interface IAlumno : Comparable
    {
        int responderPregunta(int pregunta);
        int getCalificacion();
        void setCalificacion(int calificación);
        string mostrarCalificacion();
        string getNombre();
        int getLegajo();
        int getDni();
        double getPromedio();
        void setEstrategia(EstrategiaDeComparacion e);
    }
}