namespace hideAndSeek
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
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.cBox_locations = new System.Windows.Forms.ComboBox();
            this.b_goHere = new System.Windows.Forms.Button();
            this.b_goThroughTheDoor = new System.Windows.Forms.Button();
            this.b_hide = new System.Windows.Forms.Button();
            this.b_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTB_output
            // 
            this.rTB_output.Location = new System.Drawing.Point(19, 19);
            this.rTB_output.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.Size = new System.Drawing.Size(428, 224);
            this.rTB_output.TabIndex = 0;
            this.rTB_output.Text = "";
            // 
            // cBox_locations
            // 
            this.cBox_locations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_locations.FormattingEnabled = true;
            this.cBox_locations.Location = new System.Drawing.Point(137, 264);
            this.cBox_locations.Margin = new System.Windows.Forms.Padding(10);
            this.cBox_locations.Name = "cBox_locations";
            this.cBox_locations.Size = new System.Drawing.Size(310, 28);
            this.cBox_locations.TabIndex = 1;
            // 
            // b_goHere
            // 
            this.b_goHere.Location = new System.Drawing.Point(23, 263);
            this.b_goHere.Margin = new System.Windows.Forms.Padding(10);
            this.b_goHere.Name = "b_goHere";
            this.b_goHere.Size = new System.Drawing.Size(94, 29);
            this.b_goHere.TabIndex = 2;
            this.b_goHere.Text = "Idź tutaj:";
            this.b_goHere.UseVisualStyleBackColor = true;
            this.b_goHere.Click += new System.EventHandler(this.b_goHere_Click);
            // 
            // b_goThroughTheDoor
            // 
            this.b_goThroughTheDoor.Location = new System.Drawing.Point(23, 312);
            this.b_goThroughTheDoor.Margin = new System.Windows.Forms.Padding(10);
            this.b_goThroughTheDoor.Name = "b_goThroughTheDoor";
            this.b_goThroughTheDoor.Size = new System.Drawing.Size(424, 29);
            this.b_goThroughTheDoor.TabIndex = 3;
            this.b_goThroughTheDoor.Text = "Przejdź przez drzwi";
            this.b_goThroughTheDoor.UseVisualStyleBackColor = true;
            this.b_goThroughTheDoor.Click += new System.EventHandler(this.b_goThroughTheDoor_Click);
            // 
            // b_hide
            // 
            this.b_hide.Location = new System.Drawing.Point(23, 361);
            this.b_hide.Margin = new System.Windows.Forms.Padding(10);
            this.b_hide.Name = "b_hide";
            this.b_hide.Size = new System.Drawing.Size(424, 29);
            this.b_hide.TabIndex = 4;
            this.b_hide.Text = "Kryj się!";
            this.b_hide.UseVisualStyleBackColor = true;
            this.b_hide.Click += new System.EventHandler(this.b_hide_Click);
            // 
            // b_check
            // 
            this.b_check.Location = new System.Drawing.Point(23, 410);
            this.b_check.Margin = new System.Windows.Forms.Padding(10);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(424, 29);
            this.b_check.TabIndex = 5;
            this.b_check.Text = "Sprawdź";
            this.b_check.UseVisualStyleBackColor = true;
            this.b_check.Click += new System.EventHandler(this.b_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.b_check);
            this.Controls.Add(this.b_hide);
            this.Controls.Add(this.b_goThroughTheDoor);
            this.Controls.Add(this.b_goHere);
            this.Controls.Add(this.cBox_locations);
            this.Controls.Add(this.rTB_output);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hide And Seek";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rTB_output;
        private ComboBox cBox_locations;
        private Button b_goHere;
        private Button b_goThroughTheDoor;
        private Button b_hide;
        private Button b_check;
    }
}