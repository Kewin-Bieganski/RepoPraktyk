namespace cowCalculator
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
            this.nUD_numberOfCows = new System.Windows.Forms.NumericUpDown();
            this.b_calculate = new System.Windows.Forms.Button();
            this.b_error = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfCows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość krów";
            // 
            // nUD_numberOfCows
            // 
            this.nUD_numberOfCows.Location = new System.Drawing.Point(114, 17);
            this.nUD_numberOfCows.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_numberOfCows.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nUD_numberOfCows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_numberOfCows.Name = "nUD_numberOfCows";
            this.nUD_numberOfCows.Size = new System.Drawing.Size(150, 27);
            this.nUD_numberOfCows.TabIndex = 1;
            this.nUD_numberOfCows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_numberOfCows.ValueChanged += new System.EventHandler(this.nUD_numberOfCows_ValueChanged);
            // 
            // b_calculate
            // 
            this.b_calculate.Location = new System.Drawing.Point(19, 64);
            this.b_calculate.Margin = new System.Windows.Forms.Padding(10);
            this.b_calculate.Name = "b_calculate";
            this.b_calculate.Size = new System.Drawing.Size(245, 29);
            this.b_calculate.TabIndex = 2;
            this.b_calculate.Text = "Oblicz";
            this.b_calculate.UseVisualStyleBackColor = true;
            this.b_calculate.Click += new System.EventHandler(this.b_calculate_Click);
            // 
            // b_error
            // 
            this.b_error.Location = new System.Drawing.Point(19, 113);
            this.b_error.Margin = new System.Windows.Forms.Padding(10);
            this.b_error.Name = "b_error";
            this.b_error.Size = new System.Drawing.Size(245, 29);
            this.b_error.TabIndex = 3;
            this.b_error.Text = "Error";
            this.b_error.UseVisualStyleBackColor = true;
            this.b_error.Click += new System.EventHandler(this.b_error_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_error);
            this.Controls.Add(this.b_calculate);
            this.Controls.Add(this.nUD_numberOfCows);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator krów";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfCows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown nUD_numberOfCows;
        private Button b_calculate;
        private Button b_error;
    }
}