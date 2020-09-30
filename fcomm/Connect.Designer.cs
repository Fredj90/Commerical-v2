namespace fcomm
{
    partial class Connect
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
            this.PWD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Soc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exerc = new System.Windows.Forms.ComboBox();
            this.ste = new System.Windows.Forms.ComboBox();
            this.magasin = new System.Windows.Forms.ComboBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.Mag = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // PWD
            // 
            this.PWD.BackColor = System.Drawing.Color.White;
            this.PWD.Location = new System.Drawing.Point(58, 64);
            this.PWD.MaxLength = 30;
            this.PWD.Name = "PWD";
            this.PWD.Size = new System.Drawing.Size(259, 20);
            this.PWD.TabIndex = 123;
            this.PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PWD_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "M.Passe:";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(58, 31);
            this.Log.MaxLength = 50;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(259, 20);
            this.Log.TabIndex = 122;
            this.Log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Log_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Login     :";
            // 
            // Soc
            // 
            this.Soc.FormattingEnabled = true;
            this.Soc.Location = new System.Drawing.Point(58, 98);
            this.Soc.Name = "Soc";
            this.Soc.Size = new System.Drawing.Size(259, 21);
            this.Soc.TabIndex = 126;
            this.Soc.SelectedIndexChanged += new System.EventHandler(this.Soc_SelectedIndexChanged);
            this.Soc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Soc_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "Magasin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "Exercice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "Societé :";
            // 
            // Exerc
            // 
            this.Exerc.FormattingEnabled = true;
            this.Exerc.Location = new System.Drawing.Point(58, 164);
            this.Exerc.Name = "Exerc";
            this.Exerc.Size = new System.Drawing.Size(259, 21);
            this.Exerc.TabIndex = 136;
            this.Exerc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exerc_KeyDown);
            // 
            // ste
            // 
            this.ste.FormattingEnabled = true;
            this.ste.Location = new System.Drawing.Point(326, 98);
            this.ste.Name = "ste";
            this.ste.Size = new System.Drawing.Size(43, 21);
            this.ste.TabIndex = 137;
            // 
            // magasin
            // 
            this.magasin.FormattingEnabled = true;
            this.magasin.Location = new System.Drawing.Point(326, 133);
            this.magasin.Name = "magasin";
            this.magasin.Size = new System.Drawing.Size(44, 21);
            this.magasin.TabIndex = 138;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.White;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX2.FocusCuesEnabled = false;
            this.buttonX2.ForeColor = System.Drawing.Color.White;
            this.buttonX2.Location = new System.Drawing.Point(26, 200);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(88, 26);
            this.buttonX2.TabIndex = 139;
            this.buttonX2.Text = "&Connecter";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Mag
            // 
            this.Mag.DisplayMember = "Text";
            this.Mag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Mag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mag.FormattingEnabled = true;
            this.Mag.ItemHeight = 14;
            this.Mag.Location = new System.Drawing.Point(58, 133);
            this.Mag.Name = "Mag";
            this.Mag.Size = new System.Drawing.Size(259, 20);
            this.Mag.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Mag.TabIndex = 140;
            this.Mag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mag_KeyDown);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.Mag);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.magasin);
            this.Controls.Add(this.ste);
            this.Controls.Add(this.Exerc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Soc);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Connect";
            this.Text = "connect";
            this.Load += new System.EventHandler(this.connect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PWD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Soc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Exerc;
        private System.Windows.Forms.ComboBox ste;
        private System.Windows.Forms.ComboBox magasin;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Mag;

    }
}