namespace AutoShops.Forms
{
    partial class Card
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditCount = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.Price,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(374, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Название";
            this.NameProduct.Name = "NameProduct";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditCount
            // 
            this.EditCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditCount.Location = new System.Drawing.Point(415, 35);
            this.EditCount.Name = "EditCount";
            this.EditCount.Size = new System.Drawing.Size(122, 23);
            this.EditCount.TabIndex = 3;
            this.EditCount.Text = "Изменить";
            this.EditCount.UseVisualStyleBackColor = false;
            this.EditCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Remove.Location = new System.Drawing.Point(414, 64);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(123, 23);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 162);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.EditCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Card";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button EditCount;
        private Button Remove;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Count;
    }
}