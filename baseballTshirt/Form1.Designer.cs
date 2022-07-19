namespace baseballTshirt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_year = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_number = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "należał do gracza";
            // 
            // l_name
            // 
            this.l_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_name.Location = new System.Drawing.Point(344, 15);
            this.l_name.Margin = new System.Windows.Forms.Padding(10);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(163, 25);
            this.l_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = ", który zakończył karierę w";
            // 
            // l_year
            // 
            this.l_year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_year.Location = new System.Drawing.Point(728, 14);
            this.l_year.Margin = new System.Windows.Forms.Padding(10);
            this.l_year.Name = "l_year";
            this.l_year.Size = new System.Drawing.Size(77, 25);
            this.l_year.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "roku";
            // 
            // cB_number
            // 
            this.cB_number.FormattingEnabled = true;
            this.cB_number.Location = new System.Drawing.Point(93, 13);
            this.cB_number.Margin = new System.Windows.Forms.Padding(10);
            this.cB_number.Name = "cB_number";
            this.cB_number.Size = new System.Drawing.Size(85, 28);
            this.cB_number.TabIndex = 7;
            this.cB_number.SelectedIndexChanged += new System.EventHandler(this.cB_number_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 54);
            this.Controls.Add(this.cB_number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label l_name;
        private Label label4;
        private Label l_year;
        private Label label6;
        private ComboBox cB_number;
    }
}