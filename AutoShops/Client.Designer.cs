namespace AutoShops
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ThisOrder = new Button();
            RemoveAddEmpl = new Button();
            ViewParts = new Button();
            OrdersParts = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            ControlClient = new Button();
            Cart = new Button();
            ViewProduct = new DataGridView();
            NameItem = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Атикль = new DataGridViewTextBoxColumn();
            Categories = new ComboBox();
            Filtered = new GroupBox();
            NamesProduct = new TextBox();
            Addcart = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label9 = new Label();
            RemoveProduct = new Button();
            ViewExcel = new Button();
            button1 = new Button();
            EditProduct = new Button();
            CategoryProduct = new ComboBox();
            CommentProduct = new TextBox();
            PriceProduct = new TextBox();
            NameProduct = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            AddCat = new Button();
            EditCate = new Button();
            label7 = new Label();
            CatName = new ComboBox();
            label10 = new Label();
            ProdCount = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewProduct).BeginInit();
            Filtered.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ThisOrder
            // 
            ThisOrder.BackgroundImageLayout = ImageLayout.Stretch;
            ThisOrder.FlatStyle = FlatStyle.Flat;
            ThisOrder.Location = new Point(-1, 476);
            ThisOrder.Margin = new Padding(5, 4, 5, 4);
            ThisOrder.Name = "ThisOrder";
            ThisOrder.Size = new Size(288, 92);
            ThisOrder.TabIndex = 4;
            ThisOrder.Text = "Текущие заказы";
            ThisOrder.UseVisualStyleBackColor = true;
            ThisOrder.Click += ThisOrder_Click;
            // 
            // RemoveAddEmpl
            // 
            RemoveAddEmpl.FlatStyle = FlatStyle.Flat;
            RemoveAddEmpl.Location = new Point(-1, 376);
            RemoveAddEmpl.Margin = new Padding(5, 4, 5, 4);
            RemoveAddEmpl.Name = "RemoveAddEmpl";
            RemoveAddEmpl.Size = new Size(288, 92);
            RemoveAddEmpl.TabIndex = 3;
            RemoveAddEmpl.Text = "Добавить/удалить сотрудника";
            RemoveAddEmpl.UseVisualStyleBackColor = true;
            RemoveAddEmpl.Click += RemoveAddEmpl_Click;
            // 
            // ViewParts
            // 
            ViewParts.FlatStyle = FlatStyle.Flat;
            ViewParts.Location = new Point(-2, 76);
            ViewParts.Margin = new Padding(5, 4, 5, 4);
            ViewParts.Name = "ViewParts";
            ViewParts.Size = new Size(288, 92);
            ViewParts.TabIndex = 2;
            ViewParts.Text = "Просмотр запчастей";
            ViewParts.UseVisualStyleBackColor = true;
            ViewParts.Click += ViewParts_Click;
            // 
            // OrdersParts
            // 
            OrdersParts.BackColor = SystemColors.InactiveCaption;
            OrdersParts.FlatStyle = FlatStyle.Flat;
            OrdersParts.Location = new Point(-2, 176);
            OrdersParts.Margin = new Padding(5, 4, 5, 4);
            OrdersParts.Name = "OrdersParts";
            OrdersParts.Size = new Size(288, 92);
            OrdersParts.TabIndex = 1;
            OrdersParts.Text = "Оформление заказа";
            OrdersParts.UseVisualStyleBackColor = false;
            OrdersParts.Click += OrdersParts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-5, 11);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 29);
            label1.TabIndex = 0;
            label1.Text = "Действие с данными";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ControlClient);
            panel1.Controls.Add(Cart);
            panel1.Controls.Add(ThisOrder);
            panel1.Controls.Add(RemoveAddEmpl);
            panel1.Controls.Add(ViewParts);
            panel1.Controls.Add(OrdersParts);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 877);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(-5, 748);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(288, 92);
            button3.TabIndex = 8;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-6, 748);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(288, 92);
            button2.TabIndex = 7;
            button2.Text = "Авторизоваться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ControlClient
            // 
            ControlClient.BackgroundImageLayout = ImageLayout.Stretch;
            ControlClient.FlatStyle = FlatStyle.Flat;
            ControlClient.Location = new Point(-5, 576);
            ControlClient.Margin = new Padding(5, 4, 5, 4);
            ControlClient.Name = "ControlClient";
            ControlClient.Size = new Size(288, 92);
            ControlClient.TabIndex = 6;
            ControlClient.Text = "Управление клиентами";
            ControlClient.UseVisualStyleBackColor = true;
            ControlClient.Click += ControlClient_Click;
            // 
            // Cart
            // 
            Cart.BackgroundImageLayout = ImageLayout.Stretch;
            Cart.FlatStyle = FlatStyle.Flat;
            Cart.Location = new Point(-1, 276);
            Cart.Margin = new Padding(5, 4, 5, 4);
            Cart.Name = "Cart";
            Cart.Size = new Size(288, 92);
            Cart.TabIndex = 5;
            Cart.Text = "Корзина";
            Cart.UseVisualStyleBackColor = true;
            Cart.Click += Cart_Click;
            // 
            // ViewProduct
            // 
            ViewProduct.BackgroundColor = SystemColors.ControlLight;
            ViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewProduct.Columns.AddRange(new DataGridViewColumn[] { NameItem, Category, Price, Атикль });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 4, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewProduct.DefaultCellStyle = dataGridViewCellStyle2;
            ViewProduct.Location = new Point(293, 179);
            ViewProduct.Margin = new Padding(0);
            ViewProduct.Name = "ViewProduct";
            ViewProduct.RowHeadersWidth = 51;
            ViewProduct.RowTemplate.Height = 25;
            ViewProduct.Size = new Size(622, 699);
            ViewProduct.TabIndex = 2;
            ViewProduct.Visible = false;
            ViewProduct.CellContentClick += dataGridView1_CellClick;
            ViewProduct.SelectionChanged += ViewProduct_SelectionChanged;
            // 
            // NameItem
            // 
            NameItem.HeaderText = "Название";
            NameItem.MinimumWidth = 6;
            NameItem.Name = "NameItem";
            NameItem.Width = 150;
            // 
            // Category
            // 
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Атикль
            // 
            Атикль.HeaderText = "Атикль";
            Атикль.MinimumWidth = 6;
            Атикль.Name = "Атикль";
            Атикль.Width = 125;
            // 
            // Categories
            // 
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(144, 33);
            Categories.Margin = new Padding(3, 4, 3, 4);
            Categories.Name = "Categories";
            Categories.Size = new Size(138, 28);
            Categories.TabIndex = 3;
            Categories.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Filtered
            // 
            Filtered.Controls.Add(NamesProduct);
            Filtered.Controls.Add(Addcart);
            Filtered.Controls.Add(label3);
            Filtered.Controls.Add(label2);
            Filtered.Controls.Add(Categories);
            Filtered.Location = new Point(293, 0);
            Filtered.Margin = new Padding(3, 4, 3, 4);
            Filtered.Name = "Filtered";
            Filtered.Padding = new Padding(3, 4, 3, 4);
            Filtered.Size = new Size(288, 171);
            Filtered.TabIndex = 4;
            Filtered.TabStop = false;
            Filtered.Text = "Фильтр";
            Filtered.Visible = false;
            // 
            // NamesProduct
            // 
            NamesProduct.Location = new Point(144, 72);
            NamesProduct.Margin = new Padding(3, 4, 3, 4);
            NamesProduct.Name = "NamesProduct";
            NamesProduct.Size = new Size(138, 27);
            NamesProduct.TabIndex = 6;
            NamesProduct.TextChanged += textBox1_TextChanged;
            // 
            // Addcart
            // 
            Addcart.BackColor = SystemColors.ActiveCaption;
            Addcart.Location = new Point(37, 111);
            Addcart.Margin = new Padding(3, 4, 3, 4);
            Addcart.Name = "Addcart";
            Addcart.Size = new Size(189, 45);
            Addcart.TabIndex = 5;
            Addcart.Text = "Добавить в корзину";
            Addcart.UseVisualStyleBackColor = false;
            Addcart.Visible = false;
            Addcart.Click += Addcart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 76);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Название/Артикль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 37);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Категория";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ProdCount);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(RemoveProduct);
            groupBox1.Controls.Add(ViewExcel);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(EditProduct);
            groupBox1.Controls.Add(CategoryProduct);
            groupBox1.Controls.Add(CommentProduct);
            groupBox1.Controls.Add(PriceProduct);
            groupBox1.Controls.Add(NameProduct);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(920, 9);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(243, 868);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информция/изменение товара";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 369);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 341);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 14;
            label9.Text = "Артикль";
            label9.Click += label9_Click;
            // 
            // RemoveProduct
            // 
            RemoveProduct.BackColor = SystemColors.ActiveCaption;
            RemoveProduct.Cursor = Cursors.IBeam;
            RemoveProduct.Location = new Point(8, 749);
            RemoveProduct.Margin = new Padding(3, 4, 3, 4);
            RemoveProduct.Name = "RemoveProduct";
            RemoveProduct.Size = new Size(227, 69);
            RemoveProduct.TabIndex = 13;
            RemoveProduct.Text = "Удалить";
            RemoveProduct.UseVisualStyleBackColor = false;
            RemoveProduct.Click += RemoveProduct_Click;
            // 
            // ViewExcel
            // 
            ViewExcel.BackColor = SystemColors.ActiveCaption;
            ViewExcel.Location = new Point(7, 674);
            ViewExcel.Margin = new Padding(3, 4, 3, 4);
            ViewExcel.Name = "ViewExcel";
            ViewExcel.Size = new Size(229, 67);
            ViewExcel.TabIndex = 12;
            ViewExcel.Text = "Выгрузить в Excel";
            ViewExcel.UseVisualStyleBackColor = false;
            ViewExcel.Click += ViewExcel_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(7, 599);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(229, 67);
            button1.TabIndex = 11;
            button1.Text = "Добавить продукт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditProduct
            // 
            EditProduct.BackColor = SystemColors.ActiveCaption;
            EditProduct.Location = new Point(7, 530);
            EditProduct.Margin = new Padding(3, 4, 3, 4);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(229, 61);
            EditProduct.TabIndex = 10;
            EditProduct.Text = "Изменить";
            EditProduct.UseVisualStyleBackColor = false;
            EditProduct.Click += EditProduct_Click;
            // 
            // CategoryProduct
            // 
            CategoryProduct.FormattingEnabled = true;
            CategoryProduct.Location = new Point(6, 429);
            CategoryProduct.Margin = new Padding(3, 4, 3, 4);
            CategoryProduct.Name = "CategoryProduct";
            CategoryProduct.Size = new Size(227, 28);
            CategoryProduct.TabIndex = 9;
            // 
            // CommentProduct
            // 
            CommentProduct.Location = new Point(7, 245);
            CommentProduct.Margin = new Padding(3, 4, 3, 4);
            CommentProduct.Multiline = true;
            CommentProduct.Name = "CommentProduct";
            CommentProduct.Size = new Size(227, 91);
            CommentProduct.TabIndex = 7;
            // 
            // PriceProduct
            // 
            PriceProduct.Location = new Point(7, 175);
            PriceProduct.Margin = new Padding(3, 4, 3, 4);
            PriceProduct.Name = "PriceProduct";
            PriceProduct.Size = new Size(227, 27);
            PriceProduct.TabIndex = 6;
            // 
            // NameProduct
            // 
            NameProduct.Location = new Point(7, 96);
            NameProduct.Margin = new Padding(3, 4, 3, 4);
            NameProduct.Name = "NameProduct";
            NameProduct.Size = new Size(227, 27);
            NameProduct.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 405);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 4;
            label8.Text = "Категория:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 221);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 2;
            label6.Text = "Описание:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 141);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 1;
            label5.Text = "Цена:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 63);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 0;
            label4.Text = "Название:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AddCat);
            groupBox2.Controls.Add(EditCate);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CatName);
            groupBox2.Location = new Point(587, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(327, 175);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Категории";
            // 
            // AddCat
            // 
            AddCat.BackColor = SystemColors.ActiveCaption;
            AddCat.Location = new Point(181, 111);
            AddCat.Margin = new Padding(3, 4, 3, 4);
            AddCat.Name = "AddCat";
            AddCat.Size = new Size(155, 45);
            AddCat.TabIndex = 15;
            AddCat.Text = "Добавить";
            AddCat.UseVisualStyleBackColor = false;
            AddCat.Click += AddCat_Click;
            // 
            // EditCate
            // 
            EditCate.BackColor = SystemColors.ActiveCaption;
            EditCate.Location = new Point(18, 111);
            EditCate.Margin = new Padding(3, 4, 3, 4);
            EditCate.Name = "EditCate";
            EditCate.Size = new Size(155, 45);
            EditCate.TabIndex = 14;
            EditCate.Text = "Изменить";
            EditCate.UseVisualStyleBackColor = false;
            EditCate.Click += EditCate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 37);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 8;
            label7.Text = "Категория";
            // 
            // CatName
            // 
            CatName.FormattingEnabled = true;
            CatName.Location = new Point(97, 33);
            CatName.Margin = new Padding(3, 4, 3, 4);
            CatName.Name = "CatName";
            CatName.Size = new Size(226, 28);
            CatName.TabIndex = 7;
            CatName.SelectedIndexChanged += CatName_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 469);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 16;
            label10.Text = "Количество";
            // 
            // ProdCount
            // 
            ProdCount.Location = new Point(8, 498);
            ProdCount.Name = "ProdCount";
            ProdCount.Size = new Size(225, 27);
            ProdCount.TabIndex = 17;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 877);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Filtered);
            Controls.Add(ViewProduct);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Client";
            Load += Client_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewProduct).EndInit();
            Filtered.ResumeLayout(false);
            Filtered.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ThisOrder;
        private Button RemoveAddEmpl;
        private Button ViewParts;
        private Button OrdersParts;
        private Label label1;
        private Panel panel1;
        private DataGridView ViewProduct;
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
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn NameItem;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Атикль;
        private Label label9;
        private TextBox textBox1;
        private TextBox ProdCount;
        private Label label10;
    }
}