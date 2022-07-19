namespace goFish
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lB_hand = new System.Windows.Forms.ListBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_progress = new System.Windows.Forms.TextBox();
            this.tB_books = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.b_ask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Postępy gry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ręka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 585);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupy";
            // 
            // lB_hand
            // 
            this.lB_hand.FormattingEnabled = true;
            this.lB_hand.ItemHeight = 20;
            this.lB_hand.Location = new System.Drawing.Point(374, 59);
            this.lB_hand.Margin = new System.Windows.Forms.Padding(10);
            this.lB_hand.Name = "lB_hand";
            this.lB_hand.Size = new System.Drawing.Size(180, 644);
            this.lB_hand.TabIndex = 4;
            this.lB_hand.DoubleClick += new System.EventHandler(this.b_ask_Click);
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(19, 59);
            this.tB_name.Margin = new System.Windows.Forms.Padding(10);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(190, 27);
            this.tB_name.TabIndex = 5;
            // 
            // tB_progress
            // 
            this.tB_progress.Location = new System.Drawing.Point(19, 146);
            this.tB_progress.Margin = new System.Windows.Forms.Padding(10);
            this.tB_progress.Multiline = true;
            this.tB_progress.Name = "tB_progress";
            this.tB_progress.ReadOnly = true;
            this.tB_progress.Size = new System.Drawing.Size(335, 419);
            this.tB_progress.TabIndex = 6;
            // 
            // tB_books
            // 
            this.tB_books.Location = new System.Drawing.Point(19, 625);
            this.tB_books.Margin = new System.Windows.Forms.Padding(10);
            this.tB_books.Multiline = true;
            this.tB_books.Name = "tB_books";
            this.tB_books.ReadOnly = true;
            this.tB_books.Size = new System.Drawing.Size(335, 127);
            this.tB_books.TabIndex = 7;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(229, 59);
            this.b_start.Margin = new System.Windows.Forms.Padding(10);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(125, 29);
            this.b_start.TabIndex = 8;
            this.b_start.Text = "Rozpocznij grę!";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_ask
            // 
            this.b_ask.Enabled = false;
            this.b_ask.Location = new System.Drawing.Point(374, 723);
            this.b_ask.Margin = new System.Windows.Forms.Padding(10);
            this.b_ask.Name = "b_ask";
            this.b_ask.Size = new System.Drawing.Size(180, 29);
            this.b_ask.TabIndex = 9;
            this.b_ask.Text = "Zażądaj karty";
            this.b_ask.UseVisualStyleBackColor = true;
            this.b_ask.Click += new System.EventHandler(this.b_ask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 772);
            this.Controls.Add(this.b_ask);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.tB_books);
            this.Controls.Add(this.tB_progress);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.lB_hand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Idź na ryby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lB_hand;
        private TextBox tB_name;
        private TextBox tB_progress;
        private TextBox tB_books;
        private Button b_start;
        private Button b_ask;
    }
}