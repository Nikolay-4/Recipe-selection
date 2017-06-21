namespace app0._1
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
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkedListBoxProd = new System.Windows.Forms.CheckedListBox();
            this.panelRes = new System.Windows.Forms.Panel();
            this.sync = new System.Windows.Forms.Button();
            this.syncRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(12, 24);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Категория блюда";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkedListBoxProd
            // 
            this.checkedListBoxProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxProd.CheckOnClick = true;
            this.checkedListBoxProd.FormattingEnabled = true;
            this.checkedListBoxProd.Location = new System.Drawing.Point(12, 52);
            this.checkedListBoxProd.Name = "checkedListBoxProd";
            this.checkedListBoxProd.Size = new System.Drawing.Size(134, 394);
            this.checkedListBoxProd.TabIndex = 5;
            // 
            // panelRes
            // 
            this.panelRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRes.AutoScroll = true;
            this.panelRes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRes.Location = new System.Drawing.Point(153, 52);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(660, 394);
            this.panelRes.TabIndex = 6;
            // 
            // sync
            // 
            this.sync.Location = new System.Drawing.Point(248, 22);
            this.sync.Name = "sync";
            this.sync.Size = new System.Drawing.Size(75, 23);
            this.sync.TabIndex = 7;
            this.sync.Text = "обновить";
            this.sync.UseVisualStyleBackColor = true;
            this.sync.Click += new System.EventHandler(this.sync_Click);
            // 
            // syncRes
            // 
            this.syncRes.AutoSize = true;
            this.syncRes.Location = new System.Drawing.Point(350, 31);
            this.syncRes.Name = "syncRes";
            this.syncRes.Size = new System.Drawing.Size(0, 13);
            this.syncRes.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 460);
            this.Controls.Add(this.syncRes);
            this.Controls.Add(this.sync);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.checkedListBoxProd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox checkedListBoxProd;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.Button sync;
        private System.Windows.Forms.Label syncRes;
    }
}

