namespace partyPlanner
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
            this.nUD_numberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.cB_fancyDecorations = new System.Windows.Forms.CheckBox();
            this.cB_healthyOption = new System.Windows.Forms.CheckBox();
            this.Koszt = new System.Windows.Forms.Label();
            this.l_cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osób";
            // 
            // nUD_numberOfPeople
            // 
            this.nUD_numberOfPeople.Location = new System.Drawing.Point(19, 59);
            this.nUD_numberOfPeople.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_numberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUD_numberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_numberOfPeople.Name = "nUD_numberOfPeople";
            this.nUD_numberOfPeople.Size = new System.Drawing.Size(150, 27);
            this.nUD_numberOfPeople.TabIndex = 1;
            this.nUD_numberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_numberOfPeople.ValueChanged += new System.EventHandler(this.nUD_numberOfPeople_ValueChanged);
            // 
            // cB_fancyDecorations
            // 
            this.cB_fancyDecorations.AutoSize = true;
            this.cB_fancyDecorations.Location = new System.Drawing.Point(19, 106);
            this.cB_fancyDecorations.Margin = new System.Windows.Forms.Padding(10);
            this.cB_fancyDecorations.Name = "cB_fancyDecorations";
            this.cB_fancyDecorations.Size = new System.Drawing.Size(170, 24);
            this.cB_fancyDecorations.TabIndex = 2;
            this.cB_fancyDecorations.Text = "Dekoracje fantazyjne";
            this.cB_fancyDecorations.UseVisualStyleBackColor = true;
            this.cB_fancyDecorations.CheckedChanged += new System.EventHandler(this.cB_fancyDecorations_CheckedChanged);
            // 
            // cB_healthyOption
            // 
            this.cB_healthyOption.AutoSize = true;
            this.cB_healthyOption.Location = new System.Drawing.Point(19, 144);
            this.cB_healthyOption.Margin = new System.Windows.Forms.Padding(10);
            this.cB_healthyOption.Name = "cB_healthyOption";
            this.cB_healthyOption.Size = new System.Drawing.Size(123, 24);
            this.cB_healthyOption.TabIndex = 3;
            this.cB_healthyOption.Text = "Opcja zdrowa";
            this.cB_healthyOption.UseVisualStyleBackColor = true;
            this.cB_healthyOption.CheckedChanged += new System.EventHandler(this.cB_healthyOption_CheckedChanged);
            // 
            // Koszt
            // 
            this.Koszt.AutoSize = true;
            this.Koszt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Koszt.Location = new System.Drawing.Point(19, 188);
            this.Koszt.Margin = new System.Windows.Forms.Padding(10);
            this.Koszt.Name = "Koszt";
            this.Koszt.Size = new System.Drawing.Size(50, 20);
            this.Koszt.TabIndex = 4;
            this.Koszt.Text = "Koszt";
            // 
            // l_cost
            // 
            this.l_cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_cost.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_cost.Location = new System.Drawing.Point(84, 188);
            this.l_cost.Margin = new System.Windows.Forms.Padding(10);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(85, 20);
            this.l_cost.TabIndex = 5;
            this.l_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_cost);
            this.Controls.Add(this.Koszt);
            this.Controls.Add(this.cB_healthyOption);
            this.Controls.Add(this.cB_fancyDecorations);
            this.Controls.Add(this.nUD_numberOfPeople);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown nUD_numberOfPeople;
        private CheckBox cB_fancyDecorations;
        private CheckBox cB_healthyOption;
        private Label Koszt;
        private Label l_cost;
    }
}