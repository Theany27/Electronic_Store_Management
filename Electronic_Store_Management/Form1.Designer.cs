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
            this.paneltitle = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnsell = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnreport);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnproduct);
            this.panelMenu.Controls.Add(this.btnsell);
            this.panelMenu.Controls.Add(this.btnhome);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(274, 745);
            this.panelMenu.TabIndex = 0;
            // 
            // paneltitle
            // 
            this.paneltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.paneltitle.Controls.Add(this.paneldesktop);
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
            this.toplabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.toplabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toplabel.Location = new System.Drawing.Point(496, 21);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(90, 31);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "Home";
            this.toplabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toplabel.Click += new System.EventHandler(this.toplabel_Click);
            // 
            // paneldesktop
            // 
            this.paneldesktop.Location = new System.Drawing.Point(0, 74);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(1097, 658);
            this.paneldesktop.TabIndex = 3;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(274, 76);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Electronics shop management";
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreport.Image = global::Electronic_Store_Management.Properties.Resources.icons8_report_48;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(0, 271);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(274, 49);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "   Report";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproduct.Image = global::Electronic_Store_Management.Properties.Resources.icons8_shopping_cart_48;
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(0, 216);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnproduct.Size = new System.Drawing.Size(274, 49);
            this.btnproduct.TabIndex = 4;
            this.btnproduct.Text = "   Product";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnsell
            // 
            this.btnsell.FlatAppearance.BorderSize = 0;
            this.btnsell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnsell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsell.Image = global::Electronic_Store_Management.Properties.Resources.icons8_sell_48;
            this.btnsell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsell.Location = new System.Drawing.Point(0, 161);
            this.btnsell.Name = "btnsell";
            this.btnsell.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsell.Size = new System.Drawing.Size(274, 49);
            this.btnsell.TabIndex = 3;
            this.btnsell.Text = "   Sell";
            this.btnsell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsell.UseVisualStyleBackColor = true;
            this.btnsell.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Image = global::Electronic_Store_Management.Properties.Resources.icons8_home_48__1_;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 106);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(274, 49);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "   Home";
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 744);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label toplabel;
        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

