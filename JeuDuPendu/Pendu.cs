using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuPendu
{
    
    class Pendu
    {
        private List<string> _lstMots;
        private List<char> _lstLettreTrouvee = new List<char>();
        private List<char> _lstLettreFausses= new List<char>();
        private string _motChoisi;
        Random _rnd = new Random();
        private int _nbrErreursMax;
        private int _erreurs;
        private string _jeu;
        private int _lettreTrouvee;
        private string _retourJeu;
        private bool _estFini = false;
      

        public int TailleMot
        {
            get
            {
                return _motChoisi.Length;
            }
        }

        public string Jeu
        {
            get
            {
                return _jeu;
            }
        }

        public string Vies
        {
            get
            {
                return Convert.ToString(_nbrErreursMax - _erreurs);
            }
        }

        public string RetourJeu
        {
            get
            {
                return _retourJeu;
            }
        }

        public string FaussesLettres
        {
            get
            {
                string resultat = "";
                foreach(char lettre in _lstLettreFausses)
                {
                    resultat += lettre.ToString() + " ";
                }
                return resultat;
            }
        }

        public bool EstFini
        {
            get
            {
                return _estFini;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nbrErreurs">Définit le nombre d'erreur maximal du joueur</param>
        public Pendu(int nbrErreurs)
        {
            _nbrErreursMax = nbrErreurs;
            _lstMots = RechercheMotFichier();
            _motChoisi = RechercheMot();
            Initialisation();

            Console.WriteLine(_motChoisi);
        }
        
        /// <summary>
        /// Permet de rechercher les mots présent dans un fichier texte
        /// </summary>
        /// <returns>La liste de mots</returns>
        private List<string> RechercheMotFichier()
        {
            Fichier RechercheFichier = new Fichier();
            return RechercheFichier.ListeMots;
        }

        /// <summary>
        /// Permet de 
        /// </summary>
        /// <returns></returns>
        private string RechercheMot()
        {
            return _lstMots[_rnd.Next(0, _lstMots.Count)];
        }


        public void Initialisation()
        {
            for (int i = 0; i < TailleMot; i++)
            {
                _jeu += "*";
            }
        }

        public void Jouer(char lettre)
        {
            bool trouve = false;
            bool trouveAncienneLettre = false;
            bool ignoreCondition = false;
            int compteur = 0;
            foreach(char element in _motChoisi)
            {
                if(element == lettre)
                {
                    foreach(char ancienneLettre in _lstLettreTrouvee)
                    {
                        if(lettre == ancienneLettre && !ignoreCondition)
                        {
                            trouveAncienneLettre = true;
                        }
                    }
                    if (!trouveAncienneLettre)
                    {
                        trouve = true;
                        _lstLettreTrouvee.Add(lettre);
                        StringBuilder strBuilder = new StringBuilder(_jeu);
                        strBuilder[compteur] = lettre;
                        _jeu = strBuilder.ToString();
                        _retourJeu = "Lettre " + lettre.ToString() + " Trouvée";
                        _lettreTrouvee++;
                        ignoreCondition = true;
                    }
                    else
                    {
                        _retourJeu = "Lettre déjà saisie";
                        trouve = true;
                    }
                    
                }
                compteur++;
            }

            if (!trouve)
            {
                _lstLettreFausses.Add(lettre);
                _erreurs++;
            }

            if(_lettreTrouvee == TailleMot)
            {
                _retourJeu = "Vous avez gagné. Votre nombre d'erreurs s'élève à " + _erreurs.ToString() + ".";
            }

            if(_erreurs >= _nbrErreursMax)
            {
                _estFini = true;
                _retourJeu = "Echéc, le mot était " + _motChoisi + ".";
            }
        }
    }
}
