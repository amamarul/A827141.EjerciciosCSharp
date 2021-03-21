using System;

namespace Helper
{
    public static class Input
    {
        public static string IngresoTexto(string mensaje = "Ingrese un texto")
        {
            string texto;
            do
            {
                Input.WriteGreenLine(mensaje);
                texto = Console.ReadLine();
            } while (texto == "");

            return texto;
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

        public static void WriteRedLine(string Mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Mensaje);
            Console.ResetColor();
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
        }

        /*
            Ref.: https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-5.0
         */
        public static void SalirControlMas(string teclaSalida)
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            // Console.TreatControlCAsInput = true;

            string salir = "CTL+" + teclaSalida.ToUpper();
            string tempsalir = "";

            Input.WriteRedLine("Presiona CTL + "+ teclaSalida +" para salir");

            do {
                cki = Console.ReadKey(true);

                tempsalir = "";

                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) {
                    tempsalir += "CTL+";
                } 
                    
                tempsalir += cki.Key;
                
            } while (salir != tempsalir);
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

        public static void Exit(string NombreUsuario)
        {
            Console.Clear();

            Console.WriteLine("\n\n\tHasta pronto {0}!\n", NombreUsuario);

            System.Environment.Exit(0);
        }
    }
}
