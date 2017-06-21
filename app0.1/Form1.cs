using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app0._1
{
    public partial class Form1 : Form
    {
        List<Product> listProduct;
        List<Category> listCategory;
        List<CategoryRecipe> listCategoryRecipe;
        List<Recipe> listRecipe;
        List<Recipe> resSearch;
        List<string> checkedProd;
        public Form1()
        {
            InitializeComponent();
            listProduct = JsonRW.readProduct();
            listCategory = JsonRW.readCategory();
            listCategoryRecipe = JsonRW.readCategoryRecipe();
            listRecipe = JsonRW.readRecipe();
            checkedProd = new List<string>();
            foreach (var i in listCategoryRecipe)
            {
                comboBoxCat.Items.Add(i.name);
            }
            comboBoxCat.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (var i in listProduct)
            {
                checkedListBoxProd.Items.Add(i.name);
            }
            checkedListBoxProd.Sorted = true;
        }

        

        private void runSearch(int indCat, string nameCat)
        {
            resSearch = new List<Recipe>();
            List<Recipe> res0 = new List<Recipe>(), res1 = new List<Recipe>(), res2 = new List<Recipe>();
            foreach (var i in listRecipe)
            {
                if(indCat != -1)
                {
                    bool flag = false;
                    foreach (string j in i.categories)
                    {
                        if (j == nameCat)
                            flag = true;
                    }
                    if (!flag)
                        continue;
                }
                int delta = 0;
                foreach (string j in i.products)
                {
                    bool flag = false;
                    foreach (string k in checkedProd)
                    {
                        if (k == j)
                            flag = true;
                    }
                    if (!flag)
                        ++delta;
                }
                if (delta == 0)
                {
                    res0.Add(i);
                } else if (delta == 1)
                {
                    res1.Add(i);
                }
                else if (delta == 2)
                {
                    res2.Add(i);
                }
            }
            foreach (var i in res0)
            {
                resSearch.Add(i);
            }
            foreach (var i in res1)
            {
                resSearch.Add(i);
            }
            foreach (var i in res2)
            {
                resSearch.Add(i);
            }
        }

        private void addPanel()
        {
            int topSize = 0;
            foreach (var i in resSearch)
            {
                var let = new UserControl1(i);
                let.Visible = true;
                let.Enabled = true;
                let.Top = topSize;
                topSize += let.Height + 1;
                panelRes.Controls.Add(let);
                
            }
            UserControl1.ctrl = panelRes.Controls;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int indCat = comboBoxCat.SelectedIndex;
            string nameCat = (indCat == -1 ? "-" : comboBoxCat.SelectedItem.ToString());
            for (int i = 0; i < checkedListBoxProd.Items.Count; i++)
            {
                if (checkedListBoxProd.GetItemChecked(i))
                {
                    checkedProd.Add(checkedListBoxProd.Items[i].ToString());
                }
            }
            runSearch(indCat, nameCat);
            
            addPanel();

        }

        private void sync_Click(object sender, EventArgs e)
        {
            bool syncResult = Sync.run();
            syncRes.Text = (syncResult) ? "updated" : "fail";
        }
    }
}
