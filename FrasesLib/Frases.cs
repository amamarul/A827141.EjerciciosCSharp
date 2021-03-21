using FrasesLib.Model;
using System.Collections.Generic;

namespace FrasesLib
{
    public class Frases
    {
        private List<Frase> _frases;

        public Frases()
        {
            this._frases = new List<Frase> {};
        }

        public Frases(List<Frase> frases)
        {
            this._frases = frases;
        }

        public List<Frase> ListaDeFrases { 
            get => _frases;
        }

        public void agregarFrase(string texto)
        {
            this._frases.Add(new Frase(texto));
        }

        public void agregarFrases(List<string> frases)
        {
            foreach (string frase in frases)
            {
                this.agregarFrase(frase);
            }
        }
    }
}