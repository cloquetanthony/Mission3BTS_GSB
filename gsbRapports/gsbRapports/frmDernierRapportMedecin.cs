using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace gsbRapports
{
    public partial class frmDernierRapportMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public frmDernierRapportMedecin(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            //Chargement des données
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceRapport.DataSource = this.mesDonneesEF.rapports;
            this.bdgSourceMedecin.DataSource = this.mesDonneesEF.medecins;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                //Verification champs vides
                if (cmbNom.Text == "" || cmbPrenom.Text == "")
                {
                    MessageBox.Show("Erreur: Veuillez renseigner tous les champs.");
                }
                else
                {
                    //Récupération des critères de recherche
                    string rechercheNom = cmbNom.Text;
                    string recherchePrenom = cmbPrenom.Text;
                    //Recherche via requête Linq
                    var leRapport = (from rapports in mesDonneesEF.rapports
                                     join medecins in mesDonneesEF.medecins on rapports.idMedecin equals medecins.id
                                     join visiteurs in mesDonneesEF.visiteurs on rapports.idVisiteur equals visiteurs.id
                                     orderby rapports.date descending
                                     where medecins.nom == rechercheNom && medecins.prenom == recherchePrenom
                                     select new
                                     {
                                         NomMedecin = medecins.nom,
                                         DateRapport = rapports.date,
                                         Motif = rapports.motif,
                                         Bilan = rapports.bilan,
                                         NomVisiteur = visiteurs.nom
                                     }).First();

                    //Le label indiquant qu'il n'existe aucun rapport récent disparait
                    lblAucunRapport.Visible = false;

                    //Les labels d'affichage du rapport deviennent visibles
                    lblRapportBilan.Visible = true;
                    lblRapportDate.Visible = true;
                    lblRapportMotif.Visible = true;
                    lblRapportVisiteur.Visible = true;

                    //Définition de la valeur des labels devenus visibles
                    lblRapportBilan.Text = leRapport.Bilan.ToString();
                    lblRapportDate.Text = leRapport.DateRapport.ToString();
                    lblRapportMotif.Text = leRapport.Motif.ToString();
                    lblRapportVisiteur.Text = leRapport.NomVisiteur.ToString();

                    //Les labels des titres du rapport deviennent visibles
                    lblBilan.Visible = true;
                    lblDate.Visible = true;
                    lblMotif.Visible = true;
                    lblVisiteur.Visible = true;

                    //Le bouton "Exporter sous .XML" devient visible
                    btnExporter.Visible = true;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("Erreur: aucun rapport trouvé.");
            }
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            //Récupération des critères de recherche
            string rechercheNom = cmbNom.Text;
            string recherchePrenom = cmbPrenom.Text;
            //Récupère la date et l'heure d'aujourd'hui pour le nom du .xml
            DateTime aujourdhui = DateTime.Now;
            //Recherche via requête Linq
            var leRapport = (from rapports in mesDonneesEF.rapports
                             join medecins in mesDonneesEF.medecins on rapports.idMedecin equals medecins.id
                             join visiteurs in mesDonneesEF.visiteurs on rapports.idVisiteur equals visiteurs.id
                             orderby rapports.date descending
                             where medecins.nom == rechercheNom && medecins.prenom == recherchePrenom
                             select new
                             {
                                 NomMedecin = medecins.nom,
                                 DateRapport = rapports.date,
                                 Motif = rapports.motif,
                                 Bilan = rapports.bilan,
                                 NomVisiteur = visiteurs.nom
                             }).First();
            //Serialisation
            XElement nomMedecin = new XElement("NomMedecin", leRapport.NomMedecin);
            XElement nomVisiteur = new XElement("NomVisiteur", leRapport.NomVisiteur);
            XElement motif = new XElement("Motif", leRapport.Motif);
            XElement bilan = new XElement("Bilan", leRapport.Bilan);
            XElement date = new XElement("DateRapport", leRapport.DateRapport);
            XElement rapport = new XElement("Rapport");
            rapport.Add(nomMedecin);
            rapport.Add(nomVisiteur);
            rapport.Add(motif);
            rapport.Add(bilan);
            rapport.Add(date);
            XmlSerializer XmlSrlz = new XmlSerializer(typeof(XElement));
            using (StreamWriter sw = new StreamWriter("rapport.xml"))
            {
                XmlSrlz.Serialize(sw, rapport);
            }

            MessageBox.Show("Le fichier: rapport.xml à été enregistré.\r\nDescriptif:\n" + rapport.ToString());
        }


        }
    }
