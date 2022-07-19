namespace eureka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_1
            // 
            this.b_1.Location = new System.Drawing.Point(12, 12);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(94, 29);
            this.b_1.TabIndex = 0;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Location = new System.Drawing.Point(12, 47);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(94, 29);
            this.b_2.TabIndex = 1;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_3
            // 
            this.b_3.Location = new System.Drawing.Point(12, 82);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(94, 29);
            this.b_3.TabIndex = 2;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_4
            // 
            this.b_4.Location = new System.Drawing.Point(12, 117);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(94, 29);
            this.b_4.TabIndex = 3;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 174);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_1;
        private Button b_2;
        private Button b_3;
        private Button b_4;
    }
}