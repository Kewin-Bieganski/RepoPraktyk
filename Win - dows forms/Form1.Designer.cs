namespace Win___dows_forms
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
            this.b_changeText = new System.Windows.Forms.Button();
            this.l_text = new System.Windows.Forms.Label();
            this.cB_changeText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // b_changeText
            // 
            this.b_changeText.Location = new System.Drawing.Point(12, 12);
            this.b_changeText.Name = "b_changeText";
            this.b_changeText.Size = new System.Drawing.Size(192, 29);
            this.b_changeText.TabIndex = 0;
            this.b_changeText.Text = "Kliknięcie zmienia etykietę";
            this.b_changeText.UseVisualStyleBackColor = true;
            this.b_changeText.Click += new System.EventHandler(this.b_changeText_Click);
            // 
            // l_text
            // 
            this.l_text.Location = new System.Drawing.Point(12, 54);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(458, 20);
            this.l_text.TabIndex = 1;
            this.l_text.Text = "Naciśnij przysik, aby zmienić tekst";
            this.l_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cB_changeText
            // 
            this.cB_changeText.AutoSize = true;
            this.cB_changeText.Checked = true;
            this.cB_changeText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_changeText.Location = new System.Drawing.Point(284, 15);
            this.cB_changeText.Name = "cB_changeText";
            this.cB_changeText.Size = new System.Drawing.Size(186, 24);
            this.cB_changeText.TabIndex = 2;
            this.cB_changeText.Text = "Włącza zmianę etykiety";
            this.cB_changeText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 83);
            this.Controls.Add(this.cB_changeText);
            this.Controls.Add(this.l_text);
            this.Controls.Add(this.b_changeText);
            this.Name = "Form1";
            this.Text = "Aplikacja Windows Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_changeText;
        private Label l_text;
        private CheckBox cB_changeText;
    }
}