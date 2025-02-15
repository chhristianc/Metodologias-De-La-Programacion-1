﻿/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;
using MetodologíasDeProgramaciónI;
using TP7.ChainOfResponsability.Singleton;

namespace ObtencionDeDatos
{
	public class LectorDeArchivos : Manejador {

		private static LectorDeArchivos unicaInstancia;

		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\Usuario\Downloads\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		private StreamReader lector_de_archivos;
		
		private LectorDeArchivos(Manejador manejador):base(manejador){
			lector_de_archivos = new StreamReader(ruta_archivo);
		}

		public static LectorDeArchivos getInstance(Manejador manejador)
		{
			if (unicaInstancia == null)
				unicaInstancia = new LectorDeArchivos(manejador);
			return unicaInstancia;
		}
		
		public override double numeroDesdeArchivo(double max){
            string linea = lector_de_archivos.ReadLine();
            return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
        }
		
		public override string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
	}
}
