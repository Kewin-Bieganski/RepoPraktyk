namespace graWLiterki
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
            this.components = new System.ComponentModel.Container();
            this.lB_letters = new System.Windows.Forms.ListBox();
            this.t_gameTimer = new System.Windows.Forms.Timer(this.components);
            this.sS_infoBar = new System.Windows.Forms.StatusStrip();
            this.tSSL_correct = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_missed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_total = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_accuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_difficultyLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSB_difficultyLevel = new System.Windows.Forms.ToolStripProgressBar();
            this.sS_infoBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lB_letters
            // 
            this.lB_letters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lB_letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lB_letters.FormattingEnabled = true;
            this.lB_letters.ItemHeight = 135;
            this.lB_letters.Location = new System.Drawing.Point(0, 0);
            this.lB_letters.Margin = new System.Windows.Forms.Padding(0);
            this.lB_letters.MultiColumn = true;
            this.lB_letters.Name = "lB_letters";
            this.lB_letters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lB_letters.Size = new System.Drawing.Size(854, 162);
            this.lB_letters.TabIndex = 0;
            this.lB_letters.Click += new System.EventHandler(this.lB_letters_restart_Click);
            // 
            // t_gameTimer
            // 
            this.t_gameTimer.Enabled = true;
            this.t_gameTimer.Interval = 800;
            this.t_gameTimer.Tick += new System.EventHandler(this.t_gameTimer_Tick);
            // 
            // sS_infoBar
            // 
            this.sS_infoBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sS_infoBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_correct,
            this.tSSL_missed,
            this.tSSL_total,
            this.tSSL_accuracy,
            this.tSSL_difficultyLevel,
            this.tSSB_difficultyLevel});
            this.sS_infoBar.Location = new System.Drawing.Point(0, 136);
            this.sS_infoBar.Name = "sS_infoBar";
            this.sS_infoBar.Size = new System.Drawing.Size(854, 26);
            this.sS_infoBar.SizingGrip = false;
            this.sS_infoBar.TabIndex = 1;
            this.sS_infoBar.Text = "statusStrip1";
            // 
            // tSSL_correct
            // 
            this.tSSL_correct.Name = "tSSL_correct";
            this.tSSL_correct.Size = new System.Drawing.Size(115, 20);
            this.tSSL_correct.Text = "Prawidłowych: 0";
            // 
            // tSSL_missed
            // 
            this.tSSL_missed.Name = "tSSL_missed";
            this.tSSL_missed.Size = new System.Drawing.Size(74, 20);
            this.tSSL_missed.Text = "Błędów: 0";
            // 
            // tSSL_total
            // 
            this.tSSL_total.Name = "tSSL_total";
            this.tSSL_total.Size = new System.Drawing.Size(95, 20);
            this.tSSL_total.Text = "Wszystkich: 0";
            // 
            // tSSL_accuracy
            // 
            this.tSSL_accuracy.Name = "tSSL_accuracy";
            this.tSSL_accuracy.Size = new System.Drawing.Size(114, 20);
            this.tSSL_accuracy.Text = "Dokładność: 0%";
            // 
            // tSSL_difficultyLevel
            // 
            this.tSSL_difficultyLevel.Name = "tSSL_difficultyLevel";
            this.tSSL_difficultyLevel.Size = new System.Drawing.Size(339, 20);
            this.tSSL_difficultyLevel.Spring = true;
            this.tSSL_difficultyLevel.Text = "Poziom trudności:";
            this.tSSL_difficultyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSSB_difficultyLevel
            // 
            this.tSSB_difficultyLevel.Maximum = 701;
            this.tSSB_difficultyLevel.Name = "tSSB_difficultyLevel";
            this.tSSB_difficultyLevel.Size = new System.Drawing.Size(100, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 162);
            this.Controls.Add(this.sS_infoBar);
            this.Controls.Add(this.lB_letters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gra w literki";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.sS_infoBar.ResumeLayout(false);
            this.sS_infoBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lB_letters;
        private System.Windows.Forms.Timer t_gameTimer;
        private StatusStrip sS_infoBar;
        private ToolStripStatusLabel tSSL_correct;
        private ToolStripStatusLabel tSSL_missed;
        private ToolStripStatusLabel tSSL_total;
        private ToolStripStatusLabel tSSL_accuracy;
        private ToolStripStatusLabel tSSL_difficultyLevel;
        private ToolStripProgressBar tSSB_difficultyLevel;
    }
}