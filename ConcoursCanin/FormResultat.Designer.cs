namespace ConcoursCanin
{
    partial class FormResultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.res_cbx_concours = new System.Windows.Forms.ComboBox();
            this.dgv_participer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.res_btn_voirChien = new System.Windows.Forms.Button();
            this.res_btn_annuler = new System.Windows.Forms.Button();
            this.res_cbx_chien = new System.Windows.Forms.ComboBox();
            this.res_cbx_proprietaire = new System.Windows.Forms.ComboBox();
            this.res_btn_valider = new System.Windows.Forms.Button();
            this.res_txb_note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.res_btn_voir = new System.Windows.Forms.Button();
            this.res_txb_pCode = new System.Windows.Forms.TextBox();
            this.res_btn_modif = new System.Windows.Forms.Button();
            this.res_lbl_proprio = new System.Windows.Forms.Label();
            this.res_lbl_chien = new System.Windows.Forms.Label();
            this.codeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codechienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceParticiper = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_participer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceParticiper)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(713, 415);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Retour";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "LES RESULTATS";
            // 
            // res_cbx_concours
            // 
            this.res_cbx_concours.FormattingEnabled = true;
            this.res_cbx_concours.Location = new System.Drawing.Point(15, 54);
            this.res_cbx_concours.Name = "res_cbx_concours";
            this.res_cbx_concours.Size = new System.Drawing.Size(91, 21);
            this.res_cbx_concours.TabIndex = 10;
            // 
            // dgv_participer
            // 
            this.dgv_participer.AutoGenerateColumns = false;
            this.dgv_participer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_participer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproprietaireDataGridViewTextBoxColumn,
            this.codechienDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgv_participer.DataSource = this.bdgSourceParticiper;
            this.dgv_participer.Location = new System.Drawing.Point(15, 104);
            this.dgv_participer.Name = "dgv_participer";
            this.dgv_participer.Size = new System.Drawing.Size(458, 316);
            this.dgv_participer.TabIndex = 11;
            this.dgv_participer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_participer_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res_lbl_chien);
            this.groupBox1.Controls.Add(this.res_lbl_proprio);
            this.groupBox1.Controls.Add(this.res_btn_modif);
            this.groupBox1.Controls.Add(this.res_btn_voirChien);
            this.groupBox1.Controls.Add(this.res_btn_annuler);
            this.groupBox1.Controls.Add(this.res_cbx_chien);
            this.groupBox1.Controls.Add(this.res_cbx_proprietaire);
            this.groupBox1.Controls.Add(this.res_btn_valider);
            this.groupBox1.Controls.Add(this.res_txb_note);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(515, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 276);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOTE ATTRIBUEE";
            // 
            // res_btn_voirChien
            // 
            this.res_btn_voirChien.Location = new System.Drawing.Point(75, 65);
            this.res_btn_voirChien.Name = "res_btn_voirChien";
            this.res_btn_voirChien.Size = new System.Drawing.Size(107, 23);
            this.res_btn_voirChien.TabIndex = 29;
            this.res_btn_voirChien.Text = "Voir les chiens";
            this.res_btn_voirChien.UseVisualStyleBackColor = true;
            this.res_btn_voirChien.Click += new System.EventHandler(this.res_btn_voirChien_Click);
            // 
            // res_btn_annuler
            // 
            this.res_btn_annuler.Location = new System.Drawing.Point(9, 241);
            this.res_btn_annuler.Name = "res_btn_annuler";
            this.res_btn_annuler.Size = new System.Drawing.Size(238, 23);
            this.res_btn_annuler.TabIndex = 28;
            this.res_btn_annuler.Text = "Annuler";
            this.res_btn_annuler.UseVisualStyleBackColor = true;
            this.res_btn_annuler.Click += new System.EventHandler(this.res_btn_annuler_Click);
            // 
            // res_cbx_chien
            // 
            this.res_cbx_chien.FormattingEnabled = true;
            this.res_cbx_chien.Location = new System.Drawing.Point(81, 101);
            this.res_cbx_chien.Name = "res_cbx_chien";
            this.res_cbx_chien.Size = new System.Drawing.Size(166, 21);
            this.res_cbx_chien.TabIndex = 27;
            // 
            // res_cbx_proprietaire
            // 
            this.res_cbx_proprietaire.FormattingEnabled = true;
            this.res_cbx_proprietaire.Location = new System.Drawing.Point(81, 28);
            this.res_cbx_proprietaire.Name = "res_cbx_proprietaire";
            this.res_cbx_proprietaire.Size = new System.Drawing.Size(166, 21);
            this.res_cbx_proprietaire.TabIndex = 15;
            // 
            // res_btn_valider
            // 
            this.res_btn_valider.Location = new System.Drawing.Point(9, 202);
            this.res_btn_valider.Name = "res_btn_valider";
            this.res_btn_valider.Size = new System.Drawing.Size(238, 23);
            this.res_btn_valider.TabIndex = 26;
            this.res_btn_valider.Text = "Valider";
            this.res_btn_valider.UseVisualStyleBackColor = true;
            this.res_btn_valider.Click += new System.EventHandler(this.res_btn_valider_Click);
            // 
            // res_txb_note
            // 
            this.res_txb_note.Location = new System.Drawing.Point(81, 146);
            this.res_txb_note.Name = "res_txb_note";
            this.res_txb_note.Size = new System.Drawing.Size(166, 20);
            this.res_txb_note.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Note :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chien :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Propriétaire :";
            // 
            // res_btn_voir
            // 
            this.res_btn_voir.Location = new System.Drawing.Point(112, 54);
            this.res_btn_voir.Name = "res_btn_voir";
            this.res_btn_voir.Size = new System.Drawing.Size(39, 23);
            this.res_btn_voir.TabIndex = 14;
            this.res_btn_voir.Text = "Voir";
            this.res_btn_voir.UseVisualStyleBackColor = true;
            this.res_btn_voir.Click += new System.EventHandler(this.res_btn_voir_Click);
            // 
            // res_txb_pCode
            // 
            this.res_txb_pCode.Location = new System.Drawing.Point(515, 400);
            this.res_txb_pCode.Name = "res_txb_pCode";
            this.res_txb_pCode.Size = new System.Drawing.Size(166, 20);
            this.res_txb_pCode.TabIndex = 26;
            // 
            // res_btn_modif
            // 
            this.res_btn_modif.Location = new System.Drawing.Point(9, 202);
            this.res_btn_modif.Name = "res_btn_modif";
            this.res_btn_modif.Size = new System.Drawing.Size(238, 23);
            this.res_btn_modif.TabIndex = 30;
            this.res_btn_modif.Text = "Modifier";
            this.res_btn_modif.UseVisualStyleBackColor = true;
            this.res_btn_modif.Click += new System.EventHandler(this.res_btn_modif_Click);
            // 
            // res_lbl_proprio
            // 
            this.res_lbl_proprio.AutoSize = true;
            this.res_lbl_proprio.Location = new System.Drawing.Point(83, 32);
            this.res_lbl_proprio.Name = "res_lbl_proprio";
            this.res_lbl_proprio.Size = new System.Drawing.Size(60, 13);
            this.res_lbl_proprio.TabIndex = 31;
            this.res_lbl_proprio.Text = "Propriétaire";
            // 
            // res_lbl_chien
            // 
            this.res_lbl_chien.AutoSize = true;
            this.res_lbl_chien.Location = new System.Drawing.Point(83, 105);
            this.res_lbl_chien.Name = "res_lbl_chien";
            this.res_lbl_chien.Size = new System.Drawing.Size(34, 13);
            this.res_lbl_chien.TabIndex = 32;
            this.res_lbl_chien.Text = "Chien";
            // 
            // codeproprietaireDataGridViewTextBoxColumn
            // 
            this.codeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.Name = "codeproprietaireDataGridViewTextBoxColumn";
            // 
            // codechienDataGridViewTextBoxColumn
            // 
            this.codechienDataGridViewTextBoxColumn.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn.HeaderText = "Chien";
            this.codechienDataGridViewTextBoxColumn.Name = "codechienDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // bdgSourceParticiper
            // 
            this.bdgSourceParticiper.DataSource = typeof(ConcoursCanin.PARTICIPE);
            // 
            // FormResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res_txb_pCode);
            this.Controls.Add(this.res_btn_voir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_participer);
            this.Controls.Add(this.res_cbx_concours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Name = "FormResultat";
            this.Text = "Resultat";
            this.Load += new System.EventHandler(this.FormResultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_participer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceParticiper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox res_cbx_concours;
        private System.Windows.Forms.DataGridView dgv_participer;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgSourceParticiper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button res_btn_valider;
        private System.Windows.Forms.TextBox res_txb_note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button res_btn_voir;
        private System.Windows.Forms.ComboBox res_cbx_chien;
        private System.Windows.Forms.ComboBox res_cbx_proprietaire;
        private System.Windows.Forms.Button res_btn_annuler;
        private System.Windows.Forms.TextBox res_txb_pCode;
        private System.Windows.Forms.Button res_btn_voirChien;
        private System.Windows.Forms.Button res_btn_modif;
        private System.Windows.Forms.Label res_lbl_proprio;
        private System.Windows.Forms.Label res_lbl_chien;
    }
}