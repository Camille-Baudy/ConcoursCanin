namespace ConcoursCanin
{
    partial class FormChien
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
            this.ch_dgv_chiens = new System.Windows.Forms.DataGridView();
            this.codechienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeproprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddnchienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomchienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceChien = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.ch_btn_voirRace = new System.Windows.Forms.Button();
            this.ch_btn_voirBatard = new System.Windows.Forms.Button();
            this.ch_btn_voirTous = new System.Windows.Forms.Button();
            this.ch_dgv_batard = new System.Windows.Forms.DataGridView();
            this.codechienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeproprietaireDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristiquesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceBatard = new System.Windows.Forms.BindingSource(this.components);
            this.ch_dgv_race = new System.Windows.Forms.DataGridView();
            this.codechienDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeproprietaireDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceRace = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_BATARD_lbl_proprio = new System.Windows.Forms.Label();
            this.ch_BATARD_btn_annuler = new System.Windows.Forms.Button();
            this.ch_BATARD_btn_suppr = new System.Windows.Forms.Button();
            this.ch_BATARD_btn_modif = new System.Windows.Forms.Button();
            this.ch_BATARD_btn_add = new System.Windows.Forms.Button();
            this.ch_BATARD_txb_nomChien = new System.Windows.Forms.TextBox();
            this.ch_BATARD_lbl_TITRE_nomChien = new System.Windows.Forms.Label();
            this.ch_BATARD_txb_ddn = new System.Windows.Forms.TextBox();
            this.ch_BATARD_lbl_TITRE_ddn = new System.Windows.Forms.Label();
            this.ch_BATARD_txb_caract = new System.Windows.Forms.TextBox();
            this.ch_BATARD_lbl_TITRE_carateristique = new System.Windows.Forms.Label();
            this.ch_BATARD_cbx_proprio = new System.Windows.Forms.ComboBox();
            this.ch_BATARD_lbl_TITRE_proprio = new System.Windows.Forms.Label();
            this.ch_BATARD_lbl_codeChien = new System.Windows.Forms.Label();
            this.ch_BATARD_txb_codeChien = new System.Windows.Forms.TextBox();
            this.ch_BATARD_lbl_TITRE_codeChien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ch_RACE_lbl_proprio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ch_RACE_txb_robe = new System.Windows.Forms.TextBox();
            this.ch_RACE_btn_annuler = new System.Windows.Forms.Button();
            this.ch_RACE_btn_suppr = new System.Windows.Forms.Button();
            this.ch_RACE_btn_modif = new System.Windows.Forms.Button();
            this.ch_RACE_btn_add = new System.Windows.Forms.Button();
            this.ch_RACE_txb_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_RACE_txb_ddn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ch_RACE_txb_race = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_RACE_cbx_proprio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ch_RACE_lbl_codeChien = new System.Windows.Forms.Label();
            this.ch_RACE_txb_codeChien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_chiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceChien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_batard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceBatard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_race)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ch_dgv_chiens
            // 
            this.ch_dgv_chiens.AutoGenerateColumns = false;
            this.ch_dgv_chiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ch_dgv_chiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codechienDataGridViewTextBoxColumn,
            this.codeproprietaireDataGridViewTextBoxColumn,
            this.ddnchienDataGridViewTextBoxColumn,
            this.nomchienDataGridViewTextBoxColumn});
            this.ch_dgv_chiens.DataSource = this.bdgSourceChien;
            this.ch_dgv_chiens.Location = new System.Drawing.Point(12, 38);
            this.ch_dgv_chiens.Name = "ch_dgv_chiens";
            this.ch_dgv_chiens.Size = new System.Drawing.Size(776, 175);
            this.ch_dgv_chiens.TabIndex = 0;
            // 
            // codechienDataGridViewTextBoxColumn
            // 
            this.codechienDataGridViewTextBoxColumn.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codechienDataGridViewTextBoxColumn.Name = "codechienDataGridViewTextBoxColumn";
            // 
            // codeproprietaireDataGridViewTextBoxColumn
            // 
            this.codeproprietaireDataGridViewTextBoxColumn.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn.HeaderText = "Propriétaire";
            this.codeproprietaireDataGridViewTextBoxColumn.Name = "codeproprietaireDataGridViewTextBoxColumn";
            // 
            // ddnchienDataGridViewTextBoxColumn
            // 
            this.ddnchienDataGridViewTextBoxColumn.DataPropertyName = "ddnchien";
            this.ddnchienDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.ddnchienDataGridViewTextBoxColumn.Name = "ddnchienDataGridViewTextBoxColumn";
            // 
            // nomchienDataGridViewTextBoxColumn
            // 
            this.nomchienDataGridViewTextBoxColumn.DataPropertyName = "nomchien";
            this.nomchienDataGridViewTextBoxColumn.HeaderText = "Nom du chien";
            this.nomchienDataGridViewTextBoxColumn.Name = "nomchienDataGridViewTextBoxColumn";
            // 
            // bdgSourceChien
            // 
            this.bdgSourceChien.DataSource = typeof(ConcoursCanin.CHIEN);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LES CHIENS";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(723, 417);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Retour";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ch_btn_voirRace
            // 
            this.ch_btn_voirRace.Location = new System.Drawing.Point(518, 9);
            this.ch_btn_voirRace.Name = "ch_btn_voirRace";
            this.ch_btn_voirRace.Size = new System.Drawing.Size(132, 23);
            this.ch_btn_voirRace.TabIndex = 9;
            this.ch_btn_voirRace.Text = "Voir les chiens de Race";
            this.ch_btn_voirRace.UseVisualStyleBackColor = true;
            this.ch_btn_voirRace.Click += new System.EventHandler(this.ch_btn_voirRace_Click);
            // 
            // ch_btn_voirBatard
            // 
            this.ch_btn_voirBatard.Location = new System.Drawing.Point(380, 9);
            this.ch_btn_voirBatard.Name = "ch_btn_voirBatard";
            this.ch_btn_voirBatard.Size = new System.Drawing.Size(132, 23);
            this.ch_btn_voirBatard.TabIndex = 10;
            this.ch_btn_voirBatard.Text = "Voir les chiens Batard";
            this.ch_btn_voirBatard.UseVisualStyleBackColor = true;
            this.ch_btn_voirBatard.Click += new System.EventHandler(this.ch_btn_voirBatard_Click);
            // 
            // ch_btn_voirTous
            // 
            this.ch_btn_voirTous.Location = new System.Drawing.Point(656, 9);
            this.ch_btn_voirTous.Name = "ch_btn_voirTous";
            this.ch_btn_voirTous.Size = new System.Drawing.Size(132, 23);
            this.ch_btn_voirTous.TabIndex = 11;
            this.ch_btn_voirTous.Text = "Voir tous les chiens";
            this.ch_btn_voirTous.UseVisualStyleBackColor = true;
            this.ch_btn_voirTous.Click += new System.EventHandler(this.ch_btn_voirTous_Click);
            // 
            // ch_dgv_batard
            // 
            this.ch_dgv_batard.AutoGenerateColumns = false;
            this.ch_dgv_batard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ch_dgv_batard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codechienDataGridViewTextBoxColumn1,
            this.codeproprietaireDataGridViewTextBoxColumn1,
            this.caracteristiquesDataGridViewTextBoxColumn});
            this.ch_dgv_batard.DataSource = this.bdgSourceBatard;
            this.ch_dgv_batard.Location = new System.Drawing.Point(12, 38);
            this.ch_dgv_batard.Name = "ch_dgv_batard";
            this.ch_dgv_batard.Size = new System.Drawing.Size(776, 175);
            this.ch_dgv_batard.TabIndex = 12;
            this.ch_dgv_batard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ch_dgv_batard_CellContentClick);
            // 
            // codechienDataGridViewTextBoxColumn1
            // 
            this.codechienDataGridViewTextBoxColumn1.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codechienDataGridViewTextBoxColumn1.Name = "codechienDataGridViewTextBoxColumn1";
            // 
            // codeproprietaireDataGridViewTextBoxColumn1
            // 
            this.codeproprietaireDataGridViewTextBoxColumn1.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn1.HeaderText = "Propriétaire";
            this.codeproprietaireDataGridViewTextBoxColumn1.Name = "codeproprietaireDataGridViewTextBoxColumn1";
            // 
            // caracteristiquesDataGridViewTextBoxColumn
            // 
            this.caracteristiquesDataGridViewTextBoxColumn.DataPropertyName = "caracteristiques";
            this.caracteristiquesDataGridViewTextBoxColumn.HeaderText = "Caractéristiques";
            this.caracteristiquesDataGridViewTextBoxColumn.Name = "caracteristiquesDataGridViewTextBoxColumn";
            // 
            // bdgSourceBatard
            // 
            this.bdgSourceBatard.DataSource = typeof(ConcoursCanin.BATARD);
            // 
            // ch_dgv_race
            // 
            this.ch_dgv_race.AutoGenerateColumns = false;
            this.ch_dgv_race.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ch_dgv_race.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codechienDataGridViewTextBoxColumn2,
            this.codeproprietaireDataGridViewTextBoxColumn2,
            this.raceDataGridViewTextBoxColumn,
            this.robeDataGridViewTextBoxColumn});
            this.ch_dgv_race.DataSource = this.bdgSourceRace;
            this.ch_dgv_race.Location = new System.Drawing.Point(12, 38);
            this.ch_dgv_race.Name = "ch_dgv_race";
            this.ch_dgv_race.Size = new System.Drawing.Size(776, 175);
            this.ch_dgv_race.TabIndex = 13;
            this.ch_dgv_race.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ch_dgv_race_CellContentClick);
            // 
            // codechienDataGridViewTextBoxColumn2
            // 
            this.codechienDataGridViewTextBoxColumn2.DataPropertyName = "codechien";
            this.codechienDataGridViewTextBoxColumn2.HeaderText = "Code";
            this.codechienDataGridViewTextBoxColumn2.Name = "codechienDataGridViewTextBoxColumn2";
            // 
            // codeproprietaireDataGridViewTextBoxColumn2
            // 
            this.codeproprietaireDataGridViewTextBoxColumn2.DataPropertyName = "codeproprietaire";
            this.codeproprietaireDataGridViewTextBoxColumn2.HeaderText = "Propriétaire";
            this.codeproprietaireDataGridViewTextBoxColumn2.Name = "codeproprietaireDataGridViewTextBoxColumn2";
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            // 
            // robeDataGridViewTextBoxColumn
            // 
            this.robeDataGridViewTextBoxColumn.DataPropertyName = "robe";
            this.robeDataGridViewTextBoxColumn.HeaderText = "Robe";
            this.robeDataGridViewTextBoxColumn.Name = "robeDataGridViewTextBoxColumn";
            // 
            // bdgSourceRace
            // 
            this.bdgSourceRace.DataSource = typeof(ConcoursCanin.DERACE);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_proprio);
            this.groupBox1.Controls.Add(this.ch_BATARD_btn_annuler);
            this.groupBox1.Controls.Add(this.ch_BATARD_btn_suppr);
            this.groupBox1.Controls.Add(this.ch_BATARD_btn_modif);
            this.groupBox1.Controls.Add(this.ch_BATARD_btn_add);
            this.groupBox1.Controls.Add(this.ch_BATARD_txb_nomChien);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_TITRE_nomChien);
            this.groupBox1.Controls.Add(this.ch_BATARD_txb_ddn);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_TITRE_ddn);
            this.groupBox1.Controls.Add(this.ch_BATARD_txb_caract);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_TITRE_carateristique);
            this.groupBox1.Controls.Add(this.ch_BATARD_cbx_proprio);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_TITRE_proprio);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_codeChien);
            this.groupBox1.Controls.Add(this.ch_BATARD_txb_codeChien);
            this.groupBox1.Controls.Add(this.ch_BATARD_lbl_TITRE_codeChien);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter / Modifer / Supprimer un Chien Batard";
            // 
            // ch_BATARD_lbl_proprio
            // 
            this.ch_BATARD_lbl_proprio.AutoSize = true;
            this.ch_BATARD_lbl_proprio.Location = new System.Drawing.Point(120, 66);
            this.ch_BATARD_lbl_proprio.Name = "ch_BATARD_lbl_proprio";
            this.ch_BATARD_lbl_proprio.Size = new System.Drawing.Size(60, 13);
            this.ch_BATARD_lbl_proprio.TabIndex = 16;
            this.ch_BATARD_lbl_proprio.Text = "Propriétaire";
            // 
            // ch_BATARD_btn_annuler
            // 
            this.ch_BATARD_btn_annuler.Location = new System.Drawing.Point(268, 147);
            this.ch_BATARD_btn_annuler.Name = "ch_BATARD_btn_annuler";
            this.ch_BATARD_btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.ch_BATARD_btn_annuler.TabIndex = 15;
            this.ch_BATARD_btn_annuler.Text = "Annuler";
            this.ch_BATARD_btn_annuler.UseVisualStyleBackColor = true;
            this.ch_BATARD_btn_annuler.Click += new System.EventHandler(this.ch_BATARD_btn_annuler_Click);
            // 
            // ch_BATARD_btn_suppr
            // 
            this.ch_BATARD_btn_suppr.Location = new System.Drawing.Point(268, 108);
            this.ch_BATARD_btn_suppr.Name = "ch_BATARD_btn_suppr";
            this.ch_BATARD_btn_suppr.Size = new System.Drawing.Size(75, 23);
            this.ch_BATARD_btn_suppr.TabIndex = 14;
            this.ch_BATARD_btn_suppr.Text = "Supprimer";
            this.ch_BATARD_btn_suppr.UseVisualStyleBackColor = true;
            this.ch_BATARD_btn_suppr.Click += new System.EventHandler(this.ch_BATARD_btn_suppr_Click);
            // 
            // ch_BATARD_btn_modif
            // 
            this.ch_BATARD_btn_modif.Location = new System.Drawing.Point(268, 70);
            this.ch_BATARD_btn_modif.Name = "ch_BATARD_btn_modif";
            this.ch_BATARD_btn_modif.Size = new System.Drawing.Size(75, 23);
            this.ch_BATARD_btn_modif.TabIndex = 13;
            this.ch_BATARD_btn_modif.Text = "Modifier";
            this.ch_BATARD_btn_modif.UseVisualStyleBackColor = true;
            this.ch_BATARD_btn_modif.Click += new System.EventHandler(this.ch_BATARD_btn_modif_Click_1);
            // 
            // ch_BATARD_btn_add
            // 
            this.ch_BATARD_btn_add.Location = new System.Drawing.Point(268, 33);
            this.ch_BATARD_btn_add.Name = "ch_BATARD_btn_add";
            this.ch_BATARD_btn_add.Size = new System.Drawing.Size(75, 23);
            this.ch_BATARD_btn_add.TabIndex = 12;
            this.ch_BATARD_btn_add.Text = "Ajouter";
            this.ch_BATARD_btn_add.UseVisualStyleBackColor = true;
            this.ch_BATARD_btn_add.Click += new System.EventHandler(this.ch_BATARD_btn_add_Click);
            // 
            // ch_BATARD_txb_nomChien
            // 
            this.ch_BATARD_txb_nomChien.Location = new System.Drawing.Point(117, 150);
            this.ch_BATARD_txb_nomChien.Name = "ch_BATARD_txb_nomChien";
            this.ch_BATARD_txb_nomChien.Size = new System.Drawing.Size(121, 20);
            this.ch_BATARD_txb_nomChien.TabIndex = 11;
            // 
            // ch_BATARD_lbl_TITRE_nomChien
            // 
            this.ch_BATARD_lbl_TITRE_nomChien.AutoSize = true;
            this.ch_BATARD_lbl_TITRE_nomChien.Location = new System.Drawing.Point(7, 157);
            this.ch_BATARD_lbl_TITRE_nomChien.Name = "ch_BATARD_lbl_TITRE_nomChien";
            this.ch_BATARD_lbl_TITRE_nomChien.Size = new System.Drawing.Size(83, 13);
            this.ch_BATARD_lbl_TITRE_nomChien.TabIndex = 10;
            this.ch_BATARD_lbl_TITRE_nomChien.Text = "Nom du Chien : ";
            // 
            // ch_BATARD_txb_ddn
            // 
            this.ch_BATARD_txb_ddn.Location = new System.Drawing.Point(117, 121);
            this.ch_BATARD_txb_ddn.Name = "ch_BATARD_txb_ddn";
            this.ch_BATARD_txb_ddn.Size = new System.Drawing.Size(121, 20);
            this.ch_BATARD_txb_ddn.TabIndex = 9;
            // 
            // ch_BATARD_lbl_TITRE_ddn
            // 
            this.ch_BATARD_lbl_TITRE_ddn.AutoSize = true;
            this.ch_BATARD_lbl_TITRE_ddn.Location = new System.Drawing.Point(7, 128);
            this.ch_BATARD_lbl_TITRE_ddn.Name = "ch_BATARD_lbl_TITRE_ddn";
            this.ch_BATARD_lbl_TITRE_ddn.Size = new System.Drawing.Size(104, 13);
            this.ch_BATARD_lbl_TITRE_ddn.TabIndex = 8;
            this.ch_BATARD_lbl_TITRE_ddn.Text = "Date de Naissance :";
            // 
            // ch_BATARD_txb_caract
            // 
            this.ch_BATARD_txb_caract.Location = new System.Drawing.Point(117, 92);
            this.ch_BATARD_txb_caract.Name = "ch_BATARD_txb_caract";
            this.ch_BATARD_txb_caract.Size = new System.Drawing.Size(121, 20);
            this.ch_BATARD_txb_caract.TabIndex = 7;
            // 
            // ch_BATARD_lbl_TITRE_carateristique
            // 
            this.ch_BATARD_lbl_TITRE_carateristique.AutoSize = true;
            this.ch_BATARD_lbl_TITRE_carateristique.Location = new System.Drawing.Point(7, 99);
            this.ch_BATARD_lbl_TITRE_carateristique.Name = "ch_BATARD_lbl_TITRE_carateristique";
            this.ch_BATARD_lbl_TITRE_carateristique.Size = new System.Drawing.Size(83, 13);
            this.ch_BATARD_lbl_TITRE_carateristique.TabIndex = 6;
            this.ch_BATARD_lbl_TITRE_carateristique.Text = "Caractéristique :";
            // 
            // ch_BATARD_cbx_proprio
            // 
            this.ch_BATARD_cbx_proprio.FormattingEnabled = true;
            this.ch_BATARD_cbx_proprio.Location = new System.Drawing.Point(117, 62);
            this.ch_BATARD_cbx_proprio.Name = "ch_BATARD_cbx_proprio";
            this.ch_BATARD_cbx_proprio.Size = new System.Drawing.Size(121, 21);
            this.ch_BATARD_cbx_proprio.TabIndex = 5;
            // 
            // ch_BATARD_lbl_TITRE_proprio
            // 
            this.ch_BATARD_lbl_TITRE_proprio.AutoSize = true;
            this.ch_BATARD_lbl_TITRE_proprio.Location = new System.Drawing.Point(7, 70);
            this.ch_BATARD_lbl_TITRE_proprio.Name = "ch_BATARD_lbl_TITRE_proprio";
            this.ch_BATARD_lbl_TITRE_proprio.Size = new System.Drawing.Size(63, 13);
            this.ch_BATARD_lbl_TITRE_proprio.TabIndex = 4;
            this.ch_BATARD_lbl_TITRE_proprio.Text = "Propiétaire :";
            // 
            // ch_BATARD_lbl_codeChien
            // 
            this.ch_BATARD_lbl_codeChien.AutoSize = true;
            this.ch_BATARD_lbl_codeChien.Location = new System.Drawing.Point(119, 37);
            this.ch_BATARD_lbl_codeChien.Name = "ch_BATARD_lbl_codeChien";
            this.ch_BATARD_lbl_codeChien.Size = new System.Drawing.Size(76, 13);
            this.ch_BATARD_lbl_codeChien.TabIndex = 3;
            this.ch_BATARD_lbl_codeChien.Text = "Code du chien";
            // 
            // ch_BATARD_txb_codeChien
            // 
            this.ch_BATARD_txb_codeChien.Location = new System.Drawing.Point(117, 33);
            this.ch_BATARD_txb_codeChien.Name = "ch_BATARD_txb_codeChien";
            this.ch_BATARD_txb_codeChien.Size = new System.Drawing.Size(121, 20);
            this.ch_BATARD_txb_codeChien.TabIndex = 2;
            // 
            // ch_BATARD_lbl_TITRE_codeChien
            // 
            this.ch_BATARD_lbl_TITRE_codeChien.AutoSize = true;
            this.ch_BATARD_lbl_TITRE_codeChien.Location = new System.Drawing.Point(6, 40);
            this.ch_BATARD_lbl_TITRE_codeChien.Name = "ch_BATARD_lbl_TITRE_codeChien";
            this.ch_BATARD_lbl_TITRE_codeChien.Size = new System.Drawing.Size(83, 13);
            this.ch_BATARD_lbl_TITRE_codeChien.TabIndex = 1;
            this.ch_BATARD_lbl_TITRE_codeChien.Text = "Code du Chien :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ch_RACE_lbl_proprio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ch_RACE_txb_robe);
            this.groupBox2.Controls.Add(this.ch_RACE_btn_annuler);
            this.groupBox2.Controls.Add(this.ch_RACE_btn_suppr);
            this.groupBox2.Controls.Add(this.ch_RACE_btn_modif);
            this.groupBox2.Controls.Add(this.ch_RACE_btn_add);
            this.groupBox2.Controls.Add(this.ch_RACE_txb_nom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ch_RACE_txb_ddn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ch_RACE_txb_race);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ch_RACE_cbx_proprio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ch_RACE_lbl_codeChien);
            this.groupBox2.Controls.Add(this.ch_RACE_txb_codeChien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(380, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 204);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter / Modifer / Supprimer un Chien de Race";
            // 
            // ch_RACE_lbl_proprio
            // 
            this.ch_RACE_lbl_proprio.AutoSize = true;
            this.ch_RACE_lbl_proprio.Location = new System.Drawing.Point(119, 66);
            this.ch_RACE_lbl_proprio.Name = "ch_RACE_lbl_proprio";
            this.ch_RACE_lbl_proprio.Size = new System.Drawing.Size(60, 13);
            this.ch_RACE_lbl_proprio.TabIndex = 17;
            this.ch_RACE_lbl_proprio.Text = "Propriétaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Robe :";
            // 
            // ch_RACE_txb_robe
            // 
            this.ch_RACE_txb_robe.Location = new System.Drawing.Point(117, 121);
            this.ch_RACE_txb_robe.Name = "ch_RACE_txb_robe";
            this.ch_RACE_txb_robe.Size = new System.Drawing.Size(121, 20);
            this.ch_RACE_txb_robe.TabIndex = 16;
            // 
            // ch_RACE_btn_annuler
            // 
            this.ch_RACE_btn_annuler.Location = new System.Drawing.Point(268, 147);
            this.ch_RACE_btn_annuler.Name = "ch_RACE_btn_annuler";
            this.ch_RACE_btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.ch_RACE_btn_annuler.TabIndex = 15;
            this.ch_RACE_btn_annuler.Text = "Annuler";
            this.ch_RACE_btn_annuler.UseVisualStyleBackColor = true;
            this.ch_RACE_btn_annuler.Click += new System.EventHandler(this.ch_RACE_btn_annuler_Click);
            // 
            // ch_RACE_btn_suppr
            // 
            this.ch_RACE_btn_suppr.Location = new System.Drawing.Point(268, 108);
            this.ch_RACE_btn_suppr.Name = "ch_RACE_btn_suppr";
            this.ch_RACE_btn_suppr.Size = new System.Drawing.Size(75, 23);
            this.ch_RACE_btn_suppr.TabIndex = 14;
            this.ch_RACE_btn_suppr.Text = "Supprimer";
            this.ch_RACE_btn_suppr.UseVisualStyleBackColor = true;
            this.ch_RACE_btn_suppr.Click += new System.EventHandler(this.ch_RACE_btn_suppr_Click);
            // 
            // ch_RACE_btn_modif
            // 
            this.ch_RACE_btn_modif.Location = new System.Drawing.Point(268, 70);
            this.ch_RACE_btn_modif.Name = "ch_RACE_btn_modif";
            this.ch_RACE_btn_modif.Size = new System.Drawing.Size(75, 23);
            this.ch_RACE_btn_modif.TabIndex = 13;
            this.ch_RACE_btn_modif.Text = "Modifier";
            this.ch_RACE_btn_modif.UseVisualStyleBackColor = true;
            this.ch_RACE_btn_modif.Click += new System.EventHandler(this.ch_RACE_btn_modif_Click);
            // 
            // ch_RACE_btn_add
            // 
            this.ch_RACE_btn_add.Location = new System.Drawing.Point(268, 33);
            this.ch_RACE_btn_add.Name = "ch_RACE_btn_add";
            this.ch_RACE_btn_add.Size = new System.Drawing.Size(75, 23);
            this.ch_RACE_btn_add.TabIndex = 12;
            this.ch_RACE_btn_add.Text = "Ajouter";
            this.ch_RACE_btn_add.UseVisualStyleBackColor = true;
            this.ch_RACE_btn_add.Click += new System.EventHandler(this.ch_RACE_btn_add_Click);
            // 
            // ch_RACE_txb_nom
            // 
            this.ch_RACE_txb_nom.Location = new System.Drawing.Point(117, 176);
            this.ch_RACE_txb_nom.Name = "ch_RACE_txb_nom";
            this.ch_RACE_txb_nom.Size = new System.Drawing.Size(121, 20);
            this.ch_RACE_txb_nom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom du Chien : ";
            // 
            // ch_RACE_txb_ddn
            // 
            this.ch_RACE_txb_ddn.Location = new System.Drawing.Point(117, 147);
            this.ch_RACE_txb_ddn.Name = "ch_RACE_txb_ddn";
            this.ch_RACE_txb_ddn.Size = new System.Drawing.Size(121, 20);
            this.ch_RACE_txb_ddn.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date de Naissance :";
            // 
            // ch_RACE_txb_race
            // 
            this.ch_RACE_txb_race.Location = new System.Drawing.Point(117, 92);
            this.ch_RACE_txb_race.Name = "ch_RACE_txb_race";
            this.ch_RACE_txb_race.Size = new System.Drawing.Size(121, 20);
            this.ch_RACE_txb_race.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Race : ";
            // 
            // ch_RACE_cbx_proprio
            // 
            this.ch_RACE_cbx_proprio.FormattingEnabled = true;
            this.ch_RACE_cbx_proprio.Location = new System.Drawing.Point(117, 62);
            this.ch_RACE_cbx_proprio.Name = "ch_RACE_cbx_proprio";
            this.ch_RACE_cbx_proprio.Size = new System.Drawing.Size(121, 21);
            this.ch_RACE_cbx_proprio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Propiétaire :";
            // 
            // ch_RACE_lbl_codeChien
            // 
            this.ch_RACE_lbl_codeChien.AutoSize = true;
            this.ch_RACE_lbl_codeChien.Location = new System.Drawing.Point(119, 37);
            this.ch_RACE_lbl_codeChien.Name = "ch_RACE_lbl_codeChien";
            this.ch_RACE_lbl_codeChien.Size = new System.Drawing.Size(76, 13);
            this.ch_RACE_lbl_codeChien.TabIndex = 3;
            this.ch_RACE_lbl_codeChien.Text = "Code du chien";
            // 
            // ch_RACE_txb_codeChien
            // 
            this.ch_RACE_txb_codeChien.Location = new System.Drawing.Point(117, 33);
            this.ch_RACE_txb_codeChien.Name = "ch_RACE_txb_codeChien";
            this.ch_RACE_txb_codeChien.Size = new System.Drawing.Size(121, 20);
            this.ch_RACE_txb_codeChien.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Code du Chien :";
            // 
            // FormChien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ch_dgv_race);
            this.Controls.Add(this.ch_dgv_batard);
            this.Controls.Add(this.ch_btn_voirTous);
            this.Controls.Add(this.ch_btn_voirBatard);
            this.Controls.Add(this.ch_btn_voirRace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_dgv_chiens);
            this.Name = "FormChien";
            this.Text = "Chien";
            this.Load += new System.EventHandler(this.FormChien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_chiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceChien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_batard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceBatard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dgv_race)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ch_dgv_chiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddnchienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomchienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgSourceChien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button ch_btn_voirRace;
        private System.Windows.Forms.Button ch_btn_voirBatard;
        private System.Windows.Forms.Button ch_btn_voirTous;
        private System.Windows.Forms.DataGridView ch_dgv_batard;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristiquesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgSourceBatard;
        private System.Windows.Forms.DataGridView ch_dgv_race;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechienDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproprietaireDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgSourceRace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ch_BATARD_btn_annuler;
        private System.Windows.Forms.Button ch_BATARD_btn_suppr;
        private System.Windows.Forms.Button ch_BATARD_btn_modif;
        private System.Windows.Forms.Button ch_BATARD_btn_add;
        private System.Windows.Forms.TextBox ch_BATARD_txb_nomChien;
        private System.Windows.Forms.Label ch_BATARD_lbl_TITRE_nomChien;
        private System.Windows.Forms.TextBox ch_BATARD_txb_ddn;
        private System.Windows.Forms.Label ch_BATARD_lbl_TITRE_ddn;
        private System.Windows.Forms.TextBox ch_BATARD_txb_caract;
        private System.Windows.Forms.Label ch_BATARD_lbl_TITRE_carateristique;
        private System.Windows.Forms.ComboBox ch_BATARD_cbx_proprio;
        private System.Windows.Forms.Label ch_BATARD_lbl_TITRE_proprio;
        private System.Windows.Forms.Label ch_BATARD_lbl_codeChien;
        private System.Windows.Forms.TextBox ch_BATARD_txb_codeChien;
        private System.Windows.Forms.Label ch_BATARD_lbl_TITRE_codeChien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ch_RACE_txb_robe;
        private System.Windows.Forms.Button ch_RACE_btn_annuler;
        private System.Windows.Forms.Button ch_RACE_btn_suppr;
        private System.Windows.Forms.Button ch_RACE_btn_modif;
        private System.Windows.Forms.Button ch_RACE_btn_add;
        private System.Windows.Forms.TextBox ch_RACE_txb_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ch_RACE_txb_ddn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ch_RACE_txb_race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ch_RACE_cbx_proprio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ch_RACE_lbl_codeChien;
        private System.Windows.Forms.TextBox ch_RACE_txb_codeChien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ch_BATARD_lbl_proprio;
        private System.Windows.Forms.Label ch_RACE_lbl_proprio;
    }
}