using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class frmGererMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public frmGererMedecin(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            //Chargement des données
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceMedecin.DataSource = this.mesDonneesEF.medecins;

            //var lesDepartements = (from medecins in mesDonneesEF.medecins
                                   //orderby medecins.departement ascending
                                   //select medecins.departement).Distinct();

            //foreach (var unDepartement in lesDepartements)
            //{
                //this.cmbDepartement.Items.Add(unDepartement);
            //}

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            //Sauvegarde les informations de la DataGridView: dtgMedecin
            this.bdgSourceMedecin.EndEdit();
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("L'application à sauvegardée les modifications.");
        }

        //DataGridView
        private void dtgGererMedecin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            //Permet de selectionner la dernière ligne afin d'ajouter un médecin dans un champs vide => Sauvegarder.
            dtgGererMedecin.ClearSelection(); //Supprime la selection
            int nRowIndex = dtgGererMedecin.Rows.Count - 1;
            int nColumnIndex = 1;
            dtgGererMedecin.Rows[nRowIndex].Selected = true;
            dtgGererMedecin.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dtgGererMedecin.FirstDisplayedScrollingRowIndex = nRowIndex; //Réutilisation du script
            dtgGererMedecin.BeginEdit(true);
        }
    }
}
