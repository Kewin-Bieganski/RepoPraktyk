namespace cards
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
            this.b_random = new System.Windows.Forms.Button();
            this.l_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_random
            // 
            this.b_random.Location = new System.Drawing.Point(129, 373);
            this.b_random.Name = "b_random";
            this.b_random.Size = new System.Drawing.Size(94, 29);
            this.b_random.TabIndex = 0;
            this.b_random.Text = "Losuj";
            this.b_random.UseVisualStyleBackColor = true;
            this.b_random.Click += new System.EventHandler(this.b_random_Click);
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Location = new System.Drawing.Point(12, 9);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(0, 20);
            this.l_output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(235, 414);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.b_random);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_random;
        private Label l_output;
    }
}