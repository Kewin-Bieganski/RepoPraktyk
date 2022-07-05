namespace valueCasting
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
            this.b_cast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_cast
            // 
            this.b_cast.Location = new System.Drawing.Point(331, 182);
            this.b_cast.Name = "b_cast";
            this.b_cast.Size = new System.Drawing.Size(94, 29);
            this.b_cast.TabIndex = 0;
            this.b_cast.Text = "Cast";
            this.b_cast.UseVisualStyleBackColor = true;
            this.b_cast.Click += new System.EventHandler(this.b_cast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_cast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_cast;
    }
}