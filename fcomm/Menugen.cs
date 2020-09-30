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
    public partial class Menugen :  DevComponents.DotNetBar.Office2007Form
    {
        public Menugen()
        {
            InitializeComponent();
        }

        private void famillesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            param frm = new param();
             
            frm.table = "familleclient";
            frm.champs = "familleclient";
            frm.Text = "Famille Client";
           frm.MdiParent = this;
            frm.Show();
        }

        private void ficheArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aricle a = new Aricle();
           a.MdiParent=this;
            a.Show();
        }
    }
}
