
namespace encrypDecript
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChiffrer = new System.Windows.Forms.Button();
            this.tbxCle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHach = new System.Windows.Forms.Label();
            this.btnDechiffrer = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clé a utliser pour chiffrer";
            // 
            // btnChiffrer
            // 
            this.btnChiffrer.Location = new System.Drawing.Point(124, 339);
            this.btnChiffrer.Name = "btnChiffrer";
            this.btnChiffrer.Size = new System.Drawing.Size(75, 23);
            this.btnChiffrer.TabIndex = 1;
            this.btnChiffrer.Text = "Chiffrer";
            this.btnChiffrer.UseVisualStyleBackColor = true;
            this.btnChiffrer.Click += new System.EventHandler(this.btnChiffrer_Click);
            // 
            // tbxCle
            // 
            this.tbxCle.Location = new System.Drawing.Point(243, 40);
            this.tbxCle.Name = "tbxCle";
            this.tbxCle.Size = new System.Drawing.Size(100, 20);
            this.tbxCle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hach generer :";
            // 
            // lblHach
            // 
            this.lblHach.AutoSize = true;
            this.lblHach.Location = new System.Drawing.Point(182, 101);
            this.lblHach.Name = "lblHach";
            this.lblHach.Size = new System.Drawing.Size(35, 13);
            this.lblHach.TabIndex = 4;
            this.lblHach.Text = "label3";
            // 
            // btnDechiffrer
            // 
            this.btnDechiffrer.Location = new System.Drawing.Point(268, 339);
            this.btnDechiffrer.Name = "btnDechiffrer";
            this.btnDechiffrer.Size = new System.Drawing.Size(75, 23);
            this.btnDechiffrer.TabIndex = 5;
            this.btnDechiffrer.Text = "Dechiffrer";
            this.btnDechiffrer.UseVisualStyleBackColor = true;
            this.btnDechiffrer.Click += new System.EventHandler(this.btnDechiffrer_Click);
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(367, 29);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(121, 31);
            this.btnGenerer.TabIndex = 6;
            this.btnGenerer.Text = "generer un hach";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(100, 147);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(377, 149);
            this.tbxText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnDechiffrer);
            this.Controls.Add(this.lblHach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCle);
            this.Controls.Add(this.btnChiffrer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChiffrer;
        private System.Windows.Forms.TextBox tbxCle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHach;
        private System.Windows.Forms.Button btnDechiffrer;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.TextBox tbxText;
    }
}

