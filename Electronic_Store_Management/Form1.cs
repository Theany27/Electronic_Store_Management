using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store_Management
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenchildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();  
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill;                  
            this.paneldesktop.Controls.Clear();               
            this.paneldesktop.Controls.Add(childForm);
            this.paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            toplabel.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormHome());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormHome());
        }

        private void paneldesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormSell());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormProduct());
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.btnexporttopdf());
        }
    }
}
