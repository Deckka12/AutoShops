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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FIO = new TextBox();
            Login = new TextBox();
            Password = new TextBox();
            Admin = new CheckBox();
            Register = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            EditAccount = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 109);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 173);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // FIO
            // 
            FIO.Location = new Point(169, 36);
            FIO.Margin = new Padding(3, 4, 3, 4);
            FIO.Name = "FIO";
            FIO.Size = new Size(114, 27);
            FIO.TabIndex = 4;
            // 
            // Login
            // 
            Login.Location = new Point(169, 99);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(114, 27);
            Login.TabIndex = 5;
            // 
            // Password
            // 
            Password.Location = new Point(169, 163);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(114, 27);
            Password.TabIndex = 6;
            Password.UseSystemPasswordChar = true;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Location = new Point(169, 219);
            Admin.Margin = new Padding(3, 4, 3, 4);
            Admin.Name = "Admin";
            Admin.Size = new Size(141, 24);
            Admin.TabIndex = 7;
            Admin.Text = "Администратор";
            Admin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            Register.BackColor = SystemColors.ActiveCaption;
            Register.Location = new Point(14, 276);
            Register.Margin = new Padding(3, 4, 3, 4);
            Register.Name = "Register";
            Register.Size = new Size(141, 44);
            Register.TabIndex = 8;
            Register.Text = "Зарегистрировать";
            Register.UseVisualStyleBackColor = false;
            Register.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(327, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(383, 368);
            dataGridView1.TabIndex = 9;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "ФИО";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Логин";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Статус";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // EditAccount
            // 
            EditAccount.BackColor = SystemColors.ActiveCaption;
            EditAccount.Location = new Point(169, 276);
            EditAccount.Margin = new Padding(3, 4, 3, 4);
            EditAccount.Name = "EditAccount";
            EditAccount.Size = new Size(141, 44);
            EditAccount.TabIndex = 10;
            EditAccount.Text = "Изменить";
            EditAccount.UseVisualStyleBackColor = false;
            EditAccount.Click += EditAccount_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(103, 328);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 11;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 394);
            Controls.Add(button1);
            Controls.Add(EditAccount);
            Controls.Add(dataGridView1);
            Controls.Add(Register);
            Controls.Add(Admin);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(FIO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
    }
}