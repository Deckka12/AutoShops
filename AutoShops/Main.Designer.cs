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
            this.Directory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Directory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Directory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Directory.Location = new System.Drawing.Point(45, 65);
            this.Directory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(115, 48);
            this.Directory.TabIndex = 4;
            this.Directory.Text = "Каталог";
            this.Directory.UseVisualStyleBackColor = false;
            this.Directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 191);
            this.Controls.Add(this.Directory);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button Directory;

    }
}