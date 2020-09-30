namespace fcomm
{
    partial class Menugen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesClientsCtrF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.famillesClientsToolStripMenuItem,
            this.famillesClientsCtrF2ToolStripMenuItem,
            this.ficheArticleToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fichiersToolStripMenuItem.Text = "Fichiers";
            // 
            // famillesClientsToolStripMenuItem
            // 
            this.famillesClientsToolStripMenuItem.Name = "famillesClientsToolStripMenuItem";
            this.famillesClientsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.famillesClientsToolStripMenuItem.Text = "Familles &Clients F1";
            this.famillesClientsToolStripMenuItem.Click += new System.EventHandler(this.famillesClientsToolStripMenuItem_Click);
            // 
            // famillesClientsCtrF2ToolStripMenuItem
            // 
            this.famillesClientsCtrF2ToolStripMenuItem.Name = "famillesClientsCtrF2ToolStripMenuItem";
            this.famillesClientsCtrF2ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.famillesClientsCtrF2ToolStripMenuItem.Text = "Familles &article Ctr F2";
            // 
            // ficheArticleToolStripMenuItem
            // 
            this.ficheArticleToolStripMenuItem.Name = "ficheArticleToolStripMenuItem";
            this.ficheArticleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ficheArticleToolStripMenuItem.Text = "Fiche Article";
            this.ficheArticleToolStripMenuItem.Click += new System.EventHandler(this.ficheArticleToolStripMenuItem_Click);
            // 
            // Menugen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 522);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menugen";
            this.Text = "Menugen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famillesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famillesClientsCtrF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheArticleToolStripMenuItem;
    }
}