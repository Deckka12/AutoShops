namespace AutoShops.Forms
{
    partial class CurrentOrder
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditStateOrder = new System.Windows.Forms.Button();
            this.ImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(743, 606);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер заказа";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата заказа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата доставки";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Статус заказа";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название товара";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Количество";
            this.Column7.Name = "Column7";
            // 
            // StateOrder
            // 
            this.StateOrder.FormattingEnabled = true;
            this.StateOrder.Location = new System.Drawing.Point(876, 25);
            this.StateOrder.Name = "StateOrder";
            this.StateOrder.Size = new System.Drawing.Size(121, 23);
            this.StateOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус заказа";
            // 
            // EditStateOrder
            // 
            this.EditStateOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditStateOrder.Location = new System.Drawing.Point(767, 72);
            this.EditStateOrder.Name = "EditStateOrder";
            this.EditStateOrder.Size = new System.Drawing.Size(230, 35);
            this.EditStateOrder.TabIndex = 3;
            this.EditStateOrder.Text = "Изменить";
            this.EditStateOrder.UseVisualStyleBackColor = false;
            this.EditStateOrder.Click += new System.EventHandler(this.EditStateOrder_Click);
            // 
            // ImportExcel
            // 
            this.ImportExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImportExcel.Location = new System.Drawing.Point(767, 113);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(230, 34);
            this.ImportExcel.TabIndex = 4;
            this.ImportExcel.Text = "Импортировать в Excel";
            this.ImportExcel.UseVisualStyleBackColor = false;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // CurrentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 608);
            this.Controls.Add(this.ImportExcel);
            this.Controls.Add(this.EditStateOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CurrentOrder";
            this.Text = "CurrentOrder";
            this.Load += new System.EventHandler(this.CurrentOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox StateOrder;
        private Label label1;
        private Button EditStateOrder;
        private Button ImportExcel;
    }
}