namespace kalkulatorOdleglosci
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
            this.nUD_startingMileage = new System.Windows.Forms.NumericUpDown();
            this.nUD_endingMileage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.l_output = new System.Windows.Forms.Label();
            this.b_calc = new System.Windows.Forms.Button();
            this.b_distance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_startingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_endingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początkowy stan licznika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Końcowy stan licznika:";
            // 
            // nUD_startingMileage
            // 
            this.nUD_startingMileage.Location = new System.Drawing.Point(212, 19);
            this.nUD_startingMileage.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_startingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD_startingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_startingMileage.Name = "nUD_startingMileage";
            this.nUD_startingMileage.Size = new System.Drawing.Size(150, 27);
            this.nUD_startingMileage.TabIndex = 2;
            this.nUD_startingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUD_endingMileage
            // 
            this.nUD_endingMileage.Location = new System.Drawing.Point(212, 66);
            this.nUD_endingMileage.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_endingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD_endingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_endingMileage.Name = "nUD_endingMileage";
            this.nUD_endingMileage.Size = new System.Drawing.Size(150, 27);
            this.nUD_endingMileage.TabIndex = 3;
            this.nUD_endingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kwota do zwrotu:";
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_output.Location = new System.Drawing.Point(212, 113);
            this.l_output.Margin = new System.Windows.Forms.Padding(10);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(39, 28);
            this.l_output.TabIndex = 5;
            this.l_output.Text = "???";
            // 
            // b_calc
            // 
            this.b_calc.Location = new System.Drawing.Point(42, 161);
            this.b_calc.Margin = new System.Windows.Forms.Padding(10);
            this.b_calc.Name = "b_calc";
            this.b_calc.Size = new System.Drawing.Size(150, 29);
            this.b_calc.TabIndex = 6;
            this.b_calc.Text = "Oblicz";
            this.b_calc.UseVisualStyleBackColor = true;
            this.b_calc.Click += new System.EventHandler(this.b_calc_Click);
            // 
            // b_distance
            // 
            this.b_distance.Location = new System.Drawing.Point(212, 161);
            this.b_distance.Margin = new System.Windows.Forms.Padding(10);
            this.b_distance.Name = "b_distance";
            this.b_distance.Size = new System.Drawing.Size(150, 29);
            this.b_distance.TabIndex = 7;
            this.b_distance.Text = "Pokaż odległość";
            this.b_distance.UseVisualStyleBackColor = true;
            this.b_distance.Click += new System.EventHandler(this.b_distance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_distance);
            this.Controls.Add(this.b_calc);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUD_endingMileage);
            this.Controls.Add(this.nUD_startingMileage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator odległości";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_startingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_endingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nUD_startingMileage;
        private NumericUpDown nUD_endingMileage;
        private Label label3;
        private Label l_output;
        private Button b_calc;
        private Button b_distance;
    }
}