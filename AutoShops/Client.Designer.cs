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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            ThisOrder.Location = new Point(-1, 357);
            ThisOrder.Margin = new Padding(4, 3, 4, 3);
            ThisOrder.Name = "ThisOrder";
            ThisOrder.Size = new Size(252, 69);
            ThisOrder.TabIndex = 4;
            ThisOrder.Text = "Текущие заказы";
            ThisOrder.UseVisualStyleBackColor = true;
            ThisOrder.Click += ThisOrder_Click;
            // 
            // RemoveAddEmpl
            // 
            RemoveAddEmpl.FlatStyle = FlatStyle.Flat;
            RemoveAddEmpl.Location = new Point(-1, 282);
            RemoveAddEmpl.Margin = new Padding(4, 3, 4, 3);
            RemoveAddEmpl.Name = "RemoveAddEmpl";
            RemoveAddEmpl.Size = new Size(252, 69);
            RemoveAddEmpl.TabIndex = 3;
            RemoveAddEmpl.Text = "Добавить/удалить сотрудника";
            RemoveAddEmpl.UseVisualStyleBackColor = true;
            RemoveAddEmpl.Click += RemoveAddEmpl_Click;
            // 
            // ViewParts
            // 
            ViewParts.FlatStyle = FlatStyle.Flat;
            ViewParts.Location = new Point(-2, 57);
            ViewParts.Margin = new Padding(4, 3, 4, 3);
            ViewParts.Name = "ViewParts";
            ViewParts.Size = new Size(252, 69);
            ViewParts.TabIndex = 2;
            ViewParts.Text = "Просмотр запчастей";
            ViewParts.UseVisualStyleBackColor = true;
            ViewParts.Click += ViewParts_Click;
            // 
            // OrdersParts
            // 
            OrdersParts.BackColor = SystemColors.InactiveCaption;
            OrdersParts.FlatStyle = FlatStyle.Flat;
            OrdersParts.Location = new Point(-2, 132);
            OrdersParts.Margin = new Padding(4, 3, 4, 3);
            OrdersParts.Name = "OrdersParts";
            OrdersParts.Size = new Size(252, 69);
            OrdersParts.TabIndex = 1;
            OrdersParts.Text = "Оформление заказа";
            OrdersParts.UseVisualStyleBackColor = false;
            OrdersParts.Click += OrdersParts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-4, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
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
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 658);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(-4, 561);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(252, 69);
            button3.TabIndex = 8;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-5, 561);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(252, 69);
            button2.TabIndex = 7;
            button2.Text = "Авторизоваться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ControlClient
            // 
            ControlClient.BackgroundImageLayout = ImageLayout.Stretch;
            ControlClient.FlatStyle = FlatStyle.Flat;
            ControlClient.Location = new Point(-4, 432);
            ControlClient.Margin = new Padding(4, 3, 4, 3);
            ControlClient.Name = "ControlClient";
            ControlClient.Size = new Size(252, 69);
            ControlClient.TabIndex = 6;
            ControlClient.Text = "Управление клиентами";
            ControlClient.UseVisualStyleBackColor = true;
            ControlClient.Click += ControlClient_Click;
            // 
            // Cart
            // 
            Cart.BackgroundImageLayout = ImageLayout.Stretch;
            Cart.FlatStyle = FlatStyle.Flat;
            Cart.Location = new Point(-1, 207);
            Cart.Margin = new Padding(4, 3, 4, 3);
            Cart.Name = "Cart";
            Cart.Size = new Size(252, 69);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(0, 4, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ViewProduct.DefaultCellStyle = dataGridViewCellStyle1;
            ViewProduct.Location = new Point(256, 134);
            ViewProduct.Margin = new Padding(0);
            ViewProduct.Name = "ViewProduct";
            ViewProduct.RowTemplate.Height = 25;
            ViewProduct.Size = new Size(544, 524);
            ViewProduct.TabIndex = 2;
            ViewProduct.Visible = false;
            ViewProduct.CellContentClick += dataGridView1_CellClick;
            ViewProduct.SelectionChanged += ViewProduct_SelectionChanged;
            // 
            // NameItem
            // 
            NameItem.HeaderText = "Название";
            NameItem.Name = "NameItem";
            NameItem.Width = 150;
            // 
            // Category
            // 
            Category.HeaderText = "Категория";
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Атикль
            // 
            Атикль.HeaderText = "Атикль";
            Атикль.Name = "Атикль";
            // 
            // Categories
            // 
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(109, 25);
            Categories.Name = "Categories";
            Categories.Size = new Size(121, 23);
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
            Filtered.Location = new Point(256, 0);
            Filtered.Name = "Filtered";
            Filtered.Size = new Size(252, 128);
            Filtered.TabIndex = 4;
            Filtered.TabStop = false;
            Filtered.Text = "Фильтр";
            Filtered.Visible = false;
            // 
            // NamesProduct
            // 
            NamesProduct.Location = new Point(115, 54);
            NamesProduct.Name = "NamesProduct";
            NamesProduct.Size = new Size(121, 23);
            NamesProduct.TabIndex = 6;
            NamesProduct.TextChanged += textBox1_TextChanged;
            // 
            // Addcart
            // 
            Addcart.BackColor = SystemColors.ActiveCaption;
            Addcart.Location = new Point(32, 83);
            Addcart.Name = "Addcart";
            Addcart.Size = new Size(165, 34);
            Addcart.TabIndex = 5;
            Addcart.Text = "Добавить в корзину";
            Addcart.UseVisualStyleBackColor = false;
            Addcart.Visible = false;
            Addcart.Click += Addcart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 5;
            label3.Text = "Название/Артикль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Категория";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(806, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 651);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информция/изменение товара";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 256);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 14;
            label9.Text = "Артикль";
            label9.Click += label9_Click;
            // 
            // RemoveProduct
            // 
            RemoveProduct.BackColor = SystemColors.ActiveCaption;
            RemoveProduct.Cursor = Cursors.IBeam;
            RemoveProduct.Location = new Point(5, 515);
            RemoveProduct.Name = "RemoveProduct";
            RemoveProduct.Size = new Size(199, 52);
            RemoveProduct.TabIndex = 13;
            RemoveProduct.Text = "Удалить";
            RemoveProduct.UseVisualStyleBackColor = false;
            RemoveProduct.Click += RemoveProduct_Click;
            // 
            // ViewExcel
            // 
            ViewExcel.BackColor = SystemColors.ActiveCaption;
            ViewExcel.Location = new Point(4, 459);
            ViewExcel.Name = "ViewExcel";
            ViewExcel.Size = new Size(200, 50);
            ViewExcel.TabIndex = 12;
            ViewExcel.Text = "Выгрузить в Excel";
            ViewExcel.UseVisualStyleBackColor = false;
            ViewExcel.Click += ViewExcel_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(4, 403);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 11;
            button1.Text = "Добавить продукт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditProduct
            // 
            EditProduct.BackColor = SystemColors.ActiveCaption;
            EditProduct.Location = new Point(4, 351);
            EditProduct.Name = "EditProduct";
            EditProduct.Size = new Size(200, 46);
            EditProduct.TabIndex = 10;
            EditProduct.Text = "Изменить";
            EditProduct.UseVisualStyleBackColor = false;
            EditProduct.Click += EditProduct_Click;
            // 
            // CategoryProduct
            // 
            CategoryProduct.FormattingEnabled = true;
            CategoryProduct.Location = new Point(5, 322);
            CategoryProduct.Name = "CategoryProduct";
            CategoryProduct.Size = new Size(199, 23);
            CategoryProduct.TabIndex = 9;
            // 
            // CommentProduct
            // 
            CommentProduct.Location = new Point(6, 184);
            CommentProduct.Multiline = true;
            CommentProduct.Name = "CommentProduct";
            CommentProduct.Size = new Size(199, 69);
            CommentProduct.TabIndex = 7;
            // 
            // PriceProduct
            // 
            PriceProduct.Location = new Point(6, 131);
            PriceProduct.Name = "PriceProduct";
            PriceProduct.Size = new Size(199, 23);
            PriceProduct.TabIndex = 6;
            // 
            // NameProduct
            // 
            NameProduct.Location = new Point(6, 72);
            NameProduct.Name = "NameProduct";
            NameProduct.Size = new Size(199, 23);
            NameProduct.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 304);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 4;
            label8.Text = "Категория:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 166);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 2;
            label6.Text = "Описание:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "Цена:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 47);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "Название:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AddCat);
            groupBox2.Controls.Add(EditCate);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(CatName);
            groupBox2.Location = new Point(498, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 131);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Категории";
            // 
            // AddCat
            // 
            AddCat.BackColor = SystemColors.ActiveCaption;
            AddCat.Location = new Point(158, 83);
            AddCat.Name = "AddCat";
            AddCat.Size = new Size(136, 34);
            AddCat.TabIndex = 15;
            AddCat.Text = "Добавить";
            AddCat.UseVisualStyleBackColor = false;
            AddCat.Click += AddCat_Click;
            // 
            // EditCate
            // 
            EditCate.BackColor = SystemColors.ActiveCaption;
            EditCate.Location = new Point(16, 83);
            EditCate.Name = "EditCate";
            EditCate.Size = new Size(136, 34);
            EditCate.TabIndex = 14;
            EditCate.Text = "Изменить";
            EditCate.UseVisualStyleBackColor = false;
            EditCate.Click += EditCate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 28);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 8;
            label7.Text = "Категория";
            // 
            // CatName
            // 
            CatName.FormattingEnabled = true;
            CatName.Location = new Point(85, 25);
            CatName.Name = "CatName";
            CatName.Size = new Size(198, 23);
            CatName.TabIndex = 7;
            CatName.SelectedIndexChanged += CatName_SelectedIndexChanged;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 658);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Filtered);
            Controls.Add(ViewProduct);
            Controls.Add(panel1);
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
    }
}