using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgProduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgProduct.DataSource = context.Products.Where(p => p.ProductName.Contains(tproduct.Text)).ToList();
            }
        }
        private void ListCategories ()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cmkatlist.DataSource = context.Categories.ToList();
                cmkatlist.DisplayMember = "CategoryName"; //görünecek değer
                cmkatlist.ValueMember = "CategoryId"; //seçtiğimde değeri catId den al


            }
        }

        private void cmkatlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cmkatlist.SelectedValue));

            }
            catch 
            {

            }
            
        }

        private void tproduct_TextChanged(object sender, EventArgs e)
        { string key = tproduct.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(tproduct.Text);
            }
           
        }
    }
}
