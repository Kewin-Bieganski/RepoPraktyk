namespace elephantReference
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
            this.b_lloyd = new System.Windows.Forms.Button();
            this.b_lucinda = new System.Windows.Forms.Button();
            this.l_swap = new System.Windows.Forms.Button();
            this.l_extra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_lloyd
            // 
            this.b_lloyd.Location = new System.Drawing.Point(19, 19);
            this.b_lloyd.Margin = new System.Windows.Forms.Padding(10);
            this.b_lloyd.Name = "b_lloyd";
            this.b_lloyd.Size = new System.Drawing.Size(100, 30);
            this.b_lloyd.TabIndex = 0;
            this.b_lloyd.Text = "Lloyd";
            this.b_lloyd.UseVisualStyleBackColor = true;
            this.b_lloyd.Click += new System.EventHandler(this.b_lloyd_Click);
            // 
            // b_lucinda
            // 
            this.b_lucinda.Location = new System.Drawing.Point(19, 69);
            this.b_lucinda.Margin = new System.Windows.Forms.Padding(10);
            this.b_lucinda.Name = "b_lucinda";
            this.b_lucinda.Size = new System.Drawing.Size(100, 30);
            this.b_lucinda.TabIndex = 1;
            this.b_lucinda.Text = "Lucinda";
            this.b_lucinda.UseVisualStyleBackColor = true;
            this.b_lucinda.Click += new System.EventHandler(this.b_lucinda_Click);
            // 
            // l_swap
            // 
            this.l_swap.Location = new System.Drawing.Point(19, 119);
            this.l_swap.Margin = new System.Windows.Forms.Padding(10);
            this.l_swap.Name = "l_swap";
            this.l_swap.Size = new System.Drawing.Size(100, 30);
            this.l_swap.TabIndex = 2;
            this.l_swap.Text = "Zamień!";
            this.l_swap.UseVisualStyleBackColor = true;
            this.l_swap.Click += new System.EventHandler(this.l_swap_Click);
            // 
            // l_extra
            // 
            this.l_extra.Location = new System.Drawing.Point(19, 169);
            this.l_extra.Margin = new System.Windows.Forms.Padding(10);
            this.l_extra.Name = "l_extra";
            this.l_extra.Size = new System.Drawing.Size(100, 30);
            this.l_extra.TabIndex = 3;
            this.l_extra.Text = "Extra";
            this.l_extra.UseVisualStyleBackColor = true;
            this.l_extra.Click += new System.EventHandler(this.l_extra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_extra);
            this.Controls.Add(this.l_swap);
            this.Controls.Add(this.b_lucinda);
            this.Controls.Add(this.b_lloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zamiana";
            this.ResumeLayout(false);

        }

        #endregion

        private Button b_lloyd;
        private Button b_lucinda;
        private Button l_swap;
        private Button l_extra;
    }
}