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
    public partial class  param : DevComponents.DotNetBar.Office2007Form
    {
        metier met = Program.met;
        public string table, champs, xtype = "";
        Boolean modif = false;
        public string xcodep;
        DataSet ds, ds1;
        int index = 0;
        public int num, xnum;

        public param()
        {
            InitializeComponent();
        }

        private void param_Load(object sender, EventArgs e)
        {
            load_data();
            if(mygrid1.Rows.Count!=0)
                mygrid1.Rows[0].Selected = true;
            dgv_click();
           
            }
            private void load_data()
        {
            try
            {
                string req = "select ID,code,libelle from " + table + " where codes ='" + Program.Societe + "' and codee ='" + Program.Exercice + "' order by code";
                DataSet ds = met.recuperer_table(req, table);
                mygrid1.DataSource = ds.Tables[table].DefaultView;
            }

            catch { }
        }
            private void dgv_click()
            {
                if (mygrid1.SelectedRows != null)
                    if (mygrid1.SelectedRows.Count != 0)
                    {

                   mytext1.Text = mygrid1.SelectedRows[0].Cells["ID"].Value.ToString();
                        mytext2.Text = mygrid1.SelectedRows[0].Cells["libelle"].Value.ToString();



                    }
            }

            private void mygrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                dgv_click();
            }

            private void buttonItem1_Click(object sender, EventArgs e)
            {
                buttonX1.Visible = true;
                buttonX2.Visible = true;
                buttonX5.Visible = false;
                mytext1.Visible = false;
                mytext2.ReadOnly = false;
                mytext2.Text = "";
                mygrid1.Enabled = false;
                
             //int a=  s0.Tables[0].Rows.Count;
            }

            private void mygrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {
                dgv_click();
            }

            private void mygrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
            {
                dgv_click();
            }

            private void buttonX2_Click(object sender, EventArgs e)
            {
                if (mytext2.Text != "")
                {
                    int c = int.Parse(mytext1.Text);
                    c++;
                    string req = "insert into " + table + " (codes,codee,code,libelle) Values ('" + Program.Societe + "','" + Program.Exercice + "','" + c + "', '" + mytext2.Text + "')";
                    met.Execute(req);
                  MessageBox.Show("enregestrement termineé");
                  load_data();
                }

                //DataSet s0= met.recuperer_table(req,table);
            }
    }
}
