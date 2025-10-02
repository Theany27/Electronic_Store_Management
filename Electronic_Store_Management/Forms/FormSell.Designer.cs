namespace Electronic_Store_Management.Forms
{
    partial class FormSell
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsellqty = new System.Windows.Forms.TextBox();
            this.btnaddtocard = new System.Windows.Forms.Button();
            this.tblshowproductsell = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpaynow = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboboxsell = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboboxsellproname = new System.Windows.Forms.ComboBox();
            this.txtsellprice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblshowproductsell)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // txtsellqty
            // 
            this.txtsellqty.Location = new System.Drawing.Point(673, 36);
            this.txtsellqty.Name = "txtsellqty";
            this.txtsellqty.Size = new System.Drawing.Size(100, 20);
            this.txtsellqty.TabIndex = 5;
            this.txtsellqty.Text = "1";
            // 
            // btnaddtocard
            // 
            this.btnaddtocard.Location = new System.Drawing.Point(836, 109);
            this.btnaddtocard.Name = "btnaddtocard";
            this.btnaddtocard.Size = new System.Drawing.Size(87, 32);
            this.btnaddtocard.TabIndex = 6;
            this.btnaddtocard.Text = "Add To Card";
            this.btnaddtocard.UseVisualStyleBackColor = true;
            this.btnaddtocard.Click += new System.EventHandler(this.btnaddtocard_Click);
            // 
            // tblshowproductsell
            // 
            this.tblshowproductsell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblshowproductsell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblshowproductsell.Location = new System.Drawing.Point(12, 177);
            this.tblshowproductsell.Name = "tblshowproductsell";
            this.tblshowproductsell.Size = new System.Drawing.Size(961, 112);
            this.tblshowproductsell.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // btnpaynow
            // 
            this.btnpaynow.Location = new System.Drawing.Point(37, 359);
            this.btnpaynow.Name = "btnpaynow";
            this.btnpaynow.Size = new System.Drawing.Size(75, 28);
            this.btnpaynow.TabIndex = 9;
            this.btnpaynow.Text = "Pay Now!";
            this.btnpaynow.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(187, 359);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(131, 28);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel Product";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Curent Product:";
            // 
            // comboboxsell
            // 
            this.comboboxsell.FormattingEnabled = true;
            this.comboboxsell.Location = new System.Drawing.Point(73, 34);
            this.comboboxsell.Name = "comboboxsell";
            this.comboboxsell.Size = new System.Drawing.Size(121, 21);
            this.comboboxsell.TabIndex = 12;
            this.comboboxsell.SelectedIndexChanged += new System.EventHandler(this.comboboxsell_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(861, 37);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 15;
            this.txtdiscount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboboxsellproname
            // 
            this.comboboxsellproname.FormattingEnabled = true;
            this.comboboxsellproname.Location = new System.Drawing.Point(249, 35);
            this.comboboxsellproname.Name = "comboboxsellproname";
            this.comboboxsellproname.Size = new System.Drawing.Size(191, 21);
            this.comboboxsellproname.TabIndex = 17;
            this.comboboxsellproname.SelectedIndexChanged += new System.EventHandler(this.comboboxsellproname_SelectedIndexChanged);
            // 
            // txtsellprice
            // 
            this.txtsellprice.FormattingEnabled = true;
            this.txtsellprice.Location = new System.Drawing.Point(483, 34);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(121, 21);
            this.txtsellprice.TabIndex = 18;
            this.txtsellprice.SelectedIndexChanged += new System.EventHandler(this.txtsellprice_SelectedIndexChanged);
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 573);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.comboboxsellproname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboboxsell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnpaynow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tblshowproductsell);
            this.Controls.Add(this.btnaddtocard);
            this.Controls.Add(this.txtsellqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSell";
            this.Text = "FormSell";
            this.Load += new System.EventHandler(this.FormSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblshowproductsell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsellqty;
        private System.Windows.Forms.Button btnaddtocard;
        private System.Windows.Forms.DataGridView tblshowproductsell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpaynow;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboboxsell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboboxsellproname;
        private System.Windows.Forms.ComboBox txtsellprice;
        //private DropDownButton dropdownsellpro;
        //private DropDownButton dropDownButton1;
        //private GalleryDropDown galleryDropDown1;
    }
}