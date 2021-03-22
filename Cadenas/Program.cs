using System.Globalization;
using System;
using Helper;
using FrasesLib;
using FraseModel = FrasesLib.Model.Frase;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadenas
{
    class Program
    {
        private static string NombreUsuario { get; set; }        

        static void Main(string[] args)
        {
            Uno();
            Dos();
            Tres();
            Cuatro();
            Cinco();
        }

        private static void Uno() 
        {
            Console.Clear();

            NombreUsuario = Cadena.ToTitleCase(
                Input.IngresoTexto("Por favor ingrese su nombre"));

            Console.Clear();

            Console.WriteLine("\n\nHola " + NombreUsuario + "\n");

            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Dos() 
        {
            Console.Clear();
            string searchedString = "fin";

            Frases frases = Helper.Frase.IngresoFrases();

            foreach (FraseModel frase in frases.buscarFrasesQueContienen(searchedString))
            {
                Console.WriteLine("La frase: '{0}' contiene la cadena '{1}'",
                frase.Texto, searchedString);
            }

            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Tres() 
        {
            Console.Clear();
            string Texto = Cadena.ToTitleCase(
                Input.IngresoTexto("Por favor ingrese un texto cualquiera"));

            Console.Clear();
            
            Console.WriteLine($"\nTexto ingresado");
            
            Console.WriteLine(Texto.ToUpper());

            Console.WriteLine($"");
            
            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Cuatro() 
        {
            Console.Clear();
            string Texto = Cadena.ToTitleCase(
                Input.IngresoTexto("Por favor ingrese un texto cualquiera"));

            Console.Clear();
            
            Console.WriteLine($"\nTexto ingresado");
            
            Console.WriteLine(Texto.ToLower());

            Console.WriteLine($"");
            
            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Cinco() 
        {
            Console.Clear();
            string Texto = Input.IngresoTexto("Por favor ingrese un texto cualquiera");

            Console.Clear();
            
            Console.WriteLine($"\nTexto ingresado SIN ACENTOS");
            
            Console.WriteLine(Cadena.reemplazarAcentosEnVocales(Texto));

            Console.WriteLine($"");
            
            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }
    }
}
