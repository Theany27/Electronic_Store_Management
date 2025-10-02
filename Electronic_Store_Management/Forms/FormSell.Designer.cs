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
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsellqty = new System.Windows.Forms.TextBox();
            this.btnaddtocard = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpaynow = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboboxsell = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsellprice
            // 
            this.txtsellprice.Location = new System.Drawing.Point(448, 35);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(100, 20);
            this.txtsellprice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // txtsellqty
            // 
            this.txtsellqty.Location = new System.Drawing.Point(716, 38);
            this.txtsellqty.Name = "txtsellqty";
            this.txtsellqty.Size = new System.Drawing.Size(100, 20);
            this.txtsellqty.TabIndex = 5;
            // 
            // btnaddtocard
            // 
            this.btnaddtocard.Location = new System.Drawing.Point(836, 109);
            this.btnaddtocard.Name = "btnaddtocard";
            this.btnaddtocard.Size = new System.Drawing.Size(87, 32);
            this.btnaddtocard.TabIndex = 6;
            this.btnaddtocard.Text = "Add To Card";
            this.btnaddtocard.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 112);
            this.dataGridView1.TabIndex = 7;
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
            this.comboboxsell.Items.AddRange(new object[] {
            "Power Bank",
            "USB Cable",
            "TypeC Cable",
            "Network Cable",
            "Azus Adapter"});
            this.comboboxsell.Location = new System.Drawing.Point(123, 35);
            this.comboboxsell.Name = "comboboxsell";
            this.comboboxsell.Size = new System.Drawing.Size(121, 21);
            this.comboboxsell.TabIndex = 12;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 573);
            this.Controls.Add(this.comboboxsell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnpaynow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaddtocard);
            this.Controls.Add(this.txtsellqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSell";
            this.Text = "FormSell";
            this.Load += new System.EventHandler(this.FormSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsellqty;
        private System.Windows.Forms.Button btnaddtocard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpaynow;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboboxsell;
        //private DropDownButton dropdownsellpro;
        //private DropDownButton dropDownButton1;
        //private GalleryDropDown galleryDropDown1;
    }
}