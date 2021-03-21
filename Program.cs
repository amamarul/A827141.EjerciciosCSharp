using System;
using System.Threading;

namespace LaConsola
{
    class Program
    {
        private static string NombreUsuario { get; set; }
        
        
        static void Main(string[] args)
        {           
            Uno();
            Dos();
            Tres();
        }

        private static void Uno() 
        {
            Console.Clear();
            
            Console.WriteLine("Hola Mundo");
            PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Dos() 
        {
            Console.Clear();

            NombreUsuario = IngresoTexto("Por favor ingrese su nombre");

            Console.Clear();

            Console.WriteLine("\n\nBienvenid@ " + NombreUsuario + "\n");

            PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Tres() 
        {           
            PresionaXParaSalir();
        }

        public static void WriteGreenLine(string value, bool extraLine = true)
        {           
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("".PadRight(Console.WindowWidth - 1));
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            Console.WriteLine("".PadRight(Console.WindowWidth - 1));

            Console.ResetColor();

            if (extraLine)
            {
                Console.WriteLine("");
            }
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

        public static void PresionaUnaTeclaParaContinuar(string mensaje = "\n\nPresiona una tecla para continuar")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine(mensaje);

            Console.ResetColor();

            Console.ReadKey();
        }

        /*
            Ref.: https://docs.microsoft.com/es-es/dotnet/api/system.console.keyavailable?view=net-5.0#System_Console_KeyAvailable
         */
        public static void PresionaXParaSalir(string tecla = "X")
        {
            string Mensaje = "Presiona la tecla " + tecla + " para salir";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            
            ConsoleKeyInfo cki;

            ConsoleKey ck = GetConsoleKeyFromString(tecla);

            do
            {
                Console.WriteLine(Mensaje);

                cki = Console.ReadKey(true);
            } while (cki.Key != ck);

            Console.ResetColor();

            Exit();
        }

        /*
            Ref.: https://stackoverflow.com/a/11495179
         */
        private static ConsoleKey GetConsoleKeyFromString(string tecla)
        {
            ConsoleKey ck;

            Enum.TryParse<ConsoleKey>(tecla, out ck);

            return ck;
        }

        public static void Exit()
        {
            Console.Clear();

            Console.WriteLine("\n\n\tHasta pronto {0}!\n", NombreUsuario);

            System.Environment.Exit(0);
        }
    }
}
