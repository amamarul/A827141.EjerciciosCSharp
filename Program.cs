using System;

namespace LaConsola
{
    class Program
    {
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

            string nombre = IngresoTexto("Por favor ingrese su nombre");

            Console.Clear();

            Console.WriteLine("\n\nBienvenid@ " + nombre + "\n");

            PresionaUnaTeclaParaContinuar("Presiona una tecla para continuar");
        }

        private static void Tres() 
        {           
            PresionaXParaSalir();
        }

        public static void WriteGreenLine(string value)
        {
            Console.Clear();
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("".PadRight(Console.WindowWidth - 1));
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            Console.WriteLine("".PadRight(Console.WindowWidth - 1));

            Console.ResetColor();

            Console.WriteLine("");
            
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

        public static void PresionaXParaSalir(string tecla = "x")
        {
            bool valor;
            bool continuar;
            string Mensaje = "Presiona la tecla " + tecla + " para salir";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n"+Mensaje);
            do
            {

                continuar = !bool.TryParse(
                    Console.ReadLine()
                            .ToLower()
                            .Replace(tecla, "true"),
                    out valor);
                if (continuar)
                {
                    Console.WriteLine(Mensaje);
                }
            } while (continuar);

            Console.ResetColor();
            
            Exit();
        }

        public static void Exit()
        {
            Console.Clear();

            Console.WriteLine("\n\n\tHasta pronto!\n");

            System.Environment.Exit(0);
        }
    }
}
