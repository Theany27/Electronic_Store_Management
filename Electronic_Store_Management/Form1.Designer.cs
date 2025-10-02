namespace Electronic_Store_Management
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnsell = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.btnreport);
            this.panelMenu.Controls.Add(this.btnproduct);
            this.panelMenu.Controls.Add(this.btnsell);
            this.panelMenu.Controls.Add(this.btnhome);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(274, 745);
            this.panelMenu.TabIndex = 0;
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.Location = new System.Drawing.Point(0, 364);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(274, 36);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.Location = new System.Drawing.Point(0, 294);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(274, 36);
            this.btnproduct.TabIndex = 4;
            this.btnproduct.Text = "Product";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnsell
            // 
            this.btnsell.FlatAppearance.BorderSize = 0;
            this.btnsell.Location = new System.Drawing.Point(0, 222);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(274, 36);
            this.btnsell.TabIndex = 3;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = true;
            this.btnsell.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.Location = new System.Drawing.Point(0, 155);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(274, 36);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(274, 115);
            this.panelLogo.TabIndex = 1;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneltitle.Controls.Add(this.toplabel);
            this.paneltitle.Location = new System.Drawing.Point(274, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1105, 76);
            this.paneltitle.TabIndex = 2;
            this.paneltitle.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitle_Paint);
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.toplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplabel.Location = new System.Drawing.Point(504, 24);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(90, 31);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "Home";
            this.toplabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toplabel.Click += new System.EventHandler(this.toplabel_Click);
            // 
            // paneldesktop
            // 
            this.paneldesktop.Location = new System.Drawing.Point(280, 82);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(1087, 650);
            this.paneldesktop.TabIndex = 3;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 744);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.Label toplabel;
    }
}

