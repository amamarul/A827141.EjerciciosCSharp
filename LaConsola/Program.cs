using System.Collections.Generic;
using System;
using System.Threading;
using LaConsola.Model;

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

        private static void Cuatro() 
        {           
            Console.Clear();

            WriteGreenLine("          Momento de reflexion");
            WriteGreenLine("¿En que estas pensando?");

            IngresoFrases();

            Console.Clear();
        }

        private static void Cinco() 
        {           
            SalirControlMas("F");
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
        public static void PresionaXParaSalir(string tecla = "X", string Mensaje = "Presiona la tecla X para salir")
        {
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

        public static void IngresoFrases(
            string salida = "fin", 
            string Mensaje = "Escribe tu frase"
        ) {
            Console.WriteLine("\n");
            
            string input;

            do
            {
                Console.WriteLine("\t" + Mensaje);

                WriteRedLine("\to \""+ salida +"\" para no ingresar mas frases");

                input = Console.ReadLine();

                if (salida != input)
                {
                    Frases.Add(new Frase(input));
                }
            } while (salida != input);
        }

        /*
            Ref.: https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
         */
        public static void SalirControlMas(string teclaSalida)
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            // Console.TreatControlCAsInput = true;

            string salir = "SHIFT+CTL+" + teclaSalida.ToUpper();
            string tempsalir = "";

            WriteRedLine("Presiona CTL + "+ teclaSalida +" para salir");

            do {
                cki = Console.ReadKey(true);

                tempsalir = "";

                if((cki.Modifiers & ConsoleModifiers.Shift) != 0) {
                    tempsalir += "SHIFT+";
                    Console.Write("SHIFT+");
                }

                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) {
                    tempsalir += "CTL+";
                    Console.Write("CTL+");
                } 
                    
                tempsalir += cki.Key;
                Console.WriteLine(cki.Key);
                
            } while (salir != tempsalir);

            Exit();
        }

        private static void WriteRedLine(string Mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Mensaje);
            Console.ResetColor();
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
