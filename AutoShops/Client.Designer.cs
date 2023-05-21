namespace AutoShops {
    partial class Client {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ThisOrder = new System.Windows.Forms.Button();
            this.RemoveAddEmpl = new System.Windows.Forms.Button();
            this.ViewParts = new System.Windows.Forms.Button();
            this.OrdersParts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cart = new System.Windows.Forms.Button();
            this.ViewProduct = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.Filtered = new System.Windows.Forms.GroupBox();
            this.NamesProduct = new System.Windows.Forms.TextBox();
            this.Addcart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.ViewExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.CategoryProduct = new System.Windows.Forms.ComboBox();
            this.CommentProduct = new System.Windows.Forms.TextBox();
            this.PriceProduct = new System.Windows.Forms.TextBox();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddCat = new System.Windows.Forms.Button();
            this.EditCate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CatName = new System.Windows.Forms.ComboBox();
            this.ControlClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProduct)).BeginInit();
            this.Filtered.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThisOrder
            // 
            this.ThisOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThisOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThisOrder.Location = new System.Drawing.Point(-1, 357);
            this.ThisOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ThisOrder.Name = "ThisOrder";
            this.ThisOrder.Size = new System.Drawing.Size(252, 69);
            this.ThisOrder.TabIndex = 4;
            this.ThisOrder.Text = "Текущие заказы";
            this.ThisOrder.UseVisualStyleBackColor = true;
            this.ThisOrder.Click += new System.EventHandler(this.ThisOrder_Click);
            // 
            // RemoveAddEmpl
            // 
            this.RemoveAddEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAddEmpl.Location = new System.Drawing.Point(-1, 282);
            this.RemoveAddEmpl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveAddEmpl.Name = "RemoveAddEmpl";
            this.RemoveAddEmpl.Size = new System.Drawing.Size(252, 69);
            this.RemoveAddEmpl.TabIndex = 3;
            this.RemoveAddEmpl.Text = "Добавить/удалить сотрудника";
            this.RemoveAddEmpl.UseVisualStyleBackColor = true;
            this.RemoveAddEmpl.Click += new System.EventHandler(this.RemoveAddEmpl_Click);
            // 
            // ViewParts
            // 
            this.ViewParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewParts.Location = new System.Drawing.Point(-2, 57);
            this.ViewParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewParts.Name = "ViewParts";
            this.ViewParts.Size = new System.Drawing.Size(252, 69);
            this.ViewParts.TabIndex = 2;
            this.ViewParts.Text = "Просмотр запчастей";
            this.ViewParts.UseVisualStyleBackColor = true;
            this.ViewParts.Click += new System.EventHandler(this.ViewParts_Click);
            // 
            // OrdersParts
            // 
            this.OrdersParts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OrdersParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersParts.Location = new System.Drawing.Point(-2, 132);
            this.OrdersParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrdersParts.Name = "OrdersParts";
            this.OrdersParts.Size = new System.Drawing.Size(252, 69);
            this.OrdersParts.TabIndex = 1;
            this.OrdersParts.Text = "Оформление заказа";
            this.OrdersParts.UseVisualStyleBackColor = false;
            this.OrdersParts.Click += new System.EventHandler(this.OrdersParts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действие с данными";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ControlClient);
            this.panel1.Controls.Add(this.Cart);
            this.panel1.Controls.Add(this.ThisOrder);
            this.panel1.Controls.Add(this.RemoveAddEmpl);
            this.panel1.Controls.Add(this.ViewParts);
            this.panel1.Controls.Add(this.OrdersParts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 658);
            this.panel1.TabIndex = 1;
            // 
            // Cart
            // 
            this.Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cart.Location = new System.Drawing.Point(-1, 207);
            this.Cart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(252, 69);
            this.Cart.TabIndex = 5;
            this.Cart.Text = "Корзина";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // ViewProduct
            // 
            this.ViewProduct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Category,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewProduct.Location = new System.Drawing.Point(256, 134);
            this.ViewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ViewProduct.Name = "ViewProduct";
            this.ViewProduct.RowTemplate.Height = 25;
            this.ViewProduct.Size = new System.Drawing.Size(544, 524);
            this.ViewProduct.TabIndex = 2;
            this.ViewProduct.Visible = false;
            this.ViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.ViewProduct.SelectionChanged += new System.EventHandler(this.ViewProduct_SelectionChanged);
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Название";
            this.NameItem.Name = "NameItem";
            this.NameItem.Width = 250;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(85, 25);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(121, 23);
            this.Categories.TabIndex = 3;
            this.Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Filtered
            // 
            this.Filtered.Controls.Add(this.NamesProduct);
            this.Filtered.Controls.Add(this.Addcart);
            this.Filtered.Controls.Add(this.label3);
            this.Filtered.Controls.Add(this.label2);
            this.Filtered.Controls.Add(this.Categories);
            this.Filtered.Location = new System.Drawing.Point(256, 0);
            this.Filtered.Name = "Filtered";
            this.Filtered.Size = new System.Drawing.Size(236, 128);
            this.Filtered.TabIndex = 4;
            this.Filtered.TabStop = false;
            this.Filtered.Text = "Фильтр";
            this.Filtered.Visible = false;
            // 
            // NamesProduct
            // 
            this.NamesProduct.Location = new System.Drawing.Point(85, 54);
            this.NamesProduct.Name = "NamesProduct";
            this.NamesProduct.Size = new System.Drawing.Size(121, 23);
            this.NamesProduct.TabIndex = 6;
            this.NamesProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Addcart
            // 
            this.Addcart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addcart.Location = new System.Drawing.Point(32, 83);
            this.Addcart.Name = "Addcart";
            this.Addcart.Size = new System.Drawing.Size(165, 34);
            this.Addcart.TabIndex = 5;
            this.Addcart.Text = "Добавить в корзину";
            this.Addcart.UseVisualStyleBackColor = false;
            this.Addcart.Visible = false;
            this.Addcart.Click += new System.EventHandler(this.Addcart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveProduct);
            this.groupBox1.Controls.Add(this.ViewExcel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.EditProduct);
            this.groupBox1.Controls.Add(this.CategoryProduct);
            this.groupBox1.Controls.Add(this.CommentProduct);
            this.groupBox1.Controls.Add(this.PriceProduct);
            this.groupBox1.Controls.Add(this.NameProduct);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(806, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 651);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информция/изменение товара";
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemoveProduct.Location = new System.Drawing.Point(6, 470);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(199, 52);
            this.RemoveProduct.TabIndex = 13;
            this.RemoveProduct.Text = "Удалить";
            this.RemoveProduct.UseVisualStyleBackColor = false;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // ViewExcel
            // 
            this.ViewExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewExcel.Location = new System.Drawing.Point(5, 414);
            this.ViewExcel.Name = "ViewExcel";
            this.ViewExcel.Size = new System.Drawing.Size(200, 50);
            this.ViewExcel.TabIndex = 12;
            this.ViewExcel.Text = "Выгрузить в Excel";
            this.ViewExcel.UseVisualStyleBackColor = false;
            this.ViewExcel.Click += new System.EventHandler(this.ViewExcel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(5, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить продукт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditProduct.Location = new System.Drawing.Point(5, 306);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(200, 46);
            this.EditProduct.TabIndex = 10;
            this.EditProduct.Text = "Изменить";
            this.EditProduct.UseVisualStyleBackColor = false;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // CategoryProduct
            // 
            this.CategoryProduct.FormattingEnabled = true;
            this.CategoryProduct.Location = new System.Drawing.Point(6, 277);
            this.CategoryProduct.Name = "CategoryProduct";
            this.CategoryProduct.Size = new System.Drawing.Size(199, 23);
            this.CategoryProduct.TabIndex = 9;
            // 
            // CommentProduct
            // 
            this.CommentProduct.Location = new System.Drawing.Point(6, 184);
            this.CommentProduct.Multiline = true;
            this.CommentProduct.Name = "CommentProduct";
            this.CommentProduct.Size = new System.Drawing.Size(199, 69);
            this.CommentProduct.TabIndex = 7;
            // 
            // PriceProduct
            // 
            this.PriceProduct.Location = new System.Drawing.Point(6, 131);
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(199, 23);
            this.PriceProduct.TabIndex = 6;
            // 
            // NameProduct
            // 
            this.NameProduct.Location = new System.Drawing.Point(6, 72);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(199, 23);
            this.NameProduct.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Категория:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Цена:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddCat);
            this.groupBox2.Controls.Add(this.EditCate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CatName);
            this.groupBox2.Location = new System.Drawing.Point(498, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 131);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Категории";
            // 
            // AddCat
            // 
            this.AddCat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddCat.Location = new System.Drawing.Point(158, 83);
            this.AddCat.Name = "AddCat";
            this.AddCat.Size = new System.Drawing.Size(136, 34);
            this.AddCat.TabIndex = 15;
            this.AddCat.Text = "Добавить";
            this.AddCat.UseVisualStyleBackColor = false;
            this.AddCat.Click += new System.EventHandler(this.AddCat_Click);
            // 
            // EditCate
            // 
            this.EditCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditCate.Location = new System.Drawing.Point(16, 83);
            this.EditCate.Name = "EditCate";
            this.EditCate.Size = new System.Drawing.Size(136, 34);
            this.EditCate.TabIndex = 14;
            this.EditCate.Text = "Изменить";
            this.EditCate.UseVisualStyleBackColor = false;
            this.EditCate.Click += new System.EventHandler(this.EditCate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Категория";
            // 
            // CatName
            // 
            this.CatName.FormattingEnabled = true;
            this.CatName.Location = new System.Drawing.Point(85, 25);
            this.CatName.Name = "CatName";
            this.CatName.Size = new System.Drawing.Size(198, 23);
            this.CatName.TabIndex = 7;
            this.CatName.SelectedIndexChanged += new System.EventHandler(this.CatName_SelectedIndexChanged);
            // 
            // ControlClient
            // 
            this.ControlClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlClient.Location = new System.Drawing.Point(-4, 432);
            this.ControlClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ControlClient.Name = "ControlClient";
            this.ControlClient.Size = new System.Drawing.Size(252, 69);
            this.ControlClient.TabIndex = 6;
            this.ControlClient.Text = "Управление клиентами";
            this.ControlClient.UseVisualStyleBackColor = true;
            this.ControlClient.Click += new System.EventHandler(this.ControlClient_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filtered);
            this.Controls.Add(this.ViewProduct);
            this.Controls.Add(this.panel1);
            this.Name = "Client";
            this.Text = "Client1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProduct)).EndInit();
            this.Filtered.ResumeLayout(false);
            this.Filtered.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ThisOrder;
        private Button RemoveAddEmpl;
        private Button ViewParts;
        private Button OrdersParts;
        private Label label1;
        private Panel panel1;
        private DataGridView ViewProduct;
        private DataGridViewTextBoxColumn NameItem;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private ComboBox Categories;
        private GroupBox Filtered;
        private Label label2;
        private Label label3;
        private TextBox NamesProduct;
        private Button Cart;
        private Button Addcart;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private ComboBox CategoryProduct;
        private TextBox CommentProduct;
        private TextBox PriceProduct;
        private TextBox NameProduct;
        private Label label8;
        private Label label6;
        private Button EditProduct;
        private Button button1;
        private Button ViewExcel;
        private Button RemoveProduct;
        private GroupBox groupBox2;
        private Button AddCat;
        private Button EditCate;
        private Label label7;
        private ComboBox CatName;
        private Button ControlClient;
    }
}