namespace ConcoursCanin
{
    partial class FormAccueil
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
            this.btn_formConcours = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_formResultat = new System.Windows.Forms.Button();
            this.btn_formChien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_formConcours
            // 
            this.btn_formConcours.Location = new System.Drawing.Point(159, 198);
            this.btn_formConcours.Name = "btn_formConcours";
            this.btn_formConcours.Size = new System.Drawing.Size(122, 67);
            this.btn_formConcours.TabIndex = 0;
            this.btn_formConcours.Text = "Voir les concours";
            this.btn_formConcours.UseVisualStyleBackColor = true;
            this.btn_formConcours.Click += new System.EventHandler(this.btn_formConcours_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(81, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue aux Concours Canins";
            // 
            // btn_formResultat
            // 
            this.btn_formResultat.Location = new System.Drawing.Point(333, 198);
            this.btn_formResultat.Name = "btn_formResultat";
            this.btn_formResultat.Size = new System.Drawing.Size(122, 67);
            this.btn_formResultat.TabIndex = 2;
            this.btn_formResultat.Text = "Voir les résultats";
            this.btn_formResultat.UseVisualStyleBackColor = true;
            this.btn_formResultat.Click += new System.EventHandler(this.btn_formResultat_Click);
            // 
            // btn_formChien
            // 
            this.btn_formChien.Location = new System.Drawing.Point(505, 198);
            this.btn_formChien.Name = "btn_formChien";
            this.btn_formChien.Size = new System.Drawing.Size(122, 67);
            this.btn_formChien.TabIndex = 3;
            this.btn_formChien.Text = "Voir les chiens";
            this.btn_formChien.UseVisualStyleBackColor = true;
            this.btn_formChien.Click += new System.EventHandler(this.btn_formChien_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_formChien);
            this.Controls.Add(this.btn_formResultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_formConcours);
            this.Name = "FormAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_formConcours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_formResultat;
        private System.Windows.Forms.Button btn_formChien;
    }
}

