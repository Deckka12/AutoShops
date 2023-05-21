namespace AutoShops.Forms
{
    partial class ExecuteOrderssss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if(disposing && ( components != null ))
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
        private void InitializeComponent () {
            this.ItemsOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemOrder = new System.Windows.Forms.GroupBox();
            this.InfoCLient = new System.Windows.Forms.GroupBox();
            this.ExecuteOrdersss = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Addres = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsOrders)).BeginInit();
            this.ItemOrder.SuspendLayout();
            this.InfoCLient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsOrders
            // 
            this.ItemsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ItemsOrders.Location = new System.Drawing.Point(0, 22);
            this.ItemsOrders.Name = "ItemsOrders";
            this.ItemsOrders.RowTemplate.Height = 25;
            this.ItemsOrders.Size = new System.Drawing.Size(393, 296);
            this.ItemsOrders.TabIndex = 0;
            this.ItemsOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.Name = "Column3";
            // 
            // ItemOrder
            // 
            this.ItemOrder.Controls.Add(this.ItemsOrders);
            this.ItemOrder.Location = new System.Drawing.Point(12, 12);
            this.ItemOrder.Name = "ItemOrder";
            this.ItemOrder.Size = new System.Drawing.Size(409, 318);
            this.ItemOrder.TabIndex = 1;
            this.ItemOrder.TabStop = false;
            this.ItemOrder.Text = "Ваши товары";
            // 
            // InfoCLient
            // 
            this.InfoCLient.Controls.Add(this.ExecuteOrdersss);
            this.InfoCLient.Controls.Add(this.Email);
            this.InfoCLient.Controls.Add(this.Phone);
            this.InfoCLient.Controls.Add(this.Addres);
            this.InfoCLient.Controls.Add(this.MiddleName);
            this.InfoCLient.Controls.Add(this.FirstName);
            this.InfoCLient.Controls.Add(this.Name);
            this.InfoCLient.Controls.Add(this.label6);
            this.InfoCLient.Controls.Add(this.label5);
            this.InfoCLient.Controls.Add(this.label4);
            this.InfoCLient.Controls.Add(this.label3);
            this.InfoCLient.Controls.Add(this.label2);
            this.InfoCLient.Controls.Add(this.label1);
            this.InfoCLient.Location = new System.Drawing.Point(427, 12);
            this.InfoCLient.Name = "InfoCLient";
            this.InfoCLient.Size = new System.Drawing.Size(209, 318);
            this.InfoCLient.TabIndex = 2;
            this.InfoCLient.TabStop = false;
            this.InfoCLient.Text = "Информация о покупателе";
            this.InfoCLient.Enter += new System.EventHandler(this.InfoCLient_Enter);
            // 
            // ExecuteOrdersss
            // 
            this.ExecuteOrdersss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExecuteOrdersss.Location = new System.Drawing.Point(46, 268);
            this.ExecuteOrdersss.Name = "ExecuteOrdersss";
            this.ExecuteOrdersss.Size = new System.Drawing.Size(110, 40);
            this.ExecuteOrdersss.TabIndex = 12;
            this.ExecuteOrdersss.Text = "Оформить заказ";
            this.ExecuteOrdersss.UseVisualStyleBackColor = false;
            this.ExecuteOrdersss.Click += new System.EventHandler(this.button1_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(93, 229);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 11;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(93, 192);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 23);
            this.Phone.TabIndex = 10;
            // 
            // Addres
            // 
            this.Addres.Location = new System.Drawing.Point(93, 148);
            this.Addres.Name = "Addres";
            this.Addres.Size = new System.Drawing.Size(100, 23);
            this.Addres.TabIndex = 9;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(93, 114);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(100, 23);
            this.MiddleName.TabIndex = 8;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(93, 78);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 23);
            this.FirstName.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(93, 38);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 23);
            this.Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адресс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // ExecuteOrderssss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 332);
            this.Controls.Add(this.InfoCLient);
            this.Controls.Add(this.ItemOrder);
            this.Text = "ExecuteOrders";
            this.Load += new System.EventHandler(this.ExecuteOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsOrders)).EndInit();
            this.ItemOrder.ResumeLayout(false);
            this.InfoCLient.ResumeLayout(false);
            this.InfoCLient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ItemsOrders;
        private GroupBox ItemOrder;
        private GroupBox InfoCLient;
        private Label label1;
        private Button ExecuteOrdersss;
        private TextBox Email;
        private TextBox Phone;
        private TextBox Addres;
        private TextBox MiddleName;
        private TextBox FirstName;
        private TextBox Name;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}