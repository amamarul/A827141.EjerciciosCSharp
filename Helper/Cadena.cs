using System.Globalization;

namespace Helper
{
    public class Cadena
    {
        public const string CURRENT_LANG = "es-AR";

        public static string ToTitleCase(string title)
        {
            TextInfo textInfo = new CultureInfo(CURRENT_LANG, false).TextInfo;

            return textInfo.ToTitleCase(title.ToLower()); 
        }

        public static string reemplazarAcentosEnVocales(string texto)
        {
            return texto.Replace("á","a")
                        .Replace("é","e")
                        .Replace("í","i")
                        .Replace("ó","o")
                        .Replace("ú","u");
        }
    }
}