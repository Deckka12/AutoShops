namespace AutoShops {
    partial class Main {
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
            this.button3 = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.Button();
            this.GetOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 181);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(98, 123);
            this.Directory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(115, 48);
            this.Directory.TabIndex = 4;
            this.Directory.Text = "Каталог";
            this.Directory.UseVisualStyleBackColor = true;
            this.Directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // GetOrder
            // 
            this.GetOrder.Location = new System.Drawing.Point(98, 66);
            this.GetOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetOrder.Name = "GetOrder";
            this.GetOrder.Size = new System.Drawing.Size(115, 48);
            this.GetOrder.TabIndex = 3;
            this.GetOrder.Text = "Получить заказ";
            this.GetOrder.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 644);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.GetOrder);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button3;
        private Button Directory;
        private Button GetOrder;

    }
}