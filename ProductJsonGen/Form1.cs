using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Windows;

namespace ProductJsonGen
{
    public partial class Form1 : Form
    {
        TextBox _name;
        TextBox _descr;
        TextBox _prev;
        CheckedListBox _categories;
        TextBox _number;
        TextBox _caloricity;

        List<Category> CategoryList;
        List<CategoryRecipe> CategoryRecipeList;
        List<Product> ProductList;
        List<Recipe> RecipeList;
        string[] prodListBoxText;
        CheckBox[] recipeCheck;
        List<string> checkedProductList = new List<string>();
        List<TextBox> checkedProportion = new List<TextBox>();
        List<TextBox> checkedUnit = new List<TextBox>();
        List<string> categoryRecipeListTxt = new List<string>();


        public Form1()
        {
            checkedProductList = new List<string>();
            CategoryList = JsonRW.readCategory();
            CategoryRecipeList = JsonRW.readCategoryRecipe();
            ProductList = JsonRW.readProduct();
            RecipeList = JsonRW.readRecipe();
            InitializeComponent();

            showCategList();
            showCategRecipeList();
            showProductList();
            showRecipes();

        }

        private int getIndexCategoryName(string catName)
        {
            for (int i = 0; i < CategoryList.Count; i++)
                if (CategoryList[i].name == catName)
                    return i;
            return -1;
        }

        private int getIndexCategoryRecipeName(string catName)
        {
            for (int i = 0; i < CategoryRecipeList.Count; i++)
                if (CategoryRecipeList[i].name == catName)
                    return i;
            return -1;
        }

        private int getIndexCategoryId(int id)
        {
            for (int i = 0; i < CategoryList.Count; i++)
                if (CategoryList[i].id == id)
                    return i;
            return -1;
        }

        private int getIndexProductListBoxText(string text)
        {
            return Array.IndexOf<string>(prodListBoxText, text);
        }

        private void showCategList()
        {
            string[] list = new string[CategoryList.Count];
            for (int i = 0; i < CategoryList.Count; i++)
            {
                list[i] = CategoryList[i].name;

            }
            categoryListBox.DataSource = list;
        }

        private void showCategRecipeList()
        {
            categoryRecipeListTxt = new List<string>();
            for (int i = 0; i < CategoryRecipeList.Count; i++)
            {
                categoryRecipeListTxt.Add(CategoryRecipeList[i].name);
            }
            categoryRecipeListBox.DataSource = categoryRecipeListTxt;
        }

        private void showProductList()
        {
            string[] list = new string[ProductList.Count];
            for (int i = 0; i < ProductList.Count; i++)
            {
                int catId = getIndexCategoryId(ProductList[i].category_id);
                if (catId < 0)
                {
                    throw new Exception("undefine category");
                }
                list[i] = ProductList[i].name + " (" + CategoryList[catId].name + ")";
            }
            prodListBoxText = list;
            productListBox.DataSource = list;
        }

        private void showRecipes()
        {
            panel4.Controls.Clear();
            int lableArea = 25;
            int _yLable = 0;
            int _x = 10;
            int _y = lableArea;
            int margin = 10;
            int height = 200;
            recipeCheck = new CheckBox[RecipeList.Count];
            for (int i = 0; i < RecipeList.Count; i++)
            {
                Label nameLabel = new Label();
                nameLabel.Location = new Point(_x, _yLable);
                nameLabel.Text = "название";
                nameLabel.Parent = panel4;


                TextBox name = new TextBox();
                name.Multiline = true;
                name.Name = "recipeTxt" + i;
                name.ScrollBars = ScrollBars.Both;
                name.Text = RecipeList[i].name;
                name.Location = new Point(_x, _y);
                name.Parent = panel4;
                name.Width = 100;
                name.Height = height;

                Label descrLabel = new Label();
                descrLabel.Location = new Point(name.Location.X + name.Width + margin, _yLable);
                descrLabel.Text = "описание";
                descrLabel.Parent = panel4;


                TextBox descr = new TextBox();
                descr.Multiline = true;
                descr.Name = "recipeDeskTxt" + i;
                descr.Text = RecipeList[i].description;
                Point p = new Point(name.Location.X + name.Width + margin, _y);
                descr.Location = p;
                descr.Width = 200;
                descr.Height = height;
                descr.Parent = panel4;
                descr.ScrollBars = ScrollBars.Vertical;

                Label prevLabel = new Label();
                prevLabel.Location = new Point(descr.Location.X + descr.Width + margin, _yLable);
                prevLabel.Text = "превью";
                prevLabel.Parent = panel4;


                TextBox prev = new TextBox();
                prev.Multiline = true;
                prev.Name = "recipePrevTxt" + i;
                prev.Text = RecipeList[i].preview;
                prev.Location = new Point(descr.Location.X + descr.Width + margin, _y); ;
                prev.Width = 200;
                prev.Height = height;
                prev.Parent = panel4;
                prev.ScrollBars = ScrollBars.Vertical;

                Label prodLabel = new Label();
                prodLabel.Location = new Point(prev.Location.X + prev.Width + margin, _yLable);
                prodLabel.Text = "продукты";
                prodLabel.Parent = panel4;


                ListBox prod = new ListBox();
                prod.DataSource = RecipeList[i].products;
                prod.Height = height;
                prod.Location = new Point(prev.Location.X + prev.Width + margin, _y);
                prod.Parent = panel4;

                Label productCntLabel = new Label();
                productCntLabel.Location = new Point(prod.Location.X + prod.Width + margin, _yLable);
                productCntLabel.Text = "пропорция";
                productCntLabel.Width = 70;
                productCntLabel.Parent = panel4;


                ListBox productCnt = new ListBox();
                productCnt.DataSource = RecipeList[i].productsCnt;
                productCnt.Height = height;
                productCnt.Location = new Point(prod.Location.X + prod.Width + margin, _y);
                productCnt.Parent = panel4;
                productCnt.Width = 70;

                Label unitLabel = new Label();
                unitLabel.Location = new Point(productCnt.Location.X + productCnt.Width + margin, _yLable);
                unitLabel.Text = "ед. изм";
                unitLabel.Width = 50;
                unitLabel.Parent = panel4;


                ListBox productsUnit = new ListBox();
                productsUnit.DataSource = RecipeList[i].productsUnit;
                productsUnit.Height = height;
                productsUnit.Location = new Point(productCnt.Location.X + productCnt.Width + margin, _y);
                productsUnit.Parent = panel4;
                productsUnit.Width = 50;

                Label categoriesLabel = new Label();
                categoriesLabel.Location = new Point(productsUnit.Location.X + productsUnit.Width + margin, _yLable);
                categoriesLabel.Text = "кат. рецепта";
                categoriesLabel.Parent = panel4;


                ListBox categories = new ListBox();
                categories.DataSource = RecipeList[i].categories;
                categories.Height = height;
                categories.Location = new Point(productsUnit.Location.X + productsUnit.Width + margin, _y);
                categories.Parent = panel4;

                Label numberLabel = new Label();
                numberLabel.Location = new Point(categories.Location.X + categories.Width + margin, _yLable);
                numberLabel.Text = "число порций";
                numberLabel.Parent = panel4;

                TextBox number = new TextBox();
                number.Text = RecipeList[i].number.ToString();
                number.Location = new Point(categories.Location.X + categories.Width + margin, _y); ;
                number.Width = 40;
                number.Height = height;
                number.Parent = panel4;

                Label calorLabel = new Label();
                calorLabel.Location = new Point(number.Location.X, number.Location.Y + number.Height + margin);
                calorLabel.Text = "калорийность";
                calorLabel.Parent = panel4;

                TextBox calorTextBox = new TextBox();
                calorTextBox.Text = RecipeList[i].caloricity.ToString();
                calorTextBox.Location = new Point(number.Location.X, calorLabel.Location.Y + calorLabel.Height);
                calorTextBox.Width = 40;
                calorTextBox.Height = height;
                calorTextBox.Parent = panel4;

                CheckBox checkbox = new CheckBox();
                checkbox.Location = new Point(number.Location.X + number.Width + margin, _y);
                checkbox.Parent = panel4;

                recipeCheck[i] = checkbox;

                _y += height + lableArea + margin;
                _yLable += height + lableArea + margin;

            }

            _name = new TextBox();
            _name.Multiline = true;
            _name.Name = "addRecipeName";
            _name.ScrollBars = ScrollBars.Both;
            _name.Location = new Point(_x, _y);
            _name.Parent = panel4;
            _name.Width = 100;
            _name.Height = height;

            _descr = new TextBox();
            _descr.Multiline = true;
            _descr.Name = "addRecipeDesk";
            Point _p = new Point(_name.Location.X + _name.Width + margin, _y);
            _descr.Location = _p;
            _descr.Width = 200;
            _descr.Height = height;
            _descr.Parent = panel4;
            _descr.ScrollBars = ScrollBars.Vertical;

            _prev = new TextBox();
            _prev.Multiline = true;
            _prev.Name = "addRecipePrev";
            _prev.Location = new Point(_descr.Location.X + _descr.Width + margin, _y); ;
            _prev.Width = 200;
            _prev.Height = height;
            _prev.Parent = panel4;
            _prev.ScrollBars = ScrollBars.Vertical;

            _prod = new CheckedListBox();
            _prod.Name = "addRecipeProd";
            string[] _tmp = new string[prodListBoxText.Length];
            Array.Copy(prodListBoxText, _tmp, prodListBoxText.Length);
            _prod.HorizontalScrollbar = true;
            _prod.Width = 200;
            _prod.DataSource = _tmp;
            _prod.Height = height;
            _prod.Location = new Point(_prev.Location.X + _prev.Width + margin, _y);
            _prod.Parent = panel4;
            _prod.Click += changeCheckedListBox;

            // вывод выбраных продуктов для рецепта
            //панель для вывода пропорции и ед. изм. выбранных продуктов
            panel5.Location = new Point(_prod.Location.X + _prod.Width + 10, _y);
            panel5.Width = 200;
            panel5.Height = height;
            panel5.Parent = panel4;
            panel5.AutoScroll = true;
            showPanel5();
           
           

            
            _categories = new CheckedListBox();
            
            _categories.DataSource = categoryRecipeListTxt.ToArray();
            _categories.Height = height;
            _categories.Location = new Point(panel5.Location.X + panel5.Width + margin, _y);
            _categories.Parent = panel4;

            Label _numberLabel = new Label();
            _numberLabel.Location = new Point(_categories.Location.X + _categories.Width + margin, _y);
            _numberLabel.Text = "порций";
            _numberLabel.Parent = panel4;

            _number = new TextBox();
            _number.Location = new Point(_categories.Location.X + _categories.Width + margin, _numberLabel.Location.Y + _numberLabel.Height);
            _number.Width = 40;
            _number.Height = height;
            _number.Parent = panel4;

            Label _caloricityLabel = new Label();
            _caloricityLabel.Location = new Point(_number.Location.X, _number.Location.Y + _number.Height + margin);
            _caloricityLabel.Text = "калорийность";
            _caloricityLabel.Parent = panel4;

            _caloricity = new TextBox();
            _caloricity.Location = new Point(_number.Location.X, _caloricityLabel.Location.Y + _caloricityLabel.Height);
            _caloricity.Width = 40;
            _caloricity.Parent = panel4;

        }

        private void showPanel5()
        {
            panel5.Controls.Clear();
           

            checkedProportion.Clear();
            checkedUnit.Clear();

            Label _propUnitLable = new Label();
            _propUnitLable.Location = new Point(100, 0);
            _propUnitLable.Width = 100;
            _propUnitLable.Text = "пропорция/ед. изм";
            _propUnitLable.Parent = panel5;
            int curY = 25;

            for (int i = 0; i < checkedProductList.Count; i++)
            {
                Label _lab = new Label();
                _lab.Location = new Point(0, curY);
                _lab.Text = checkedProductList[i]; // название продукта
                _lab.Width = 100;
                _lab.Parent = panel5;

                TextBox _proportion = new TextBox(); // пропорция
                _proportion.Width = 50;
                _proportion.Location = new Point(_lab.Location.X + _lab.Width, curY);
                _proportion.Parent = panel5;
                checkedProportion.Add(_proportion);

                TextBox _unit = new TextBox(); // единицы измерения
                _unit.Location = new Point(_proportion.Location.X + _proportion.Width, curY);
                _unit.Width = 50;
                checkedUnit.Add(_unit);
                _unit.Parent = panel5;
                curY += _unit.Height + 2;

            }
        }

        

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = addCategoryTxt.Text;
            int id = (CategoryList.Count > 0) ? CategoryList[CategoryList.Count - 1].id + 1 : 0;
            CategoryList.Add(new Category(newCategory, id));
            categoryListBox.DataSource = CategoryList;
            showCategList();
            showRecipes();
        }


        private void btnAddCategoryRecipe_Click(object sender, EventArgs e)
        {
            string newCategoryR = addCategoryRecipeTxt.Text;
            int id = (CategoryRecipeList.Count > 0) ? CategoryRecipeList[CategoryRecipeList.Count - 1].id + 1 : 0;
            CategoryRecipeList.Add(new CategoryRecipe(newCategoryR, id));
            categoryRecipeListBox.DataSource = CategoryRecipeList;
            showCategRecipeList();
            showRecipes();
        }

        private void changeCheckedListBox(object sender, EventArgs e)
        {
            var _checkedList = _prod.CheckedItems;
            checkedProductList.Clear();
            foreach(var i in _checkedList)
            {
                checkedProductList.Add(i.ToString());
            }
            showPanel5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string description = _descr.Text;
            string preview = _prev.Text;
            double calor;
            bool calorBool = Double.TryParse(_caloricity.Text, out calor);

            List<string> products = new List<string>();
            for(int i = 0; i < _prod.CheckedItems.Count; i++)
                products.Add(_prod.CheckedItems[i].ToString());

            List<string> categories = new List<string>();
            foreach (var i in _categories.CheckedItems)
                categories.Add(i.ToString());

            List<double> proportion = new List<double>();
            bool proportionBool = false;
            foreach (var i in checkedProportion)
            {
                double tmp;
                proportionBool = Double.TryParse(i.Text, out tmp);
                if (!proportionBool)
                    break;
                proportion.Add(tmp);
            }

            List<string> productsUnit = new List<string>();
            foreach(var i in checkedUnit)
            {
                productsUnit.Add(i.Text);
            }

            int number;
            bool numberBool = Int32.TryParse(_number.Text, out number);

            if((name.Length == 0)
                || (description.Length == 0) || (description.Length > 10000)
                || (preview.Length == 0) || (preview.Length > 2000)
                || (!calorBool)
                || (products.Count == 0)
                || (categories.Count == 0)
                || (!proportionBool)
                || (productsUnit.Count == 0)
                || (!numberBool)
                )
            {
                MessageBox.Show("введены недопустимые данные");
                return;
            }
            int id = RecipeList.Count;
            Recipe newRecipe = new Recipe(name, description, preview, number, products, proportion, productsUnit, calor, categories, id);
            RecipeList.Add(newRecipe);
            showRecipes();

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            bool status = Sync.upload();
            loadStatus.Text = (status) ? "complete" : "fail";
        }

        private void categDelBtn_Click(object sender, EventArgs e)
        {
            string item = categoryListBox.SelectedItem.ToString();
            int itemInd = getIndexCategoryName(item);
            CategoryList.RemoveAt(itemInd);
            showCategList();
            showRecipes();
        }

        private void categRecipeDelBtn_Click(object sender, EventArgs e)
        {
            string item = categoryRecipeListBox.SelectedItem.ToString();
            int itemInd = getIndexCategoryRecipeName(item);
            CategoryRecipeList.RemoveAt(itemInd);
            showCategRecipeList();
            showRecipes();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            string newProduct = addProdTxt.Text;
            int id;
            if (ProductList.Count == 0)
                id = 0;
            else
                id = ProductList[ProductList.Count - 1].id + 1;
            int catInd = getIndexCategoryName(categoryListBox.SelectedItem.ToString());
            ProductList.Add(new Product(newProduct, CategoryList[catInd].id, id));
            productListBox.DataSource = ProductList;
            showProductList();
            showRecipes();
        }

        private void delProdBtn_Click(object sender, EventArgs e)
        {
            var items = productListBox.SelectedItems;
            foreach (var i in items)
            {
                string text = i.ToString();
                int ind = getIndexProductListBoxText(text);
                ProductList.RemoveAt(ind);
                showProductList();

            }
            showRecipes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recipe[] tmp = RecipeList.ToArray();


            for (int i = 0; i < recipeCheck.Length; i++)
            {
                if (recipeCheck[i].Checked)
                {
                    RecipeList.Remove(tmp[i]);
                }
            }
            showRecipes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!JsonRW.writeCategory(CategoryList))
                MessageBox.Show("ошибка записи категорий продуктов");

            if(!JsonRW.writeCategoryRecipe(CategoryRecipeList))
                MessageBox.Show("ошибка записи категорий рецептов");

            if(!JsonRW.writeProduct(ProductList))
                MessageBox.Show("ошибка записи продуктов");

            if(!JsonRW.writeRecipe(RecipeList))
                MessageBox.Show("ошибка записи рецептов");
        }
    }
}
