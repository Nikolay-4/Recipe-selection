namespace ProductJsonGen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.addCategoryTxt = new System.Windows.Forms.RichTextBox();
            this.addRecipeBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categDelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.categRecipeDelBtn = new System.Windows.Forms.Button();
            this.categoryRecipeListBox = new System.Windows.Forms.ListBox();
            this.addCategoryRecipeTxt = new System.Windows.Forms.RichTextBox();
            this.btnAddCategoryRecipe = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.delProdBtn = new System.Windows.Forms.Button();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.addProdTxt = new System.Windows.Forms.RichTextBox();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loadStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(5, 194);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(86, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "AddCategory";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // addCategoryTxt
            // 
            this.addCategoryTxt.Location = new System.Drawing.Point(6, 165);
            this.addCategoryTxt.Name = "addCategoryTxt";
            this.addCategoryTxt.Size = new System.Drawing.Size(181, 23);
            this.addCategoryTxt.TabIndex = 3;
            this.addCategoryTxt.Text = "";
            // 
            // addRecipeBtn
            // 
            this.addRecipeBtn.Location = new System.Drawing.Point(1095, 656);
            this.addRecipeBtn.Name = "addRecipeBtn";
            this.addRecipeBtn.Size = new System.Drawing.Size(104, 24);
            this.addRecipeBtn.TabIndex = 24;
            this.addRecipeBtn.Text = "Добавить рецепт";
            this.addRecipeBtn.UseVisualStyleBackColor = true;
            this.addRecipeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(1168, 11);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(86, 41);
            this.uploadBtn.TabIndex = 27;
            this.uploadBtn.Text = "Загрузить на GoogleDrive";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Location = new System.Drawing.Point(6, 25);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(181, 134);
            this.categoryListBox.TabIndex = 29;
            // 
            // categDelBtn
            // 
            this.categDelBtn.Location = new System.Drawing.Point(156, 194);
            this.categDelBtn.Name = "categDelBtn";
            this.categDelBtn.Size = new System.Drawing.Size(32, 23);
            this.categDelBtn.TabIndex = 30;
            this.categDelBtn.Text = "Del";
            this.categDelBtn.UseVisualStyleBackColor = true;
            this.categDelBtn.Click += new System.EventHandler(this.categDelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.categDelBtn);
            this.panel1.Controls.Add(this.categoryListBox);
            this.panel1.Controls.Add(this.addCategoryTxt);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 229);
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Категории продуктов";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.categRecipeDelBtn);
            this.panel2.Controls.Add(this.categoryRecipeListBox);
            this.panel2.Controls.Add(this.addCategoryRecipeTxt);
            this.panel2.Controls.Add(this.btnAddCategoryRecipe);
            this.panel2.Location = new System.Drawing.Point(593, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 229);
            this.panel2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Категории рецептов";
            // 
            // categRecipeDelBtn
            // 
            this.categRecipeDelBtn.Location = new System.Drawing.Point(156, 194);
            this.categRecipeDelBtn.Name = "categRecipeDelBtn";
            this.categRecipeDelBtn.Size = new System.Drawing.Size(32, 23);
            this.categRecipeDelBtn.TabIndex = 30;
            this.categRecipeDelBtn.Text = "Del";
            this.categRecipeDelBtn.UseVisualStyleBackColor = true;
            this.categRecipeDelBtn.Click += new System.EventHandler(this.categRecipeDelBtn_Click);
            // 
            // categoryRecipeListBox
            // 
            this.categoryRecipeListBox.FormattingEnabled = true;
            this.categoryRecipeListBox.Location = new System.Drawing.Point(6, 25);
            this.categoryRecipeListBox.Name = "categoryRecipeListBox";
            this.categoryRecipeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.categoryRecipeListBox.Size = new System.Drawing.Size(181, 134);
            this.categoryRecipeListBox.TabIndex = 29;
            // 
            // addCategoryRecipeTxt
            // 
            this.addCategoryRecipeTxt.Location = new System.Drawing.Point(6, 165);
            this.addCategoryRecipeTxt.Name = "addCategoryRecipeTxt";
            this.addCategoryRecipeTxt.Size = new System.Drawing.Size(181, 23);
            this.addCategoryRecipeTxt.TabIndex = 3;
            this.addCategoryRecipeTxt.Text = "";
            // 
            // btnAddCategoryRecipe
            // 
            this.btnAddCategoryRecipe.Location = new System.Drawing.Point(5, 194);
            this.btnAddCategoryRecipe.Name = "btnAddCategoryRecipe";
            this.btnAddCategoryRecipe.Size = new System.Drawing.Size(86, 23);
            this.btnAddCategoryRecipe.TabIndex = 0;
            this.btnAddCategoryRecipe.Text = "AddCategory";
            this.btnAddCategoryRecipe.UseVisualStyleBackColor = true;
            this.btnAddCategoryRecipe.Click += new System.EventHandler(this.btnAddCategoryRecipe_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.delProdBtn);
            this.panel3.Controls.Add(this.productListBox);
            this.panel3.Controls.Add(this.addProdTxt);
            this.panel3.Controls.Add(this.addProdBtn);
            this.panel3.Location = new System.Drawing.Point(235, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 229);
            this.panel3.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Продукты";
            // 
            // delProdBtn
            // 
            this.delProdBtn.Location = new System.Drawing.Point(156, 194);
            this.delProdBtn.Name = "delProdBtn";
            this.delProdBtn.Size = new System.Drawing.Size(32, 23);
            this.delProdBtn.TabIndex = 30;
            this.delProdBtn.Text = "Del";
            this.delProdBtn.UseVisualStyleBackColor = true;
            this.delProdBtn.Click += new System.EventHandler(this.delProdBtn_Click);
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(6, 25);
            this.productListBox.Name = "productListBox";
            this.productListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.productListBox.Size = new System.Drawing.Size(181, 134);
            this.productListBox.TabIndex = 29;
            // 
            // addProdTxt
            // 
            this.addProdTxt.Location = new System.Drawing.Point(6, 165);
            this.addProdTxt.Name = "addProdTxt";
            this.addProdTxt.Size = new System.Drawing.Size(181, 23);
            this.addProdTxt.TabIndex = 3;
            this.addProdTxt.Text = "";
            // 
            // addProdBtn
            // 
            this.addProdBtn.Location = new System.Drawing.Point(5, 194);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(86, 23);
            this.addProdBtn.TabIndex = 0;
            this.addProdBtn.Text = "Add";
            this.addProdBtn.UseVisualStyleBackColor = true;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Location = new System.Drawing.Point(16, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1257, 378);
            this.panel4.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1214, 657);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Del";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(543, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Рецепты";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(441, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 41);
            this.label2.TabIndex = 37;
            this.label2.Text = "Для добавния продукта нужно выбрать категорию слева и ввести название";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1168, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "сохранить все данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loadStatus
            // 
            this.loadStatus.AutoSize = true;
            this.loadStatus.Location = new System.Drawing.Point(1044, 25);
            this.loadStatus.Name = "loadStatus";
            this.loadStatus.Size = new System.Drawing.Size(89, 13);
            this.loadStatus.TabIndex = 39;
            this.loadStatus.Text = "статус загрузки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 692);
            this.Controls.Add(this.loadStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.addRecipeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.RichTextBox addCategoryTxt;
        private System.Windows.Forms.Button addRecipeBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Button categDelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button categRecipeDelBtn;
        private System.Windows.Forms.ListBox categoryRecipeListBox;
        private System.Windows.Forms.RichTextBox addCategoryRecipeTxt;
        private System.Windows.Forms.Button btnAddCategoryRecipe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delProdBtn;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.RichTextBox addProdTxt;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox _prod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loadStatus;
    }
}

