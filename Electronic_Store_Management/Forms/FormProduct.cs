using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store_Management.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ProductsModel products=new ProductsModel();
            int qty=products.StockQuantity - 1;
            List<ProductsModel> productsList = ProductServiesData.GetProducts();
            productsList.Add(products);
            tblproductform.DataSource = productsList.Select(x => new
            {
                x.Category,
                x.ProductID,
                x.ProductName,
                x.Price,
                x.StockQuantity
            }).ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
