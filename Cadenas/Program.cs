using System;
using Helper;

namespace Cadenas
{
    class Program
    {
        private static string NombreUsuario { get; set; }
        
        
        static void Main(string[] args)
        {
            Uno();
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

            NombreUsuario = Input.IngresoTexto("Por favor ingrese su nombre");

            Console.Clear();

            Console.WriteLine("\n\nHola " + NombreUsuario + "\n");

            Input.PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }
    }
}
