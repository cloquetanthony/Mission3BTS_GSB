namespace gsbRapports
{
    partial class frmDernierRapportMedecin
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
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmbPrenom = new System.Windows.Forms.ComboBox();
            this.bdgSourceMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNom = new System.Windows.Forms.ComboBox();
            this.grpRapport = new System.Windows.Forms.GroupBox();
            this.lblAucunRapport = new System.Windows.Forms.Label();
            this.btnExporter = new System.Windows.Forms.Button();
            this.lblRapportDate = new System.Windows.Forms.Label();
            this.lblRapportBilan = new System.Windows.Forms.Label();
            this.lblRapportMotif = new System.Windows.Forms.Label();
            this.lblRapportVisiteur = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.bdgSourceRapport = new System.Windows.Forms.BindingSource(this.components);
            this.grpRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).BeginInit();
            this.grpRapport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.btnRechercher);
            this.grpRecherche.Controls.Add(this.label1);
            this.grpRecherche.Controls.Add(this.lblNom);
            this.grpRecherche.Controls.Add(this.cmbPrenom);
            this.grpRecherche.Controls.Add(this.cmbNom);
            this.grpRecherche.Location = new System.Drawing.Point(12, 12);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(260, 136);
            this.grpRecherche.TabIndex = 0;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "Recherche spécifique";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(118, 100);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(121, 23);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(17, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // cmbPrenom
            // 
            this.cmbPrenom.DataSource = this.bdgSourceMedecin;
            this.cmbPrenom.DisplayMember = "prenom";
            this.cmbPrenom.FormattingEnabled = true;
            this.cmbPrenom.Location = new System.Drawing.Point(118, 64);
            this.cmbPrenom.Name = "cmbPrenom";
            this.cmbPrenom.Size = new System.Drawing.Size(121, 21);
            this.cmbPrenom.TabIndex = 1;
            // 
            // bdgSourceMedecin
            // 
            this.bdgSourceMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // cmbNom
            // 
            this.cmbNom.DataSource = this.bdgSourceMedecin;
            this.cmbNom.DisplayMember = "nom";
            this.cmbNom.FormattingEnabled = true;
            this.cmbNom.Location = new System.Drawing.Point(118, 28);
            this.cmbNom.Name = "cmbNom";
            this.cmbNom.Size = new System.Drawing.Size(121, 21);
            this.cmbNom.TabIndex = 0;
            // 
            // grpRapport
            // 
            this.grpRapport.Controls.Add(this.lblAucunRapport);
            this.grpRapport.Controls.Add(this.btnExporter);
            this.grpRapport.Controls.Add(this.lblRapportDate);
            this.grpRapport.Controls.Add(this.lblRapportBilan);
            this.grpRapport.Controls.Add(this.lblRapportMotif);
            this.grpRapport.Controls.Add(this.lblRapportVisiteur);
            this.grpRapport.Controls.Add(this.lblDate);
            this.grpRapport.Controls.Add(this.lblBilan);
            this.grpRapport.Controls.Add(this.lblMotif);
            this.grpRapport.Controls.Add(this.lblVisiteur);
            this.grpRapport.Location = new System.Drawing.Point(12, 154);
            this.grpRapport.Name = "grpRapport";
            this.grpRapport.Size = new System.Drawing.Size(260, 167);
            this.grpRapport.TabIndex = 1;
            this.grpRapport.TabStop = false;
            this.grpRapport.Text = "Rapport";
            // 
            // lblAucunRapport
            // 
            this.lblAucunRapport.AutoSize = true;
            this.lblAucunRapport.Location = new System.Drawing.Point(52, 77);
            this.lblAucunRapport.Name = "lblAucunRapport";
            this.lblAucunRapport.Size = new System.Drawing.Size(157, 13);
            this.lblAucunRapport.TabIndex = 9;
            this.lblAucunRapport.Text = "Aucun rapport récent disponible";
            // 
            // btnExporter
            // 
            this.btnExporter.Location = new System.Drawing.Point(20, 132);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(219, 23);
            this.btnExporter.TabIndex = 8;
            this.btnExporter.Text = "Exporter au format .xml";
            this.btnExporter.UseVisualStyleBackColor = true;
            this.btnExporter.Visible = false;
            this.btnExporter.Click += new System.EventHandler(this.btnExporter_Click);
            // 
            // lblRapportDate
            // 
            this.lblRapportDate.AutoSize = true;
            this.lblRapportDate.Location = new System.Drawing.Point(67, 105);
            this.lblRapportDate.Name = "lblRapportDate";
            this.lblRapportDate.Size = new System.Drawing.Size(28, 13);
            this.lblRapportDate.TabIndex = 7;
            this.lblRapportDate.Text = "Vide";
            this.lblRapportDate.Visible = false;
            // 
            // lblRapportBilan
            // 
            this.lblRapportBilan.AutoSize = true;
            this.lblRapportBilan.Location = new System.Drawing.Point(67, 80);
            this.lblRapportBilan.Name = "lblRapportBilan";
            this.lblRapportBilan.Size = new System.Drawing.Size(28, 13);
            this.lblRapportBilan.TabIndex = 6;
            this.lblRapportBilan.Text = "Vide";
            this.lblRapportBilan.Visible = false;
            // 
            // lblRapportMotif
            // 
            this.lblRapportMotif.AutoSize = true;
            this.lblRapportMotif.Location = new System.Drawing.Point(67, 55);
            this.lblRapportMotif.Name = "lblRapportMotif";
            this.lblRapportMotif.Size = new System.Drawing.Size(28, 13);
            this.lblRapportMotif.TabIndex = 5;
            this.lblRapportMotif.Text = "Vide";
            this.lblRapportMotif.Visible = false;
            // 
            // lblRapportVisiteur
            // 
            this.lblRapportVisiteur.AutoSize = true;
            this.lblRapportVisiteur.Location = new System.Drawing.Point(67, 31);
            this.lblRapportVisiteur.Name = "lblRapportVisiteur";
            this.lblRapportVisiteur.Size = new System.Drawing.Size(28, 13);
            this.lblRapportVisiteur.TabIndex = 4;
            this.lblRapportVisiteur.Text = "Vide";
            this.lblRapportVisiteur.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            this.lblDate.Visible = false;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(17, 80);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(33, 13);
            this.lblBilan.TabIndex = 2;
            this.lblBilan.Text = "Bilan:";
            this.lblBilan.Visible = false;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(17, 55);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(33, 13);
            this.lblMotif.TabIndex = 1;
            this.lblMotif.Text = "Motif:";
            this.lblMotif.Visible = false;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(17, 31);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(44, 13);
            this.lblVisiteur.TabIndex = 0;
            this.lblVisiteur.Text = "Visiteur:";
            this.lblVisiteur.Visible = false;
            // 
            // bdgSourceRapport
            // 
            this.bdgSourceRapport.DataSource = typeof(gsbRapports.rapport);
            // 
            // frmDernierRapportMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.grpRapport);
            this.Controls.Add(this.grpRecherche);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDernierRapportMedecin";
            this.Text = "Dernier rapport d\'un médecin  |  GSB";
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceMedecin)).EndInit();
            this.grpRapport.ResumeLayout(false);
            this.grpRapport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceRapport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cmbPrenom;
        private System.Windows.Forms.ComboBox cmbNom;
        private System.Windows.Forms.GroupBox grpRapport;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.BindingSource bdgSourceMedecin;
        private System.Windows.Forms.BindingSource bdgSourceRapport;
        private System.Windows.Forms.Label lblAucunRapport;
        private System.Windows.Forms.Button btnExporter;
        private System.Windows.Forms.Label lblRapportDate;
        private System.Windows.Forms.Label lblRapportBilan;
        private System.Windows.Forms.Label lblRapportMotif;
        private System.Windows.Forms.Label lblRapportVisiteur;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblVisiteur;
    }
}