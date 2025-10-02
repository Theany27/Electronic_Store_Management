using DevExpress.DemoData.Model;
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
    public partial class FormSell : Form
    {
        List<ProductsModel> products = new List<ProductsModel>();

        public FormSell()
        {
            InitializeComponent();

            var selectedCategory = ProductServiesData.GetProducts();

            var categories = selectedCategory.Select(p => p.Category).Distinct().ToList();
            comboboxsell.DataSource = categories;
            comboboxsell.SelectedIndexChanged += comboboxsell_SelectedIndexChanged;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSell_Load(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnaddtocard_Click(object sender, EventArgs e)
        {
            ProductsModel productsModel = new ProductsModel
            {
                Category = comboboxsell.SelectedItem.ToString(),
                ProductID = comboboxsellproname.SelectedValue.ToString(),
                ProductName = comboboxsellproname.Text,
                Price = Convert.ToDecimal(txtsellprice.Text),
                SellQty = Convert.ToInt32(txtsellqty.Text),
                Discount = Convert.ToInt32(txtdiscount.Text),
            };

            //List<ProductsModel> products = new List<ProductsModel>();
            products.Add(productsModel);
            tblshowproductsell.DataSource = products.Select(x => new
            {
                x.Category,
                x.ProductID,
                x.ProductName,
                x.Price,
                x.SellQty,
                x.Discount
            }).ToList();

        }

        private void comboboxsellproname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxsellproname.SelectedItem != null)
            {
                var selectedProduct = comboboxsellproname.SelectedItem as ProductsModel;

                if (selectedProduct != null)
                {
                    txtsellprice.Text = selectedProduct.Price.ToString("0.00");
                }
            }

        }

        private void txtsellprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsellprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboboxsell_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboboxsell.SelectedItem.ToString();
            var products = ProductServiesData.GetProducts()
                                      .Where(p => p.Category == selectedName)
                                      .ToList();


            comboboxsellproname.DisplayMember = "ProductName"; // Show Name
            comboboxsellproname.ValueMember = "ProductID";     // Store ID
            comboboxsellproname.DataSource = products;
            comboboxsellproname.SelectedIndexChanged += comboboxsellproname_SelectedIndexChanged;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            

        }
    }
}
