using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fcomm
{
    public partial class Aricle : DevComponents.DotNetBar.Office2007Form
    {
        metier met1 = Program.met;
        public Aricle()
        {
            InitializeComponent();
        }

        private void Aricle_Load(object sender, EventArgs e)
        {
            String req = "select * from tva where codes ='"+Program.Societe+"'";
            DataSet ds = met1.recuperer_table(req, "tva");
            BindingSource bin = new BindingSource (ds, "tva");
            cmbtva.ValueMember = "taux";
            cmbtva.DisplayMember = "taux";
            cmbtva.DataSource=bin;
            string req3 = "Select * from Fodec";
            DataSet ds3 = met1.recuperer_table(req3, "Fodec");
            BindingSource bs3 = new BindingSource(ds3, "Fodec");
            cmbfodec.ValueMember = "taux";
            cmbfodec.DisplayMember = "taux";
            cmbfodec.DataSource = bs3;
            string req4 = "select * from  FamilleArticle where codes='" + Program.Societe + "' and codee='"+Program.Exercice+"'";
            DataSet d = met1.recuperer_table(req4, "FamilleArticle");
            BindingSource bs4 = new BindingSource(d,"FamilleArticle");
            cmbfama.ValueMember = "code";
            cmbfama.DisplayMember = "libelle";
            cmbfama.DataSource = bs4;

            String req9 = "SELECT * FROM secteura where codes='" + Program.Societe + "' and codee = '" + Program.Exercice + "'  and codem = '" + Program.Magasin + "' Order by code ";
            DataSet ds9 = met1.recuperer_table(req9, "secteura");
            BindingSource bs9 = new BindingSource(ds9, "secteura");
            secteur.ValueMember = "Code";
            secteur.DisplayMember = "Libelle";
            secteur.DataSource = bs9;

            String req5 = "SELECT * FROM rayon where codes='" + Program.Societe + "' and codee = '" + Program.Exercice + "'  and codem = '" + Program.Magasin + "' Order by code ";
            DataSet ds5 = met1.recuperer_table(req5, "rayon");
            BindingSource bs5 = new BindingSource(ds5, "rayon");
            rayon.ValueMember = "Code";
            rayon.DisplayMember = "Libelle";
            rayon.DataSource = bs5;

            String req6 = "SELECT * FROM etagere where codes='" + Program.Societe + "' and codee = '" + Program.Exercice + "'  and codem = '" + Program.Magasin + "' Order by code ";
            DataSet ds6 = met1.recuperer_table(req6, "etagere");
            BindingSource bs6 = new BindingSource(ds6, "etagere");
            etagere.ValueMember = "Code";
            etagere.DisplayMember = "Libelle";
            etagere.DataSource = bs6;

            String req7 = "SELECT * FROM casier where codes='" + Program.Societe + "' and codee = '" + Program.Exercice + "'  and codem = '" + Program.Magasin + "' Order by code ";
            DataSet ds7 = met1.recuperer_table(req7, "casier");
            BindingSource bs7 = new BindingSource(ds7, "casier");
            casier.ValueMember = "Code";
            casier.DisplayMember = "Libelle";
            casier.DataSource = bs7;

            String req18 = "SELECT * FROM Depot where codes='" + Program.Societe + "' and codee = '" + Program.Exercice + "'  and codem = '" + Program.Magasin + "' Order by code ";
            DataSet ds18 = met1.recuperer_table(req18, "depot");
            BindingSource bs18 = new BindingSource(ds18, "depot");
            depot.ValueMember = "Code";
            depot.DisplayMember = "Libelle";
            depot.DataSource = bs18;

        }
    }
}
