using System.Globalization;

namespace Helper
{
    public class Cadena
    {
        public static string ToTitleCase(string title)
        {
            TextInfo textInfo = new CultureInfo("es-AR", false).TextInfo;

            return textInfo.ToTitleCase(title.ToLower()); 
        }
    }
}