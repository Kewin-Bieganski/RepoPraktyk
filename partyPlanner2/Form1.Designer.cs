namespace partyPlanner2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_cost = new System.Windows.Forms.Label();
            this.Koszt = new System.Windows.Forms.Label();
            this.cB_healthyOption = new System.Windows.Forms.CheckBox();
            this.cB_fancyDecorations = new System.Windows.Forms.CheckBox();
            this.nUD_numberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tB_cakeWriting2 = new System.Windows.Forms.TextBox();
            this.l_cakeWritingTooLong2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_cost2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUD_numberOfPeople2 = new System.Windows.Forms.NumericUpDown();
            this.cB_fancyDecorations2 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.l_cost);
            this.tabPage1.Controls.Add(this.Koszt);
            this.tabPage1.Controls.Add(this.cB_healthyOption);
            this.tabPage1.Controls.Add(this.cB_fancyDecorations);
            this.tabPage1.Controls.Add(this.nUD_numberOfPeople);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impreza okolicznościowa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // l_cost
            // 
            this.l_cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_cost.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_cost.Location = new System.Drawing.Point(78, 182);
            this.l_cost.Margin = new System.Windows.Forms.Padding(10);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(85, 20);
            this.l_cost.TabIndex = 11;
            this.l_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Koszt
            // 
            this.Koszt.AutoSize = true;
            this.Koszt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Koszt.Location = new System.Drawing.Point(13, 182);
            this.Koszt.Margin = new System.Windows.Forms.Padding(10);
            this.Koszt.Name = "Koszt";
            this.Koszt.Size = new System.Drawing.Size(50, 20);
            this.Koszt.TabIndex = 10;
            this.Koszt.Text = "Koszt";
            // 
            // cB_healthyOption
            // 
            this.cB_healthyOption.AutoSize = true;
            this.cB_healthyOption.Location = new System.Drawing.Point(13, 138);
            this.cB_healthyOption.Margin = new System.Windows.Forms.Padding(10);
            this.cB_healthyOption.Name = "cB_healthyOption";
            this.cB_healthyOption.Size = new System.Drawing.Size(123, 24);
            this.cB_healthyOption.TabIndex = 9;
            this.cB_healthyOption.Text = "Opcja zdrowa";
            this.cB_healthyOption.UseVisualStyleBackColor = true;
            this.cB_healthyOption.CheckedChanged += new System.EventHandler(this.cB_healthyOption_CheckedChanged);
            // 
            // cB_fancyDecorations
            // 
            this.cB_fancyDecorations.AutoSize = true;
            this.cB_fancyDecorations.Location = new System.Drawing.Point(13, 100);
            this.cB_fancyDecorations.Margin = new System.Windows.Forms.Padding(10);
            this.cB_fancyDecorations.Name = "cB_fancyDecorations";
            this.cB_fancyDecorations.Size = new System.Drawing.Size(170, 24);
            this.cB_fancyDecorations.TabIndex = 8;
            this.cB_fancyDecorations.Text = "Dekoracje fantazyjne";
            this.cB_fancyDecorations.UseVisualStyleBackColor = true;
            this.cB_fancyDecorations.CheckedChanged += new System.EventHandler(this.cB_fancyDecorations_CheckedChanged);
            // 
            // nUD_numberOfPeople
            // 
            this.nUD_numberOfPeople.Location = new System.Drawing.Point(13, 53);
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
            this.nUD_numberOfPeople.TabIndex = 7;
            this.nUD_numberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_numberOfPeople.ValueChanged += new System.EventHandler(this.nUD_numberOfPeople_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ilość osób";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tB_cakeWriting2);
            this.tabPage2.Controls.Add(this.l_cakeWritingTooLong2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.l_cost2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nUD_numberOfPeople2);
            this.tabPage2.Controls.Add(this.cB_fancyDecorations2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Przyjęcie urodzinowe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tB_cakeWriting2
            // 
            this.tB_cakeWriting2.Location = new System.Drawing.Point(13, 142);
            this.tB_cakeWriting2.Name = "tB_cakeWriting2";
            this.tB_cakeWriting2.Size = new System.Drawing.Size(150, 27);
            this.tB_cakeWriting2.TabIndex = 20;
            this.tB_cakeWriting2.Text = "Sto lat!";
            this.tB_cakeWriting2.TextChanged += new System.EventHandler(this.tB_cakeWriting2_TextChanged);
            // 
            // l_cakeWritingTooLong2
            // 
            this.l_cakeWritingTooLong2.AutoSize = true;
            this.l_cakeWritingTooLong2.BackColor = System.Drawing.Color.Red;
            this.l_cakeWritingTooLong2.Location = new System.Drawing.Point(132, 115);
            this.l_cakeWritingTooLong2.Name = "l_cakeWritingTooLong2";
            this.l_cakeWritingTooLong2.Size = new System.Drawing.Size(93, 20);
            this.l_cakeWritingTooLong2.TabIndex = 19;
            this.l_cakeWritingTooLong2.Text = "ZBYT DŁUGI!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Napis na torcie";
            // 
            // l_cost2
            // 
            this.l_cost2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_cost2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_cost2.Location = new System.Drawing.Point(78, 182);
            this.l_cost2.Margin = new System.Windows.Forms.Padding(10);
            this.l_cost2.Name = "l_cost2";
            this.l_cost2.Size = new System.Drawing.Size(85, 20);
            this.l_cost2.TabIndex = 17;
            this.l_cost2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ilość osób";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Koszt";
            // 
            // nUD_numberOfPeople2
            // 
            this.nUD_numberOfPeople2.Location = new System.Drawing.Point(13, 44);
            this.nUD_numberOfPeople2.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_numberOfPeople2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUD_numberOfPeople2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_numberOfPeople2.Name = "nUD_numberOfPeople2";
            this.nUD_numberOfPeople2.Size = new System.Drawing.Size(150, 27);
            this.nUD_numberOfPeople2.TabIndex = 13;
            this.nUD_numberOfPeople2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_numberOfPeople2.ValueChanged += new System.EventHandler(this.nUD_numberOfPeople2_ValueChanged);
            // 
            // cB_fancyDecorations2
            // 
            this.cB_fancyDecorations2.AutoSize = true;
            this.cB_fancyDecorations2.Location = new System.Drawing.Point(13, 81);
            this.cB_fancyDecorations2.Margin = new System.Windows.Forms.Padding(10);
            this.cB_fancyDecorations2.Name = "cB_fancyDecorations2";
            this.cB_fancyDecorations2.Size = new System.Drawing.Size(170, 24);
            this.cB_fancyDecorations2.TabIndex = 14;
            this.cB_fancyDecorations2.Text = "Dekoracje fantazyjne";
            this.cB_fancyDecorations2.UseVisualStyleBackColor = true;
            this.cB_fancyDecorations2.CheckedChanged += new System.EventHandler(this.cB_fancyDecorations2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista przyjęć 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_numberOfPeople2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label l_cost;
        private Label Koszt;
        private CheckBox cB_healthyOption;
        private CheckBox cB_fancyDecorations;
        private NumericUpDown nUD_numberOfPeople;
        private Label label1;
        private Label l_cost2;
        private Label label4;
        private Label label3;
        private NumericUpDown nUD_numberOfPeople2;
        private CheckBox cB_fancyDecorations2;
        private TextBox tB_cakeWriting2;
        private Label l_cakeWritingTooLong2;
        private Label label5;
    }
}