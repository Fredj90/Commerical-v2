using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace fcomm
{
    public partial class Connect : Office2007Form
    {
     metier met = Program.met;
        public int wnbres = 0, wnbrep = 0, xs;
        public DateTime wdateprog;
        public int wpasseprog;
        public DateTime wdatejours = DateTime.Now;

        public Connect()
        {
            InitializeComponent();
        }
        private void connect_Load(object sender, EventArgs e)
        {
            DataSet ds = met.recuperer_table("Select * From ste order by code", "ste");
            BindingSource bs = new BindingSource(ds, "ste");
            Soc.DisplayMember = "libelle";
            Soc.ValueMember = "code";
            ste.ValueMember = "libelle";
            ste.DisplayMember = "libelle";
            //Exerc.DisplayMember = "libelle";
            //Exerc.ValueMember = "codee";
            Soc.DataSource = bs;
            ste.DataSource = bs;


        }

        

        private void Soc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Soc.SelectedIndex != -1)
            {
                if (Exerc.DataSource != null) (Exerc.DataSource) = null;
                if (magasin.DataSource != null) (magasin.DataSource) = null;
                DataSet ds1 = met.recuperer_table("Select distinct * From magasin Where codes = '" + Soc.SelectedValue + "'", "magasin");
                BindingSource bs1 = new BindingSource(ds1, "magasin");
                Mag.DisplayMember = "libelle";
                Mag.ValueMember = "code";
                magasin.DisplayMember = "libelle";
                magasin.ValueMember = "libelle";
                Mag.DataSource = bs1;
                magasin.DataSource = bs1;
                DataSet dse = met.recuperer_table("SELECT e.* FROM `ste` s, exercice e  WHERE e.`codes`=s.`code` AND s.`code`='" + Soc.SelectedValue + "'", "exercice");
                BindingSource bs = new BindingSource(dse, "exercice");
                Exerc.DisplayMember = "libelle";
                Exerc.ValueMember = "code";
                Exerc.DataSource = bs;
            }

            else
            {
                (Exerc.DataSource) = null;
                (Mag.DataSource) = null;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (!Log.Text.Equals("") && !PWD.Text.Equals("") && Soc.SelectedIndex != -1 && Exerc.SelectedIndex != -1)
            {
                DataSet ds = met.recuperer_table("select * from utilisateur where libelle = '" + Log.Text + "' and mp ='" + PWD.Text + "' ", "utilisateur");
                if (ds.Tables["utilisateur"].Rows.Count != 0)
                {
                    Program.Societe = Soc.SelectedValue.ToString();
                    Program.LibSociete = ste.SelectedValue.ToString();
                    Program.ISFodec = (Boolean)(((DataSet)((BindingSource)Soc.DataSource).DataSource)).Tables[0].Rows[Soc.SelectedIndex]["fodec"];
                    Program.LibMagasin = magasin.SelectedValue.ToString();
                    Program.Magasin = Mag.SelectedValue.ToString();
                    Program.LibEnteteMagasin = (string)(((DataSet)((BindingSource)Mag.DataSource).DataSource)).Tables[0].Rows[Mag.SelectedIndex]["titre"];
                    Program.Exercice = ((DataRowView)Exerc.SelectedValue).Row.ItemArray[2] + "";
                    Program.User = ds.Tables["utilisateur"].Rows[0].Field<String>("code");
                    Program.User = ds.Tables["utilisateur"].Rows[0].Field<String>("code");
                    Program.LibUser = ds.Tables["utilisateur"].Rows[0].Field<String>("libelle");

                    Program.v1 = ds.Tables["utilisateur"].Rows[0].Field<String>("v1");
                    Program.v2 = ds.Tables["utilisateur"].Rows[0].Field<String>("v2");
                    Program.v3 = ds.Tables["utilisateur"].Rows[0].Field<String>("v3");
                    Program.v4 = ds.Tables["utilisateur"].Rows[0].Field<String>("v4");
                    Program.v5 = ds.Tables["utilisateur"].Rows[0].Field<String>("v5");
                    Program.v6 = ds.Tables["utilisateur"].Rows[0].Field<String>("v6");

                    Program.a1 = ds.Tables["utilisateur"].Rows[0].Field<String>("a1");
                    Program.a2 = ds.Tables["utilisateur"].Rows[0].Field<String>("a2");
                    Program.a3 = ds.Tables["utilisateur"].Rows[0].Field<String>("a3");
                    Program.a4 = ds.Tables["utilisateur"].Rows[0].Field<String>("a4");

                    Program.f1 = ds.Tables["utilisateur"].Rows[0].Field<String>("f1");
                    Program.f2 = ds.Tables["utilisateur"].Rows[0].Field<String>("f2");
                    Program.f3 = ds.Tables["utilisateur"].Rows[0].Field<String>("f3");
                    Program.f4 = ds.Tables["utilisateur"].Rows[0].Field<String>("f4");
                    Program.f5 = ds.Tables["utilisateur"].Rows[0].Field<String>("f5");

                    Program.b1 = ds.Tables["utilisateur"].Rows[0].Field<String>("b1");
                    Program.b2 = ds.Tables["utilisateur"].Rows[0].Field<String>("b2");
                    Program.b3 = ds.Tables["utilisateur"].Rows[0].Field<String>("b3");
                    Program.b4 = ds.Tables["utilisateur"].Rows[0].Field<String>("b4");
                    Program.b5 = ds.Tables["utilisateur"].Rows[0].Field<String>("b5");
                    Program.b6 = ds.Tables["utilisateur"].Rows[0].Field<String>("b6");

                    Program.creation = ds.Tables["utilisateur"].Rows[0].Field<String>("creation");
                    Program.modification = ds.Tables["utilisateur"].Rows[0].Field<String>("modification");
                    Program.suppression = ds.Tables["utilisateur"].Rows[0].Field<String>("suppression");

                    if( ds.Tables["utilisateur"].Rows[0].Field<String>("type").Equals("S"))
                    {
                        Program.ISaDmin = true;
                        Program.TypUser = "Super Administrateur";
                    }
                    if (ds.Tables["utilisateur"].Rows[0].Field<String>("type").Equals("A"))
                    {
                        Program.ISaDmin = true;
                        Program.TypUser = "Administrateur";
                    }
                    if (ds.Tables["utilisateur"].Rows[0].Field<String>("type").Equals("U"))
                    {
                        Program.TypUser = "Utilisateur";
                    }
                    this.Hide();
                Menugen mg = new Menugen ();
                    mg.Show();

                }
                else MessageBox.Show("Verifier Votre Login et/ou Mot de passe");
            }
            else
                MessageBox.Show("Veillez Remplir Tous les champs");
   
        }

        

        private void Log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PWD.Focus();
        }

        private void PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Soc.Focus();
        }

        private void Soc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               Mag.Focus();


        }

        private void Mag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Exerc.Focus();

        }

        private void Exerc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonX2.Focus();

        }

      

       

    }
}
