namespace lumberjackDinner
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
            this.tB_name = new System.Windows.Forms.TextBox();
            this.b_addLumberjack = new System.Windows.Forms.Button();
            this.lB_queue = new System.Windows.Forms.ListBox();
            this.nUD_count = new System.Windows.Forms.NumericUpDown();
            this.rB_crispy = new System.Windows.Forms.RadioButton();
            this.rB_soggy = new System.Windows.Forms.RadioButton();
            this.rB_ruddy = new System.Windows.Forms.RadioButton();
            this.rB_banana = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_status = new System.Windows.Forms.Label();
            this.b_nextLumberjack = new System.Windows.Forms.Button();
            this.b_addFlapjacks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_count)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię drwala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolejka do śniadania";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(126, 16);
            this.tB_name.Margin = new System.Windows.Forms.Padding(10);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(310, 27);
            this.tB_name.TabIndex = 2;
            // 
            // b_addLumberjack
            // 
            this.b_addLumberjack.Location = new System.Drawing.Point(19, 59);
            this.b_addLumberjack.Margin = new System.Windows.Forms.Padding(10);
            this.b_addLumberjack.Name = "b_addLumberjack";
            this.b_addLumberjack.Size = new System.Drawing.Size(417, 29);
            this.b_addLumberjack.TabIndex = 3;
            this.b_addLumberjack.Text = "Dodaj drwala";
            this.b_addLumberjack.UseVisualStyleBackColor = true;
            this.b_addLumberjack.Click += new System.EventHandler(this.b_addLumberjack_Click);
            // 
            // lB_queue
            // 
            this.lB_queue.FormattingEnabled = true;
            this.lB_queue.ItemHeight = 20;
            this.lB_queue.Location = new System.Drawing.Point(19, 148);
            this.lB_queue.Margin = new System.Windows.Forms.Padding(10);
            this.lB_queue.Name = "lB_queue";
            this.lB_queue.Size = new System.Drawing.Size(147, 364);
            this.lB_queue.TabIndex = 4;
            // 
            // nUD_count
            // 
            this.nUD_count.Location = new System.Drawing.Point(13, 33);
            this.nUD_count.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_count.Name = "nUD_count";
            this.nUD_count.Size = new System.Drawing.Size(77, 27);
            this.nUD_count.TabIndex = 5;
            // 
            // rB_crispy
            // 
            this.rB_crispy.AutoSize = true;
            this.rB_crispy.Location = new System.Drawing.Point(13, 80);
            this.rB_crispy.Margin = new System.Windows.Forms.Padding(10);
            this.rB_crispy.Name = "rB_crispy";
            this.rB_crispy.Size = new System.Drawing.Size(106, 24);
            this.rB_crispy.TabIndex = 6;
            this.rB_crispy.TabStop = true;
            this.rB_crispy.Text = "Chrupkiego";
            this.rB_crispy.UseVisualStyleBackColor = true;
            // 
            // rB_soggy
            // 
            this.rB_soggy.AutoSize = true;
            this.rB_soggy.Location = new System.Drawing.Point(13, 114);
            this.rB_soggy.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.rB_soggy.Name = "rB_soggy";
            this.rB_soggy.Size = new System.Drawing.Size(109, 24);
            this.rB_soggy.TabIndex = 7;
            this.rB_soggy.TabStop = true;
            this.rB_soggy.Text = "Wilgotnego";
            this.rB_soggy.UseVisualStyleBackColor = true;
            // 
            // rB_ruddy
            // 
            this.rB_ruddy.AutoSize = true;
            this.rB_ruddy.Location = new System.Drawing.Point(13, 148);
            this.rB_ruddy.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.rB_ruddy.Name = "rB_ruddy";
            this.rB_ruddy.Size = new System.Drawing.Size(106, 24);
            this.rB_ruddy.TabIndex = 8;
            this.rB_ruddy.TabStop = true;
            this.rB_ruddy.Text = "Rumianego";
            this.rB_ruddy.UseVisualStyleBackColor = true;
            // 
            // rB_banana
            // 
            this.rB_banana.AutoSize = true;
            this.rB_banana.Location = new System.Drawing.Point(13, 182);
            this.rB_banana.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.rB_banana.Name = "rB_banana";
            this.rB_banana.Size = new System.Drawing.Size(117, 24);
            this.rB_banana.TabIndex = 9;
            this.rB_banana.TabStop = true;
            this.rB_banana.Text = "Bananowego";
            this.rB_banana.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_status);
            this.groupBox1.Controls.Add(this.b_nextLumberjack);
            this.groupBox1.Controls.Add(this.nUD_count);
            this.groupBox1.Controls.Add(this.rB_crispy);
            this.groupBox1.Controls.Add(this.b_addFlapjacks);
            this.groupBox1.Controls.Add(this.rB_soggy);
            this.groupBox1.Controls.Add(this.rB_banana);
            this.groupBox1.Controls.Add(this.rB_ruddy);
            this.groupBox1.Location = new System.Drawing.Point(186, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 404);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nakarm drwala";
            // 
            // l_status
            // 
            this.l_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_status.Location = new System.Drawing.Point(13, 275);
            this.l_status.Margin = new System.Windows.Forms.Padding(10);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(224, 64);
            this.l_status.TabIndex = 2;
            // 
            // b_nextLumberjack
            // 
            this.b_nextLumberjack.Location = new System.Drawing.Point(13, 359);
            this.b_nextLumberjack.Margin = new System.Windows.Forms.Padding(10);
            this.b_nextLumberjack.Name = "b_nextLumberjack";
            this.b_nextLumberjack.Size = new System.Drawing.Size(224, 29);
            this.b_nextLumberjack.TabIndex = 1;
            this.b_nextLumberjack.Text = "Następny drwal";
            this.b_nextLumberjack.UseVisualStyleBackColor = true;
            this.b_nextLumberjack.Click += new System.EventHandler(this.b_nextLumberjack_Click);
            // 
            // b_addFlapjacks
            // 
            this.b_addFlapjacks.Location = new System.Drawing.Point(13, 226);
            this.b_addFlapjacks.Margin = new System.Windows.Forms.Padding(10);
            this.b_addFlapjacks.Name = "b_addFlapjacks";
            this.b_addFlapjacks.Size = new System.Drawing.Size(224, 29);
            this.b_addFlapjacks.TabIndex = 0;
            this.b_addFlapjacks.Text = "Dodaj naleśniki";
            this.b_addFlapjacks.UseVisualStyleBackColor = true;
            this.b_addFlapjacks.Click += new System.EventHandler(this.b_addFlapjacks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lB_queue);
            this.Controls.Add(this.b_addLumberjack);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Śniadanie dla drwali";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tB_name;
        private Button b_addLumberjack;
        private ListBox lB_queue;
        private NumericUpDown nUD_count;
        private RadioButton rB_crispy;
        private RadioButton rB_soggy;
        private RadioButton rB_ruddy;
        private RadioButton rB_banana;
        private GroupBox groupBox1;
        private Label l_status;
        private Button b_nextLumberjack;
        private Button b_addFlapjacks;
    }
}