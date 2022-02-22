namespace Lab1
{
    partial class Home
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
            this.Bai1 = new System.Windows.Forms.Button();
            this.Bai2 = new System.Windows.Forms.Button();
            this.Bai3 = new System.Windows.Forms.Button();
            this.Bai5 = new System.Windows.Forms.Button();
            this.Bai4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai1
            // 
            this.Bai1.BackColor = System.Drawing.Color.Blue;
            this.Bai1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai1.ForeColor = System.Drawing.Color.Yellow;
            this.Bai1.Location = new System.Drawing.Point(36, 51);
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(145, 73);
            this.Bai1.TabIndex = 0;
            this.Bai1.Text = "Bài 1";
            this.Bai1.UseVisualStyleBackColor = false;
            this.Bai1.Click += new System.EventHandler(this.Bai1_Click);
            // 
            // Bai2
            // 
            this.Bai2.BackColor = System.Drawing.Color.Blue;
            this.Bai2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai2.ForeColor = System.Drawing.Color.Yellow;
            this.Bai2.Location = new System.Drawing.Point(223, 51);
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(145, 73);
            this.Bai2.TabIndex = 1;
            this.Bai2.Text = "Bài 2";
            this.Bai2.UseVisualStyleBackColor = false;
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.BackColor = System.Drawing.Color.Blue;
            this.Bai3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai3.ForeColor = System.Drawing.Color.Yellow;
            this.Bai3.Location = new System.Drawing.Point(413, 51);
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(145, 73);
            this.Bai3.TabIndex = 2;
            this.Bai3.Text = "Bài 3";
            this.Bai3.UseVisualStyleBackColor = false;
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // Bai5
            // 
            this.Bai5.BackColor = System.Drawing.Color.Blue;
            this.Bai5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai5.ForeColor = System.Drawing.Color.Yellow;
            this.Bai5.Location = new System.Drawing.Point(223, 196);
            this.Bai5.Name = "Bai5";
            this.Bai5.Size = new System.Drawing.Size(145, 73);
            this.Bai5.TabIndex = 4;
            this.Bai5.Text = "Bài 5";
            this.Bai5.UseVisualStyleBackColor = false;
            this.Bai5.Click += new System.EventHandler(this.Bai5_Click);
            // 
            // Bai4
            // 
            this.Bai4.BackColor = System.Drawing.Color.Blue;
            this.Bai4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai4.ForeColor = System.Drawing.Color.Yellow;
            this.Bai4.Location = new System.Drawing.Point(36, 196);
            this.Bai4.Name = "Bai4";
            this.Bai4.Size = new System.Drawing.Size(145, 73);
            this.Bai4.TabIndex = 3;
            this.Bai4.Text = "Bài 4";
            this.Bai4.UseVisualStyleBackColor = false;
            this.Bai4.Click += new System.EventHandler(this.Bai4_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(413, 196);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 73);
            this.exit.TabIndex = 5;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 346);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Bai5);
            this.Controls.Add(this.Bai4);
            this.Controls.Add(this.Bai3);
            this.Controls.Add(this.Bai2);
            this.Controls.Add(this.Bai1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai1;
        private System.Windows.Forms.Button Bai2;
        private System.Windows.Forms.Button Bai3;
        private System.Windows.Forms.Button Bai5;
        private System.Windows.Forms.Button Bai4;
        private System.Windows.Forms.Button exit;
    }
}

