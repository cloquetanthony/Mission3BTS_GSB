namespace gsbRapports
{
    partial class frmGererMedecin
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
            this.gbRechercheMedecin = new System.Windows.Forms.GroupBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmbDepartement = new System.Windows.Forms.ComboBox();
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.bdgSourceMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.dtgGererMedecin = new System.Windows.Forms.DataGridView();
            this.btnAjouterMedecin = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteComplementaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRechercheMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGererMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRechercheMedecin
            // 
            this.gbRechercheMedecin.Controls.Add(this.btnAjouterMedecin);
            this.gbRechercheMedecin.Controls.Add(this.btnSauvegarder);
            this.gbRechercheMedecin.Controls.Add(this.lblDepartement);
            this.gbRechercheMedecin.Controls.Add(this.lblNom);
            this.gbRechercheMedecin.Controls.Add(this.cmbDepartement);
            this.gbRechercheMedecin.Controls.Add(this.cmbNom);
            this.gbRechercheMedecin.Location = new System.Drawing.Point(12, 12);
            this.gbRechercheMedecin.Name = "gbRechercheMedecin";
            this.gbRechercheMedecin.Size = new System.Drawing.Size(744, 111);
            this.gbRechercheMedecin.TabIndex = 0;
            this.gbRechercheMedecin.TabStop = false;
            this.gbRechercheMedecin.Text = "Recherche spécifique";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(369, 65);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(317, 27);
            this.btnSauvegarder.TabIndex = 3;
            this.btnSauvegarder.Text = "Sauvegarder les modifications";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Location = new System.Drawing.Point(17, 72);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(74, 13);
            this.lblDepartement.TabIndex = 3;
            this.lblDepartement.Text = "Département :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(17, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // cmbDepartement
            // 
            this.cmbDepartement.DataSource = this.bdgSourceMedecin;
            this.cmbDepartement.DisplayMember = "departement";
            this.cmbDepartement.FormattingEnabled = true;
            this.cmbDepartement.Location = new System.Drawing.Point(114, 69);
            this.cmbDepartement.Name = "cmbDepartement";
            this.cmbDepartement.Size = new System.Drawing.Size(187, 21);
            this.cmbDepartement.TabIndex = 1;
            // 
            // cmbNom
            // 
            this.cmbNom.DataSource = this.bdgSourceMedecin;
            this.cmbNom.DisplayMember = "nom";
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(114, 31);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(187, 21);
            this.cmbNom.TabIndex = 0;
            // 
            // bdgSourceMedecin
            // 
            this.bdgSourceMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // dtgGererMedecin
            // 
            this.dtgGererMedecin.AllowUserToOrderColumns = true;
            this.dtgGererMedecin.AutoGenerateColumns = false;
            this.dtgGererMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGererMedecin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.specialiteComplementaireDataGridViewTextBoxColumn,
            this.departementDataGridViewTextBoxColumn});
            this.dtgGererMedecin.DataSource = this.bdgSourceMedecin;
            this.dtgGererMedecin.Location = new System.Drawing.Point(12, 129);
            this.dtgGererMedecin.Name = "dtgGererMedecin";
            this.dtgGererMedecin.Size = new System.Drawing.Size(744, 173);
            this.dtgGererMedecin.TabIndex = 1;
            this.dtgGererMedecin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGererMedecin_CellContentClick);
            // 
            // btnAjouterMedecin
            // 
            this.btnAjouterMedecin.Location = new System.Drawing.Point(369, 27);
            this.btnAjouterMedecin.Name = "btnAjouterMedecin";
            this.btnAjouterMedecin.Size = new System.Drawing.Size(317, 27);
            this.btnAjouterMedecin.TabIndex = 4;
            this.btnAjouterMedecin.Text = "Ajouter un médecin";
            this.btnAjouterMedecin.UseVisualStyleBackColor = true;
            this.btnAjouterMedecin.Click += new System.EventHandler(this.btnAjouterMedecin_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // specialiteComplementaireDataGridViewTextBoxColumn
            // 
            this.specialiteComplementaireDataGridViewTextBoxColumn.DataPropertyName = "specialiteComplementaire";
            this.specialiteComplementaireDataGridViewTextBoxColumn.HeaderText = "Spécialité";
            this.specialiteComplementaireDataGridViewTextBoxColumn.Name = "specialiteComplementaireDataGridViewTextBoxColumn";
            // 
            // departementDataGridViewTextBoxColumn
            // 
            this.departementDataGridViewTextBoxColumn.DataPropertyName = "departement";
            this.departementDataGridViewTextBoxColumn.HeaderText = "Département";
            this.departementDataGridViewTextBoxColumn.Name = "departementDataGridViewTextBoxColumn";
            // 
            // frmGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 314);
            this.Controls.Add(this.dtgGererMedecin);
            this.Controls.Add(this.gbRechercheMedecin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGererMedecin";
            this.Text = "Gérer les médecins  |  GSB";
            this.gbRechercheMedecin.ResumeLayout(false);
            this.gbRechercheMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGererMedecin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRechercheMedecin;
        private System.Windows.Forms.DataGridView dtgGererMedecin;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.ComboBox cmbDepartement;
        private System.Windows.Forms.ComboBox cmbNom;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.BindingSource bdgSourceMedecin;
        private System.Windows.Forms.Button btnAjouterMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteComplementaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departementDataGridViewTextBoxColumn;
    }
}