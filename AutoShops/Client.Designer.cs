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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addcart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProduct)).BeginInit();
            this.Filtered.SuspendLayout();
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
            this.ViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Category,
            this.Price});
            this.ViewProduct.Location = new System.Drawing.Point(256, 134);
            this.ViewProduct.Name = "ViewProduct";
            this.ViewProduct.RowTemplate.Height = 25;
            this.ViewProduct.Size = new System.Drawing.Size(544, 524);
            this.ViewProduct.TabIndex = 2;
            this.ViewProduct.Visible = false;
            this.ViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.Categories.Location = new System.Drawing.Point(85, 22);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(121, 23);
            this.Categories.TabIndex = 3;
            this.Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Filtered
            // 
            this.Filtered.Controls.Add(this.NamesProduct);
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
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // Addcart
            // 
            this.Addcart.Location = new System.Drawing.Point(806, 134);
            this.Addcart.Name = "Addcart";
            this.Addcart.Size = new System.Drawing.Size(103, 50);
            this.Addcart.TabIndex = 5;
            this.Addcart.Text = "Добавить в корзину";
            this.Addcart.UseVisualStyleBackColor = true;
            this.Addcart.Visible = false;
            this.Addcart.Click += new System.EventHandler(this.Addcart_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 658);
            this.Controls.Add(this.Addcart);
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
    }
}