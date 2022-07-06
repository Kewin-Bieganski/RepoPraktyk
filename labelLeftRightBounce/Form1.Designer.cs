namespace labelLeftRightBounce
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
            this.t_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_ball = new System.Windows.Forms.Label();
            this.b_diamondControl = new System.Windows.Forms.Button();
            this.b_boxControl = new System.Windows.Forms.Button();
            this.b_ballControl = new System.Windows.Forms.Button();
            this.l_diamond = new System.Windows.Forms.Label();
            this.l_box = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_timer
            // 
            this.t_timer.Enabled = true;
            this.t_timer.Interval = 1;
            this.t_timer.Tick += new System.EventHandler(this.t_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.l_ball);
            this.panel1.Controls.Add(this.b_diamondControl);
            this.panel1.Controls.Add(this.b_boxControl);
            this.panel1.Controls.Add(this.b_ballControl);
            this.panel1.Controls.Add(this.l_diamond);
            this.panel1.Controls.Add(this.l_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 453);
            this.panel1.TabIndex = 6;
            // 
            // l_ball
            // 
            this.l_ball.BackColor = System.Drawing.Color.Red;
            this.l_ball.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_ball.ForeColor = System.Drawing.Color.Transparent;
            this.l_ball.Location = new System.Drawing.Point(10, 423);
            this.l_ball.Margin = new System.Windows.Forms.Padding(10);
            this.l_ball.Name = "l_ball";
            this.l_ball.Size = new System.Drawing.Size(40, 20);
            this.l_ball.TabIndex = 6;
            this.l_ball.Text = "(@)";
            // 
            // b_diamondControl
            // 
            this.b_diamondControl.BackColor = System.Drawing.Color.White;
            this.b_diamondControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_diamondControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_diamondControl.Location = new System.Drawing.Point(19, 117);
            this.b_diamondControl.Margin = new System.Windows.Forms.Padding(10);
            this.b_diamondControl.Name = "b_diamondControl";
            this.b_diamondControl.Size = new System.Drawing.Size(168, 29);
            this.b_diamondControl.TabIndex = 11;
            this.b_diamondControl.Text = "Kontrola diamentu";
            this.b_diamondControl.UseVisualStyleBackColor = false;
            this.b_diamondControl.Click += new System.EventHandler(this.b_diamondControl_Click);
            // 
            // b_boxControl
            // 
            this.b_boxControl.BackColor = System.Drawing.Color.White;
            this.b_boxControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_boxControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_boxControl.Location = new System.Drawing.Point(19, 68);
            this.b_boxControl.Margin = new System.Windows.Forms.Padding(10);
            this.b_boxControl.Name = "b_boxControl";
            this.b_boxControl.Size = new System.Drawing.Size(168, 29);
            this.b_boxControl.TabIndex = 10;
            this.b_boxControl.Text = "Kontrola skrzynki";
            this.b_boxControl.UseVisualStyleBackColor = false;
            this.b_boxControl.Click += new System.EventHandler(this.b_boxControl_Click);
            // 
            // b_ballControl
            // 
            this.b_ballControl.BackColor = System.Drawing.Color.White;
            this.b_ballControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_ballControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_ballControl.Location = new System.Drawing.Point(19, 19);
            this.b_ballControl.Margin = new System.Windows.Forms.Padding(10);
            this.b_ballControl.Name = "b_ballControl";
            this.b_ballControl.Size = new System.Drawing.Size(168, 29);
            this.b_ballControl.TabIndex = 9;
            this.b_ballControl.Text = "Kontrola piłki";
            this.b_ballControl.UseVisualStyleBackColor = false;
            this.b_ballControl.Click += new System.EventHandler(this.b_ballControl_Click);
            // 
            // l_diamond
            // 
            this.l_diamond.BackColor = System.Drawing.Color.Fuchsia;
            this.l_diamond.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_diamond.ForeColor = System.Drawing.Color.Lime;
            this.l_diamond.Location = new System.Drawing.Point(432, 423);
            this.l_diamond.Margin = new System.Windows.Forms.Padding(10);
            this.l_diamond.Name = "l_diamond";
            this.l_diamond.Size = new System.Drawing.Size(40, 20);
            this.l_diamond.TabIndex = 8;
            this.l_diamond.Text = "<$>";
            // 
            // l_box
            // 
            this.l_box.BackColor = System.Drawing.Color.Yellow;
            this.l_box.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_box.ForeColor = System.Drawing.Color.Blue;
            this.l_box.Location = new System.Drawing.Point(432, 10);
            this.l_box.Margin = new System.Windows.Forms.Padding(10);
            this.l_box.Name = "l_box";
            this.l_box.Size = new System.Drawing.Size(40, 20);
            this.l_box.TabIndex = 7;
            this.l_box.Text = "[#]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Control Bouncer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer t_timer;
        private Panel panel1;
        private Label l_ball;
        private Button b_diamondControl;
        private Button b_boxControl;
        private Button b_ballControl;
        private Label l_diamond;
        private Label l_box;
    }
}