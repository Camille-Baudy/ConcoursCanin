namespace ConcoursCanin
{
    partial class FormConcours
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.con_lbl_code = new System.Windows.Forms.Label();
            this.con_txb_date = new System.Windows.Forms.TextBox();
            this.con_btn_ajouter = new System.Windows.Forms.Button();
            this.con_btn_Suppr = new System.Windows.Forms.Button();
            this.con_btn_modifier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.con_txb_ville = new System.Windows.Forms.TextBox();
            this.con_txb_salle = new System.Windows.Forms.TextBox();
            this.con_txb_cp = new System.Windows.Forms.TextBox();
            this.con_txb_adresse = new System.Windows.Forms.TextBox();
            this.con_txb_code = new System.Windows.Forms.TextBox();
            this.bdgSourceConcours = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceParticiper = new System.Windows.Forms.BindingSource(this.components);
            this.btn_return = new System.Windows.Forms.Button();
            this.dgv_Concours = new System.Windows.Forms.DataGridView();
            this.cONCOURBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cONCOURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.con_btn_annuler = new System.Windows.Forms.Button();
            this.pARTICIPEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cONCOURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceConcours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceParticiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "LES CONCOURS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.con_lbl_code);
            this.groupBox1.Controls.Add(this.con_txb_date);
            this.groupBox1.Controls.Add(this.con_btn_ajouter);
            this.groupBox1.Controls.Add(this.con_btn_Suppr);
            this.groupBox1.Controls.Add(this.con_btn_modifier);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.con_txb_ville);
            this.groupBox1.Controls.Add(this.con_txb_salle);
            this.groupBox1.Controls.Add(this.con_txb_cp);
            this.groupBox1.Controls.Add(this.con_txb_adresse);
            this.groupBox1.Controls.Add(this.con_txb_code);
            this.groupBox1.Location = new System.Drawing.Point(295, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(433, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter / Modifier / Supprimer un Concours";
            // 
            // con_lbl_code
            // 
            this.con_lbl_code.AutoSize = true;
            this.con_lbl_code.Location = new System.Drawing.Point(161, 43);
            this.con_lbl_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.con_lbl_code.Name = "con_lbl_code";
            this.con_lbl_code.Size = new System.Drawing.Size(41, 17);
            this.con_lbl_code.TabIndex = 15;
            this.con_lbl_code.Text = "Code";
            // 
            // con_txb_date
            // 
            this.con_txb_date.Location = new System.Drawing.Point(156, 137);
            this.con_txb_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_date.Name = "con_txb_date";
            this.con_txb_date.Size = new System.Drawing.Size(220, 22);
            this.con_txb_date.TabIndex = 14;
            // 
            // con_btn_ajouter
            // 
            this.con_btn_ajouter.Location = new System.Drawing.Point(8, 244);
            this.con_btn_ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_btn_ajouter.Name = "con_btn_ajouter";
            this.con_btn_ajouter.Size = new System.Drawing.Size(100, 28);
            this.con_btn_ajouter.TabIndex = 13;
            this.con_btn_ajouter.Text = "Ajouter";
            this.con_btn_ajouter.UseVisualStyleBackColor = true;
            this.con_btn_ajouter.Click += new System.EventHandler(this.con_btn_ajouter_Click);
            // 
            // con_btn_Suppr
            // 
            this.con_btn_Suppr.Location = new System.Drawing.Point(325, 244);
            this.con_btn_Suppr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_btn_Suppr.Name = "con_btn_Suppr";
            this.con_btn_Suppr.Size = new System.Drawing.Size(100, 28);
            this.con_btn_Suppr.TabIndex = 12;
            this.con_btn_Suppr.Text = "Supprimer";
            this.con_btn_Suppr.UseVisualStyleBackColor = true;
            this.con_btn_Suppr.Click += new System.EventHandler(this.con_btn_Suppr_Click);
            // 
            // con_btn_modifier
            // 
            this.con_btn_modifier.Location = new System.Drawing.Point(167, 244);
            this.con_btn_modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_btn_modifier.Name = "con_btn_modifier";
            this.con_btn_modifier.Size = new System.Drawing.Size(100, 28);
            this.con_btn_modifier.TabIndex = 3;
            this.con_btn_modifier.Text = "Modifier";
            this.con_btn_modifier.UseVisualStyleBackColor = true;
            this.con_btn_modifier.Click += new System.EventHandler(this.con_btn_modifier_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salle :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code Postal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code :";
            // 
            // con_txb_ville
            // 
            this.con_txb_ville.Location = new System.Drawing.Point(156, 199);
            this.con_txb_ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_ville.Name = "con_txb_ville";
            this.con_txb_ville.Size = new System.Drawing.Size(220, 22);
            this.con_txb_ville.TabIndex = 5;
            // 
            // con_txb_salle
            // 
            this.con_txb_salle.Location = new System.Drawing.Point(156, 169);
            this.con_txb_salle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_salle.Name = "con_txb_salle";
            this.con_txb_salle.Size = new System.Drawing.Size(220, 22);
            this.con_txb_salle.TabIndex = 4;
            // 
            // con_txb_cp
            // 
            this.con_txb_cp.Location = new System.Drawing.Point(156, 105);
            this.con_txb_cp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_cp.Name = "con_txb_cp";
            this.con_txb_cp.Size = new System.Drawing.Size(220, 22);
            this.con_txb_cp.TabIndex = 2;
            // 
            // con_txb_adresse
            // 
            this.con_txb_adresse.Location = new System.Drawing.Point(156, 71);
            this.con_txb_adresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_adresse.Name = "con_txb_adresse";
            this.con_txb_adresse.Size = new System.Drawing.Size(220, 22);
            this.con_txb_adresse.TabIndex = 1;
            // 
            // con_txb_code
            // 
            this.con_txb_code.Location = new System.Drawing.Point(156, 39);
            this.con_txb_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_txb_code.Name = "con_txb_code";
            this.con_txb_code.Size = new System.Drawing.Size(220, 22);
            this.con_txb_code.TabIndex = 0;
            // 
            // bdgSourceConcours
            // 
            this.bdgSourceConcours.DataMember = "CONCOURS";
            // 
            // bdgSourceParticiper
            // 
            this.bdgSourceParticiper.DataMember = "PARTICIPE";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(951, 511);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(100, 28);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "Retour";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // dgv_Concours
            // 
            this.dgv_Concours.AutoGenerateColumns = false;
            this.dgv_Concours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Concours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgv_Concours.DataSource = this.cONCOURSBindingSource;
            this.dgv_Concours.Location = new System.Drawing.Point(16, 55);
            this.dgv_Concours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Concours.Name = "dgv_Concours";
            this.dgv_Concours.Size = new System.Drawing.Size(1035, 185);
            this.dgv_Concours.TabIndex = 8;
            this.dgv_Concours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Concours_CellContentClick);
            // 
            // con_btn_annuler
            // 
            this.con_btn_annuler.Location = new System.Drawing.Point(736, 260);
            this.con_btn_annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.con_btn_annuler.Name = "con_btn_annuler";
            this.con_btn_annuler.Size = new System.Drawing.Size(100, 28);
            this.con_btn_annuler.TabIndex = 9;
            this.con_btn_annuler.Text = "Annuler";
            this.con_btn_annuler.UseVisualStyleBackColor = true;
            this.con_btn_annuler.Click += new System.EventHandler(this.con_btn_annuler_Click);
            // 
            // pARTICIPEBindingSource1
            // 
            this.pARTICIPEBindingSource1.DataSource = typeof(ConcoursCanin.PARTICIPE);
            // 
            // cONCOURSBindingSource
            // 
            this.cONCOURSBindingSource.DataSource = typeof(ConcoursCanin.CONCOURS);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codeconcours";
            this.dataGridViewTextBoxColumn7.HeaderText = "Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "adresseconcours";
            this.dataGridViewTextBoxColumn8.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cpconcours";
            this.dataGridViewTextBoxColumn9.HeaderText = "Code Postal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dateconcours";
            this.dataGridViewTextBoxColumn10.HeaderText = "Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "salleconcours";
            this.dataGridViewTextBoxColumn11.HeaderText = "Salle";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "villeconcours";
            this.dataGridViewTextBoxColumn12.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormConcours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.con_btn_annuler);
            this.Controls.Add(this.dgv_Concours);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConcours";
            this.Text = "Concours";
            this.Load += new System.EventHandler(this.FormConcours_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceConcours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceParticiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONCOURSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox con_txb_ville;
        private System.Windows.Forms.TextBox con_txb_salle;
        private System.Windows.Forms.TextBox con_txb_cp;
        private System.Windows.Forms.TextBox con_txb_adresse;
        private System.Windows.Forms.TextBox con_txb_code;
        private System.Windows.Forms.Button con_btn_ajouter;
        private System.Windows.Forms.Button con_btn_Suppr;
        private System.Windows.Forms.Button con_btn_modifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdgSourceConcours;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeconcoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgSourceParticiper;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeconcoursDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.BindingSource cONCOURBindingSource;
        private System.Windows.Forms.BindingSource pARTICIPEBindingSource1;
        private System.Windows.Forms.DataGridView dgv_Concours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource cONCOURBindingSource1;
        private System.Windows.Forms.TextBox con_txb_date;
        private System.Windows.Forms.Label con_lbl_code;
        private System.Windows.Forms.Button con_btn_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource cONCOURSBindingSource;
    }
}