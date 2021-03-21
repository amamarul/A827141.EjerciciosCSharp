using System;
using FrasesLib;

namespace Helper
{
    public class Frase
    {
        public static Frases IngresoFrases(
            string salida = "fin", 
            string Mensaje = "Escribe tu frase"
        ) {
            Console.WriteLine("\n");

            Frases frases = new Frases();
            
            string input;

            do
            {
                Console.WriteLine("\t" + Mensaje);

                Input.WriteRedLine("\to \""+ salida +"\" para no ingresar mas frases");

                input = Console.ReadLine();

                if (salida != input)
                {
                    frases.agregarFrase(input);
                }
            } while (salida != input);

            return frases;
        }
    }
}