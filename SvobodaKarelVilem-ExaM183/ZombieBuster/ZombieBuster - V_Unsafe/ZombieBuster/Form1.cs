/*
 * Auteur       : Karel Vilém Svoboda & S.J. - CFPT
 * Desc         : Sécuriser une application pour l'examen du 183
 * Zombie Buster: Jeu stupide qui consiste à taper sur des zombies
 * 
 * Version      : 2
 * Date         : 02.11.2021
 * 
 * Réponses aux questions : 
 *      1. Oui, le code peut se faire décompiler
 *      2. Il faudrait utiliser un logiciel comme ConfuserEX pour y prévenir
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ZombieBuster
{
    public partial class Form1 : Form
    {
        //défininition du Salt en constante
        const string SALT = "exaM183";
        const int APP_WIDTH = 1000;
        const int APP_HEIGHT = 600;
        const int PLAY_TIME = 10;
        int elapsedTime;
        int score;
        int bestScore;
        Random r;
        PictureBox pibZombie;
        StreamWriter ecritureFichier = null;
        string backupScore = "backupScore.txt";
        StreamReader lectureFichier = null;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            //Init du zombie
            pibZombie = new PictureBox();
            pibZombie.Image = Properties.Resources.zombie;
            pibZombie.SizeMode = PictureBoxSizeMode.Zoom;
            pibZombie.Height = 200;
            pibZombie.Width = 100;
            pibZombie.Parent = this;
            pibZombie.Click += hitZombie;
            pibZombie.Visible = false;
            //Init du meilleur score
            bestScore = 0;
            if (File.Exists(backupScore))
            {
                lectureFichier = new StreamReader(backupScore);
                string ligne1 = lectureFichier.ReadLine();
                string ligne2 = lectureFichier.ReadLine();
                bestScore = RechercheNumeroParHash(ligne1);
                lectureFichier.Close();
                lectureFichier = null;
            }
            lblBestScore.Text = "Best Score: " + bestScore;
        }

        private void startGame()
        {
            this.Cursor = Cursors.Cross;
            pibZombie.Visible = true;
            pibZombie.Location = new Point(r.Next(APP_WIDTH - pibZombie.Width), r.Next(1, APP_HEIGHT - pibZombie.Height));
            btnStart.Visible = false;
            timer1.Start();
            elapsedTime = 0;
            score = 0;
            lblBestScore.Text = "";
            lblScore.Text = "";
        }

        private void stopGame()
        {
            this.Cursor = Cursors.Default;
            pibZombie.Visible = false;
            btnStart.Visible = true;
            timer1.Stop();
            if (bestScore < score)
            {
                bestScore = score;
            }
            lblBestScore.Text = "Best Score: " + bestScore;
            lblScore.Text = "Your Score: " + score;
        }

        private void hitZombie(object sender, EventArgs e)
        {
            score++;
            pibZombie.Image = Properties.Resources.hammer;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pibZombie.Location = new Point(r.Next(APP_WIDTH - pibZombie.Width), r.Next(1, APP_HEIGHT - pibZombie.Height));
            elapsedTime++;
            pibZombie.Image = Properties.Resources.zombie;
            if (elapsedTime >= PLAY_TIME)
            {
                stopGame();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            ecritureFichier = new StreamWriter(backupScore);
            ecritureFichier.WriteLine(GenerateHash(score.ToString()));
            ecritureFichier.WriteLine(EncryptionMaison(score));
            ecritureFichier.Close();
            ecritureFichier = null;
        }

        /// <summary>
        /// Génére un Hash avec Salt
        /// </summary>
        /// <param name="input">mot à hasher</param>
        /// <param name="salt">salt</param>
        /// <returns></returns>
        public static string GenerateHash(string input)
        {
            string hashSalt = input + SALT;
            byte[] bytes = Encoding.UTF8.GetBytes(hashSalt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Vérifie sir deux hash sont égaux
        /// </summary>
        /// <param name="plainTextInput">text non hashé</param>
        /// <param name="hashedInput">hash non comparé</param>
        /// <returns></returns>
        public static bool AreEqual(string plainTextInput, string hashedInput)
        {
            string text = plainTextInput + SALT;
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            string textHash = Convert.ToBase64String(hash);
            return textHash.Equals(hashedInput);
        }

        /// <summary>
        /// Permet d'encrypter grâce à une mthode personnalisée 
        /// </summary>
        /// <param name="score">score à encrypter</param>
        /// <returns>resultat encrypté</returns>
        public string EncryptionMaison(int score)
        {
            string strScore = Convert.ToString(score * 36);
            string resultat = "";
            Random rnd = new Random();
            foreach (char chiffre in strScore)
            {
                resultat += chiffre + rnd.Next(0, 9).ToString();
            }
            Console.WriteLine(resultat);
            return resultat;
        }

        /// <summary>
        /// Permet de décrypter une une string de encrypteMaison
        /// </summary>
        /// <param name="hash"></param>
        /// <returns>resultat encrypté</returns>
        public string DecryptageMaison(string hash)
        {
            int compteur = 0;
            string resultat = "";
            
            foreach(char chiffre in hash)
            {
                //Chaque partie s'execute une fois sur deux
                //Si le compteur est à 0, on ajoute la valeur dans résultat
                if(compteur == 0)
                {
                    resultat += chiffre;
                    compteur++;
                }
                //Si le compteur n'est pas à 0, cela veut dire que la donnée est fausse on ne la garde pas
                else
                {
                    compteur = 0;
                }
            }
            string resultDivisePar36 = Convert.ToString(Convert.ToInt32(resultat) / 36);
            return resultDivisePar36;
        }

        /// <summary>
        /// Permet de trouver le numéro contenu dans la ligne en parcourant les hash des numéro de 0 à 20
        /// </summary>
        /// <param name="ligneCryptée"></param>
        /// <returns>retourne le numréro touvé, sinon retroune 0</returns>
        public int RechercheNumeroParHash(string ligneCryptée)
        {
            for (int i = 0; i< 20; i++)
            {
                if (AreEqual(i.ToString(), ligneCryptée))
                {
                     return i;
                }
            }
            return 0;
        }
    }
}
