namespace AutoShops.Forms
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.Register = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(148, 27);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(100, 23);
            this.FIO.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(148, 74);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 23);
            this.Login.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(148, 122);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(148, 164);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(113, 19);
            this.Admin.TabIndex = 7;
            this.Admin.Text = "Администратор";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Register.Location = new System.Drawing.Point(12, 207);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(123, 33);
            this.Register.TabIndex = 8;
            this.Register.Text = "Зарегистрировать";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(335, 237);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Логин";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Статус";
            this.Column3.Name = "Column3";
            // 
            // EditAccount
            // 
            this.EditAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditAccount.Location = new System.Drawing.Point(148, 207);
            this.EditAccount.Name = "EditAccount";
            this.EditAccount.Size = new System.Drawing.Size(123, 33);
            this.EditAccount.TabIndex = 10;
            this.EditAccount.Text = "Изменить";
            this.EditAccount.UseVisualStyleBackColor = false;
            this.EditAccount.Click += new System.EventHandler(this.EditAccount_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 251);
            this.Controls.Add(this.EditAccount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FIO;
        private TextBox Login;
        private TextBox Password;
        private CheckBox Admin;
        private Button Register;
        private DataGridView dataGridView1;
        private Button EditAccount;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}