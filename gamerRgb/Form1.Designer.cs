namespace gamerRgb
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
            this.b_rgb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_rgb
            // 
            this.b_rgb.Location = new System.Drawing.Point(153, 131);
            this.b_rgb.Name = "b_rgb";
            this.b_rgb.Size = new System.Drawing.Size(80, 80);
            this.b_rgb.TabIndex = 0;
            this.b_rgb.Text = "WOW";
            this.b_rgb.UseVisualStyleBackColor = true;
            this.b_rgb.Click += new System.EventHandler(this.b_rgb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.b_rgb);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_rgb;
    }
}