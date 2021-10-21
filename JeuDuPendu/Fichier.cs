using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace JeuDuPendu
{
    class Fichier
    {
        private List<string> _listeMots = new List<string>();

        public List<string> ListeMots
        {
            get
            {
                return _listeMots;
            }
        }
        public Fichier()
        {
            // /!\ changer la location de l'élément en cas de changmenet de machine/!\
            string fileName = @"../../files/liste_francais.txt";

            //Stockage des lignes dans un Enumerable
            IEnumerable<string> lines = File.ReadLines(fileName, Encoding.UTF8);
            RetrunListMots(lines);

        }

        private void RetrunListMots(IEnumerable<string> lignes)
        {
            //Chaque ligne correspond à un animal qu'on ajoute dans la liste
            foreach (string mot in lignes)
            {
                //Console.WriteLine(Formatage(mot));
                _listeMots.Add(Formatage(mot));
            }
        }

        private string Formatage(string mot)
        {
            mot = mot.ToLower();
            mot = RemoveDiacritics(mot);

            return mot;
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        
    }
}

