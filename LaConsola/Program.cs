using System.Collections.Generic;
using System;
using System.Threading;
using LaConsola.Model;
using Helper;

namespace LaConsola
{
    class Program
    {
        private static string NombreUsuario { get; set; }
        private static List<Frase> Frases = new List<Frase> {};
        
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

            IngresoFrases();

            Console.Clear();
        }

        private static void Cinco() 
        {           
            Input.SalirControlMas("F");
            Input.Exit(NombreUsuario);
        }

        public static void IngresoFrases(
            string salida = "fin", 
            string Mensaje = "Escribe tu frase"
        ) {
            Console.WriteLine("\n");
            
            string input;

            do
            {
                Console.WriteLine("\t" + Mensaje);

                Input.WriteRedLine("\to \""+ salida +"\" para no ingresar mas frases");

                input = Console.ReadLine();

                if (salida != input)
                {
                    Frases.Add(new Frase(input));
                }
            } while (salida != input);
        }
    }
}
