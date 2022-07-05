namespace classFun
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
            this.tB_text = new System.Windows.Forms.TextBox();
            this.nUD_times = new System.Windows.Forms.NumericUpDown();
            this.b_talk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_times)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powiedz to:";
            // 
            // tB_text
            // 
            this.tB_text.Location = new System.Drawing.Point(124, 16);
            this.tB_text.Margin = new System.Windows.Forms.Padding(10);
            this.tB_text.Name = "tB_text";
            this.tB_text.Size = new System.Drawing.Size(149, 27);
            this.tB_text.TabIndex = 1;
            // 
            // nUD_times
            // 
            this.nUD_times.Location = new System.Drawing.Point(123, 57);
            this.nUD_times.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_times.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_times.Name = "nUD_times";
            this.nUD_times.Size = new System.Drawing.Size(150, 27);
            this.nUD_times.TabIndex = 2;
            this.nUD_times.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // b_talk
            // 
            this.b_talk.AutoSize = true;
            this.b_talk.Location = new System.Drawing.Point(123, 104);
            this.b_talk.Margin = new System.Windows.Forms.Padding(10);
            this.b_talk.Name = "b_talk";
            this.b_talk.Size = new System.Drawing.Size(150, 30);
            this.b_talk.TabIndex = 3;
            this.b_talk.Text = "Mów do mnie!";
            this.b_talk.UseVisualStyleBackColor = true;
            this.b_talk.Click += new System.EventHandler(this.b_talk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba razy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_talk);
            this.Controls.Add(this.nUD_times);
            this.Controls.Add(this.tB_text);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_times)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tB_text;
        private NumericUpDown nUD_times;
        private Button b_talk;
        private Label label2;
    }
}