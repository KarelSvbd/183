using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackerman
{
    public partial class Form1 : Form
    {
        int compteur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            compteur++;
            lblScore.Text = compteur.ToString();
            
        }
    }
}
