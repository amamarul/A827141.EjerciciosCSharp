using System;

namespace LaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Uno();
            Dos();
        }

        private static void Uno() 
        {
            Console.WriteLine("Hola Mundo");
            PresionaUnaTeclaParaSalir("Presiona una tecla para continuar");
        }

        private static void Dos() 
        {
            string nombre = IngresoTexto("\tPor favor ingrese su nombre\n");
            Console.Clear();

            Console.WriteLine("\n\nBienvenid@ " + nombre);
            
            PresionaUnaTeclaParaSalir("Presiona una tecla para salir");
        }

        public static void WriteGreenLine(string value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("\n\n");

            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));

            Console.ResetColor();

            Console.WriteLine("\n");
        }

        public static string IngresoTexto(string mensaje = "Ingrese un texto")
        {
            string texto;
            do
            {
                WriteGreenLine(mensaje);
                texto = Console.ReadLine();
            } while (texto == "");

            return texto;
        }

        public static void PresionaUnaTeclaParaSalir(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("\n\n");
            Console.WriteLine(mensaje);

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
