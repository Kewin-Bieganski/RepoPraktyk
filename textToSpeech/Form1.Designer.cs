namespace textToSpeech
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
            this.rTB_text = new System.Windows.Forms.RichTextBox();
            this.b_speak = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.tBar_speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // rTB_text
            // 
            this.rTB_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTB_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_text.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTB_text.ForeColor = System.Drawing.Color.White;
            this.rTB_text.Location = new System.Drawing.Point(19, 62);
            this.rTB_text.Margin = new System.Windows.Forms.Padding(10);
            this.rTB_text.Name = "rTB_text";
            this.rTB_text.Size = new System.Drawing.Size(762, 524);
            this.rTB_text.TabIndex = 0;
            this.rTB_text.Text = "";
            // 
            // b_speak
            // 
            this.b_speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_speak.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_speak.ForeColor = System.Drawing.Color.White;
            this.b_speak.Location = new System.Drawing.Point(19, 19);
            this.b_speak.Margin = new System.Windows.Forms.Padding(10);
            this.b_speak.Name = "b_speak";
            this.b_speak.Size = new System.Drawing.Size(94, 29);
            this.b_speak.TabIndex = 1;
            this.b_speak.Text = "🗣️ Speak";
            this.b_speak.UseVisualStyleBackColor = false;
            this.b_speak.Click += new System.EventHandler(this.b_speak_Click);
            // 
            // b_stop
            // 
            this.b_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_stop.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_stop.ForeColor = System.Drawing.Color.White;
            this.b_stop.Location = new System.Drawing.Point(133, 19);
            this.b_stop.Margin = new System.Windows.Forms.Padding(10);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(94, 29);
            this.b_stop.TabIndex = 2;
            this.b_stop.Text = "🛑 Stop";
            this.b_stop.UseVisualStyleBackColor = false;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_clear.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_clear.ForeColor = System.Drawing.Color.White;
            this.b_clear.Location = new System.Drawing.Point(247, 19);
            this.b_clear.Margin = new System.Windows.Forms.Padding(10);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(94, 29);
            this.b_clear.TabIndex = 3;
            this.b_clear.Text = "❌Clear";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // tBar_speed
            // 
            this.tBar_speed.Location = new System.Drawing.Point(507, 19);
            this.tBar_speed.Margin = new System.Windows.Forms.Padding(10);
            this.tBar_speed.Name = "tBar_speed";
            this.tBar_speed.Size = new System.Drawing.Size(274, 56);
            this.tBar_speed.TabIndex = 4;
            this.tBar_speed.Value = 5;
            this.tBar_speed.Scroll += new System.EventHandler(this.tBar_speed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.b_speak);
            this.Controls.Add(this.rTB_text);
            this.Controls.Add(this.tBar_speed);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Read For Me";
            ((System.ComponentModel.ISupportInitialize)(this.tBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rTB_text;
        private Button b_speak;
        private Button b_stop;
        private Button b_clear;
        private TrackBar tBar_speed;
        private Label label1;
    }
}