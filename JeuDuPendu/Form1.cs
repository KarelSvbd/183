using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class Form1 : Form
    {
        Pendu P = new Pendu(7);
        public Form1()
        {
            InitializeComponent();
            RefreshView();
        }
        private void RefreshView()
        {
            tbxMot.Text = P.Jeu;
            lblVies.Text = P.Vies;
            tbxResultat.Text = P.RetourJeu;
            btnJouer.Enabled = !P.EstFini;
            tbxAncienneLettres.Text = P.FaussesLettres;
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            P.Jouer(Convert.ToChar(tbxLettre.Text));
            RefreshView();
        }
    }
}
