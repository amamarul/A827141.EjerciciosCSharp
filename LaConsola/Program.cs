using System.Collections.Generic;
using System;
using System.Threading;
using FrasesLib;
using Helper;

namespace LaConsola
{
    class Program
    {
        private static string NombreUsuario { get; set; }
        private static Frases Frases;
        
        static void Main(string[] args)
        {           
            Uno();
            Dos();
            // Tres();
            Cuatro();
            Cinco();
        }

        private static void Uno() 
        {
            Console.Clear();
            
            Console.WriteLine("Hola Mundo");
            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Dos() 
        {
            Console.Clear();

            NombreUsuario = Input.IngresoTexto("Por favor ingrese su nombre");

            Console.Clear();

            Console.WriteLine("\n\nBienvenid@ " + NombreUsuario + "\n");

            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Tres() 
        {           
            Input.PresionaXParaSalir();
            Input.Exit(NombreUsuario);
        }

        private static void Cuatro() 
        {           
            Console.Clear();

            Input.WriteGreenLine("          Momento de reflexion");
            Input.WriteGreenLine("¿En que estas pensando?");

            Frases = Helper.Frase.IngresoFrases();

            Console.Clear();
        }

        private static void Cinco() 
        {           
            Input.SalirControlMas("F");
            Input.Exit(NombreUsuario);
        }
    }
}
