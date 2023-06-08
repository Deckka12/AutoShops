namespace AutoShops.Forms
{
    partial class InfoProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.CommentsKey = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.Label();
            this.CategoryKey = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.KeyPrice = new System.Windows.Forms.Label();
            this.PriceKey = new System.Windows.Forms.Label();
            this.KeyName = new System.Windows.Forms.Label();
            this.NameKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Information
            // 
            this.Information.Controls.Add(this.CommentsKey);
            this.Information.Controls.Add(this.Comments);
            this.Information.Controls.Add(this.CategoryKey);
            this.Information.Controls.Add(this.Category);
            this.Information.Controls.Add(this.KeyPrice);
            this.Information.Controls.Add(this.PriceKey);
            this.Information.Controls.Add(this.KeyName);
            this.Information.Controls.Add(this.NameKey);
            this.Information.Location = new System.Drawing.Point(432, 13);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(200, 422);
            this.Information.TabIndex = 2;
            this.Information.TabStop = false;
            this.Information.Text = "Описание";
            this.Information.Enter += new System.EventHandler(this.Information_Enter);
            // 
            // CommentsKey
            // 
            this.CommentsKey.AutoSize = true;
            this.CommentsKey.Location = new System.Drawing.Point(74, 94);
            this.CommentsKey.Name = "CommentsKey";
            this.CommentsKey.Size = new System.Drawing.Size(0, 15);
            this.CommentsKey.TabIndex = 7;
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Location = new System.Drawing.Point(6, 94);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(62, 15);
            this.Comments.TabIndex = 6;
            this.Comments.Text = "Описание";
            // 
            // CategoryKey
            // 
            this.CategoryKey.AutoSize = true;
            this.CategoryKey.Location = new System.Drawing.Point(71, 68);
            this.CategoryKey.Name = "CategoryKey";
            this.CategoryKey.Size = new System.Drawing.Size(0, 15);
            this.CategoryKey.TabIndex = 5;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(6, 68);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(63, 15);
            this.Category.TabIndex = 4;
            this.Category.Text = "Категория";
            // 
            // KeyPrice
            // 
            this.KeyPrice.AutoSize = true;
            this.KeyPrice.Location = new System.Drawing.Point(71, 44);
            this.KeyPrice.Name = "KeyPrice";
            this.KeyPrice.Size = new System.Drawing.Size(0, 15);
            this.KeyPrice.TabIndex = 3;
            // 
            // PriceKey
            // 
            this.PriceKey.AutoSize = true;
            this.PriceKey.Location = new System.Drawing.Point(6, 44);
            this.PriceKey.Name = "PriceKey";
            this.PriceKey.Size = new System.Drawing.Size(35, 15);
            this.PriceKey.TabIndex = 2;
            this.PriceKey.Text = "Цена";
            // 
            // KeyName
            // 
            this.KeyName.AutoSize = true;
            this.KeyName.Location = new System.Drawing.Point(71, 19);
            this.KeyName.Name = "KeyName";
            this.KeyName.Size = new System.Drawing.Size(0, 15);
            this.KeyName.TabIndex = 1;
            // 
            // NameKey
            // 
            this.NameKey.AutoSize = true;
            this.NameKey.Location = new System.Drawing.Point(6, 19);
            this.NameKey.Name = "NameKey";
            this.NameKey.Size = new System.Drawing.Size(59, 15);
            this.NameKey.TabIndex = 0;
            this.NameKey.Text = "Название";
            // 
            // InfoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 447);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InfoProduct";
            this.Load += new System.EventHandler(this.InfoProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox Information;
        private Label CommentsKey;
        private Label Comments;
        private Label CategoryKey;
        private Label Category;
        private Label KeyPrice;
        private Label PriceKey;
        private Label KeyName;
        private Label NameKey;
    }
}