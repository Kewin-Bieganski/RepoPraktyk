namespace hiveManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_assignWork = new System.Windows.Forms.Button();
            this.nUD_shiftCount = new System.Windows.Forms.NumericUpDown();
            this.cBox_workerJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_nextShift = new System.Windows.Forms.Button();
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_shiftCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_assignWork);
            this.groupBox1.Controls.Add(this.nUD_shiftCount);
            this.groupBox1.Controls.Add(this.cBox_workerJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // b_assignWork
            // 
            this.b_assignWork.Location = new System.Drawing.Point(13, 121);
            this.b_assignWork.Margin = new System.Windows.Forms.Padding(10);
            this.b_assignWork.Name = "b_assignWork";
            this.b_assignWork.Size = new System.Drawing.Size(506, 29);
            this.b_assignWork.TabIndex = 4;
            this.b_assignWork.Text = "Przypisz tę pracę pszczole";
            this.b_assignWork.UseVisualStyleBackColor = true;
            this.b_assignWork.Click += new System.EventHandler(this.b_assignWork_Click);
            // 
            // nUD_shiftCount
            // 
            this.nUD_shiftCount.Location = new System.Drawing.Point(369, 74);
            this.nUD_shiftCount.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_shiftCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_shiftCount.Name = "nUD_shiftCount";
            this.nUD_shiftCount.Size = new System.Drawing.Size(150, 27);
            this.nUD_shiftCount.TabIndex = 3;
            this.nUD_shiftCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cBox_workerJob
            // 
            this.cBox_workerJob.FormattingEnabled = true;
            this.cBox_workerJob.Items.AddRange(new object[] {
            "Nauczanie pszczółek",
            "Pielęgnacja jaj",
            "Utrzymanie ula",
            "Wytwarzanie miodu",
            "Zbieranie nektaru",
            "Patrol z żądłami"});
            this.cBox_workerJob.Location = new System.Drawing.Point(13, 73);
            this.cBox_workerJob.Margin = new System.Windows.Forms.Padding(10);
            this.cBox_workerJob.Name = "cBox_workerJob";
            this.cBox_workerJob.Size = new System.Drawing.Size(336, 28);
            this.cBox_workerJob.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zmiany";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // b_nextShift
            // 
            this.b_nextShift.Location = new System.Drawing.Point(571, 28);
            this.b_nextShift.Margin = new System.Windows.Forms.Padding(10);
            this.b_nextShift.Name = "b_nextShift";
            this.b_nextShift.Size = new System.Drawing.Size(210, 160);
            this.b_nextShift.TabIndex = 1;
            this.b_nextShift.Text = "Przepracuj następną zmianę";
            this.b_nextShift.UseVisualStyleBackColor = true;
            this.b_nextShift.Click += new System.EventHandler(this.b_nextShift_Click);
            // 
            // rTB_output
            // 
            this.rTB_output.Location = new System.Drawing.Point(19, 208);
            this.rTB_output.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.Size = new System.Drawing.Size(762, 223);
            this.rTB_output.TabIndex = 2;
            this.rTB_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTB_output);
            this.Controls.Add(this.b_nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "System zarządzania ulem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_shiftCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button b_assignWork;
        private NumericUpDown nUD_shiftCount;
        private ComboBox cBox_workerJob;
        private Label label2;
        private Label label1;
        private Button b_nextShift;
        private RichTextBox rTB_output;
    }
}