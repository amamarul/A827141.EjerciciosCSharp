using FrasesLib.Model;
using System.Collections.Generic;
using System.Linq;

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
            get => this._frases;
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

        public List<Frase> buscarFrasesQueContienen(string texto)
        {
            return this._frases
                    .Where( frase => frase.Texto.Contains(texto))
                    .ToList();
        }
    }
}