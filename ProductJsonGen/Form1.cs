using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace ProductJsonGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteCategory_Click(object sender, EventArgs e)
        {
            string txt = txtCategory.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = new List<Category>();

            res.Add(new Category("Другое", 500));
            int ind = 1;
            foreach (string i in arr)
            {
                res.Add(new Category(i, ind++));
            }
            JsonRW.writeCategory(res);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string txt = txtCategory.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = JsonRW.readCategory();

            int ind = res.Count;
            foreach (string i in arr)
            {
                res.Add(new Category(i, ind++));
            }
            JsonRW.writeCategory(res);
        }

        private void WriteCategoryR_Click(object sender, EventArgs e)
        {
            string txt = txtCategoryR.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = new List<CategoryRecipe>();

            int ind = 0;
            foreach (string i in arr)
            {
                res.Add(new CategoryRecipe(i, ind++));
            }
            JsonRW.writeCategoryRecipe(res);
        }

        private void AddCategoryR_Click(object sender, EventArgs e)
        {
            string txt = txtCategory.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = JsonRW.readCategoryRecipe();

            int ind = res.Count;
            foreach (string i in arr)
            {
                res.Add(new CategoryRecipe(i, ind++));
            }
            JsonRW.writeCategoryRecipe(res);
        }

        private void btnWriteProd_Click(object sender, EventArgs e)
        {
            string txt = txtProduct.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = new List<Product>();

            int ind = 0;
            foreach (string i in arr)
            {
                var t = i.Split(new Char[] { ';' });
                res.Add(new Product(t[0], Convert.ToInt32(t[1]), ind++));
            }
            JsonRW.writeProduct(res);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            string txt = txtProduct.Text;
            var arr = txt.Split(new Char[] { '\n' });
            var res = JsonRW.readProduct();

            int ind = 0;
            foreach (string i in arr)
            {
                var t = i.Split(new Char[] { ';' });
                res.Add(new Product(t[0], Convert.ToInt32(t[1]),ind++));
            }
            JsonRW.writeProduct(res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = txtProduct.Text;
            var res = JsonRW.readRecipe();
            string name = txtName.Text;
            string description = txtDescription.Text;
            string preview = txtPreview.Text;
            double caloricity = Convert.ToDouble(txtCal.Text.Replace('.', ','));

            List<string> categories = new List<string>();
            var ar1 = txtListCategory.Text.Split(new Char[] { '\n' });
            foreach (string i in ar1)
            {
                categories.Add(i);
            }

            List<string> products = new List<string>();
            List<double> productsCnt = new List<double>();
            List<string> productsUnit = new List<string>();
            var ar2 = txtListProd.Text.Split(new Char[] { '\n' });
            foreach (string i in ar2)
            {
                var t = i.Split(new Char[] { ';' });
                if (t.Length < 3)
                    continue;
                products.Add(t[0]);
                productsCnt.Add(Convert.ToDouble(t[1].Replace('.', ',')));
                productsUnit.Add(t[2]);
            }

            int num = Convert.ToInt32(txtNum.Text);

            res.Add(new Recipe(name, description, preview, num, products, productsCnt, productsUnit, caloricity, categories, res.Count));

            JsonRW.writeRecipe(res);
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            bool status = Sync.upload();
            uplStatusLabl.Text = (status) ? "complete" : "fail";
        }
    }
}
