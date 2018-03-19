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
    public partial class Form1 : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public Form1()
        {
            this.InitializeComponent();;
            this.mesDonneesEF = new gsbrapportsEntities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //Gérer les médecins (Nom du ToolStripMenu d'origine du projet)
        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGererMedecin Formulaire = new frmGererMedecin(this.mesDonneesEF);
            Formulaire.Show();
        }

        //Dernier rapport d'un médecin (Nom du ToolStripMenu d'origine du projet)
        private void majToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDernierRapportMedecin Formulaire = new frmDernierRapportMedecin(this.mesDonneesEF);
            Formulaire.Show();
        }

        // Fichier > Quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
