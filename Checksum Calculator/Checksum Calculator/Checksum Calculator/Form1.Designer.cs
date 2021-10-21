
namespace Checksum_Calculator
{
    partial class frmchecksum
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
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.lblFichier = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(141, 101);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(217, 23);
            this.btnSelectionner.TabIndex = 0;
            this.btnSelectionner.Text = "Sélectionner un fichier";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // lblFichier
            // 
            this.lblFichier.AutoSize = true;
            this.lblFichier.Location = new System.Drawing.Point(138, 180);
            this.lblFichier.Name = "lblFichier";
            this.lblFichier.Size = new System.Drawing.Size(38, 13);
            this.lblFichier.TabIndex = 1;
            this.lblFichier.Text = "Fichier";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(138, 204);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(49, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Directory";
            // 
            // lblChecksum
            // 
            this.lblChecksum.AutoSize = true;
            this.lblChecksum.Location = new System.Drawing.Point(138, 290);
            this.lblChecksum.Name = "lblChecksum";
            this.lblChecksum.Size = new System.Drawing.Size(57, 13);
            this.lblChecksum.TabIndex = 3;
            this.lblChecksum.Text = "Checksum";
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(141, 321);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(217, 20);
            this.tbxOutput.TabIndex = 4;
            // 
            // frmchecksum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lblChecksum);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblFichier);
            this.Controls.Add(this.btnSelectionner);
            this.Name = "frmchecksum";
            this.Text = "Checksum calculator";
            this.Load += new System.EventHandler(this.frmchecksum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label lblChecksum;
        private System.Windows.Forms.TextBox tbxOutput;
    }
}

