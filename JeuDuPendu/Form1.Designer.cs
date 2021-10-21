
namespace JeuDuPendu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMot = new System.Windows.Forms.TextBox();
            this.tbxLettre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVies = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.tbxAncienneLettres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxMot
            // 
            this.tbxMot.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMot.Location = new System.Drawing.Point(12, 12);
            this.tbxMot.Name = "tbxMot";
            this.tbxMot.ReadOnly = true;
            this.tbxMot.Size = new System.Drawing.Size(244, 42);
            this.tbxMot.TabIndex = 0;
            this.tbxMot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLettre
            // 
            this.tbxLettre.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLettre.Location = new System.Drawing.Point(244, 88);
            this.tbxLettre.MaxLength = 1;
            this.tbxLettre.Name = "tbxLettre";
            this.tbxLettre.Size = new System.Drawing.Size(46, 42);
            this.tbxLettre.TabIndex = 1;
            this.tbxLettre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jouez une lettre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vies : ";
            // 
            // lblVies
            // 
            this.lblVies.AutoSize = true;
            this.lblVies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVies.ForeColor = System.Drawing.Color.DarkRed;
            this.lblVies.Location = new System.Drawing.Point(335, 21);
            this.lblVies.Name = "lblVies";
            this.lblVies.Size = new System.Drawing.Size(0, 24);
            this.lblVies.TabIndex = 4;
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(99, 159);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(157, 40);
            this.btnJouer.TabIndex = 5;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(12, 288);
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ReadOnly = true;
            this.tbxResultat.Size = new System.Drawing.Size(323, 20);
            this.tbxResultat.TabIndex = 6;
            // 
            // tbxAncienneLettres
            // 
            this.tbxAncienneLettres.Location = new System.Drawing.Point(12, 248);
            this.tbxAncienneLettres.Name = "tbxAncienneLettres";
            this.tbxAncienneLettres.ReadOnly = true;
            this.tbxAncienneLettres.Size = new System.Drawing.Size(323, 20);
            this.tbxAncienneLettres.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 318);
            this.Controls.Add(this.tbxAncienneLettres);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.lblVies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLettre);
            this.Controls.Add(this.tbxMot);
            this.Name = "Form1";
            this.Text = "Jeu du Pendu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMot;
        private System.Windows.Forms.TextBox tbxLettre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVies;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.TextBox tbxResultat;
        private System.Windows.Forms.TextBox tbxAncienneLettres;
    }
}

