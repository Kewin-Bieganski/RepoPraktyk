namespace grayhoundRaceSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gB_betOptions = new System.Windows.Forms.GroupBox();
            this.tB_guy1 = new System.Windows.Forms.TextBox();
            this.rB_guy3 = new System.Windows.Forms.RadioButton();
            this.tB_guy2 = new System.Windows.Forms.TextBox();
            this.rB_guy2 = new System.Windows.Forms.RadioButton();
            this.rB_guy1 = new System.Windows.Forms.RadioButton();
            this.tB_guy3 = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.nUD_amount = new System.Windows.Forms.NumericUpDown();
            this.nUD_grayhoundNumber = new System.Windows.Forms.NumericUpDown();
            this.b_bet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_minimumBet = new System.Windows.Forms.Label();
            this.pB_grayhound4 = new System.Windows.Forms.PictureBox();
            this.pB_grayhound3 = new System.Windows.Forms.PictureBox();
            this.pB_grayhound2 = new System.Windows.Forms.PictureBox();
            this.pB_grayhound1 = new System.Windows.Forms.PictureBox();
            this.t_grayhoundRace = new System.Windows.Forms.Timer(this.components);
            this.p_racetrack = new System.Windows.Forms.Panel();
            this.gB_betOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_grayhoundNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound1)).BeginInit();
            this.p_racetrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_betOptions
            // 
            this.gB_betOptions.Controls.Add(this.tB_guy1);
            this.gB_betOptions.Controls.Add(this.rB_guy3);
            this.gB_betOptions.Controls.Add(this.tB_guy2);
            this.gB_betOptions.Controls.Add(this.rB_guy2);
            this.gB_betOptions.Controls.Add(this.rB_guy1);
            this.gB_betOptions.Controls.Add(this.tB_guy3);
            this.gB_betOptions.Controls.Add(this.b_start);
            this.gB_betOptions.Controls.Add(this.nUD_amount);
            this.gB_betOptions.Controls.Add(this.nUD_grayhoundNumber);
            this.gB_betOptions.Controls.Add(this.b_bet);
            this.gB_betOptions.Controls.Add(this.label4);
            this.gB_betOptions.Controls.Add(this.l_name);
            this.gB_betOptions.Controls.Add(this.label2);
            this.gB_betOptions.Controls.Add(this.l_minimumBet);
            this.gB_betOptions.Location = new System.Drawing.Point(19, 232);
            this.gB_betOptions.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.gB_betOptions.Name = "gB_betOptions";
            this.gB_betOptions.Size = new System.Drawing.Size(762, 199);
            this.gB_betOptions.TabIndex = 1;
            this.gB_betOptions.TabStop = false;
            this.gB_betOptions.Text = "Dom bukmacherski";
            // 
            // tB_guy1
            // 
            this.tB_guy1.Location = new System.Drawing.Point(250, 60);
            this.tB_guy1.Margin = new System.Windows.Forms.Padding(10);
            this.tB_guy1.Name = "tB_guy1";
            this.tB_guy1.ReadOnly = true;
            this.tB_guy1.Size = new System.Drawing.Size(297, 27);
            this.tB_guy1.TabIndex = 12;
            // 
            // rB_guy3
            // 
            this.rB_guy3.AutoSize = true;
            this.rB_guy3.Location = new System.Drawing.Point(13, 131);
            this.rB_guy3.Margin = new System.Windows.Forms.Padding(10, 4, 10, 6);
            this.rB_guy3.Name = "rB_guy3";
            this.rB_guy3.Size = new System.Drawing.Size(121, 24);
            this.rB_guy3.TabIndex = 9;
            this.rB_guy3.Text = "rB_guy3Radio";
            this.rB_guy3.UseVisualStyleBackColor = true;
            this.rB_guy3.CheckedChanged += new System.EventHandler(this.rB_guy3_CheckedChanged);
            // 
            // tB_guy2
            // 
            this.tB_guy2.Location = new System.Drawing.Point(250, 92);
            this.tB_guy2.Margin = new System.Windows.Forms.Padding(10);
            this.tB_guy2.Name = "tB_guy2";
            this.tB_guy2.ReadOnly = true;
            this.tB_guy2.Size = new System.Drawing.Size(297, 27);
            this.tB_guy2.TabIndex = 11;
            // 
            // rB_guy2
            // 
            this.rB_guy2.AutoSize = true;
            this.rB_guy2.Location = new System.Drawing.Point(13, 97);
            this.rB_guy2.Margin = new System.Windows.Forms.Padding(10, 4, 10, 6);
            this.rB_guy2.Name = "rB_guy2";
            this.rB_guy2.Size = new System.Drawing.Size(121, 24);
            this.rB_guy2.TabIndex = 8;
            this.rB_guy2.Text = "rB_guy2Radio";
            this.rB_guy2.UseVisualStyleBackColor = true;
            this.rB_guy2.CheckedChanged += new System.EventHandler(this.rB_guy2_CheckedChanged);
            // 
            // rB_guy1
            // 
            this.rB_guy1.AutoSize = true;
            this.rB_guy1.Checked = true;
            this.rB_guy1.Location = new System.Drawing.Point(13, 63);
            this.rB_guy1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.rB_guy1.Name = "rB_guy1";
            this.rB_guy1.Size = new System.Drawing.Size(121, 24);
            this.rB_guy1.TabIndex = 7;
            this.rB_guy1.TabStop = true;
            this.rB_guy1.Text = "rB_guy1Radio";
            this.rB_guy1.UseVisualStyleBackColor = true;
            this.rB_guy1.CheckedChanged += new System.EventHandler(this.rB_guy1_CheckedChanged);
            // 
            // tB_guy3
            // 
            this.tB_guy3.Location = new System.Drawing.Point(250, 126);
            this.tB_guy3.Margin = new System.Windows.Forms.Padding(10);
            this.tB_guy3.Name = "tB_guy3";
            this.tB_guy3.ReadOnly = true;
            this.tB_guy3.Size = new System.Drawing.Size(297, 27);
            this.tB_guy3.TabIndex = 10;
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Segoe UI Black", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.b_start.Location = new System.Drawing.Point(567, 33);
            this.b_start.Margin = new System.Windows.Forms.Padding(10);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(182, 153);
            this.b_start.TabIndex = 6;
            this.b_start.Text = "Start!";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // nUD_amount
            // 
            this.nUD_amount.Location = new System.Drawing.Point(250, 159);
            this.nUD_amount.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_amount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_amount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_amount.Name = "nUD_amount";
            this.nUD_amount.Size = new System.Drawing.Size(81, 27);
            this.nUD_amount.TabIndex = 5;
            this.nUD_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nUD_grayhoundNumber
            // 
            this.nUD_grayhoundNumber.Location = new System.Drawing.Point(502, 159);
            this.nUD_grayhoundNumber.Margin = new System.Windows.Forms.Padding(10);
            this.nUD_grayhoundNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD_grayhoundNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_grayhoundNumber.Name = "nUD_grayhoundNumber";
            this.nUD_grayhoundNumber.Size = new System.Drawing.Size(45, 27);
            this.nUD_grayhoundNumber.TabIndex = 4;
            this.nUD_grayhoundNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_bet
            // 
            this.b_bet.Location = new System.Drawing.Point(136, 157);
            this.b_bet.Margin = new System.Windows.Forms.Padding(10);
            this.b_bet.Name = "b_bet";
            this.b_bet.Size = new System.Drawing.Size(94, 29);
            this.b_bet.TabIndex = 3;
            this.b_bet.Text = "stawia";
            this.b_bet.UseVisualStyleBackColor = true;
            this.b_bet.Click += new System.EventHandler(this.b_bet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "zł na charta numer";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(13, 161);
            this.l_name.Margin = new System.Windows.Forms.Padding(10);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(56, 20);
            this.l_name.TabIndex = 2;
            this.l_name.Text = "l_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zakłady";
            // 
            // l_minimumBet
            // 
            this.l_minimumBet.AutoSize = true;
            this.l_minimumBet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_minimumBet.Location = new System.Drawing.Point(13, 33);
            this.l_minimumBet.Margin = new System.Windows.Forms.Padding(10, 10, 10, 4);
            this.l_minimumBet.Name = "l_minimumBet";
            this.l_minimumBet.Size = new System.Drawing.Size(127, 23);
            this.l_minimumBet.TabIndex = 0;
            this.l_minimumBet.Text = "l_minimumBet";
            // 
            // pB_grayhound4
            // 
            this.pB_grayhound4.Image = ((System.Drawing.Image)(resources.GetObject("pB_grayhound4.Image")));
            this.pB_grayhound4.Location = new System.Drawing.Point(0, 169);
            this.pB_grayhound4.Margin = new System.Windows.Forms.Padding(0);
            this.pB_grayhound4.Name = "pB_grayhound4";
            this.pB_grayhound4.Size = new System.Drawing.Size(113, 34);
            this.pB_grayhound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_grayhound4.TabIndex = 4;
            this.pB_grayhound4.TabStop = false;
            // 
            // pB_grayhound3
            // 
            this.pB_grayhound3.Image = ((System.Drawing.Image)(resources.GetObject("pB_grayhound3.Image")));
            this.pB_grayhound3.Location = new System.Drawing.Point(0, 110);
            this.pB_grayhound3.Margin = new System.Windows.Forms.Padding(0);
            this.pB_grayhound3.Name = "pB_grayhound3";
            this.pB_grayhound3.Size = new System.Drawing.Size(113, 34);
            this.pB_grayhound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_grayhound3.TabIndex = 5;
            this.pB_grayhound3.TabStop = false;
            // 
            // pB_grayhound2
            // 
            this.pB_grayhound2.Image = ((System.Drawing.Image)(resources.GetObject("pB_grayhound2.Image")));
            this.pB_grayhound2.Location = new System.Drawing.Point(0, 54);
            this.pB_grayhound2.Margin = new System.Windows.Forms.Padding(0);
            this.pB_grayhound2.Name = "pB_grayhound2";
            this.pB_grayhound2.Size = new System.Drawing.Size(113, 34);
            this.pB_grayhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_grayhound2.TabIndex = 6;
            this.pB_grayhound2.TabStop = false;
            // 
            // pB_grayhound1
            // 
            this.pB_grayhound1.Image = ((System.Drawing.Image)(resources.GetObject("pB_grayhound1.Image")));
            this.pB_grayhound1.Location = new System.Drawing.Point(0, 0);
            this.pB_grayhound1.Margin = new System.Windows.Forms.Padding(0);
            this.pB_grayhound1.Name = "pB_grayhound1";
            this.pB_grayhound1.Size = new System.Drawing.Size(113, 34);
            this.pB_grayhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_grayhound1.TabIndex = 7;
            this.pB_grayhound1.TabStop = false;
            // 
            // t_grayhoundRace
            // 
            this.t_grayhoundRace.Interval = 10;
            this.t_grayhoundRace.Tick += new System.EventHandler(this.t_grayhoundRace_Tick);
            // 
            // p_racetrack
            // 
            this.p_racetrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_racetrack.BackgroundImage")));
            this.p_racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_racetrack.Controls.Add(this.pB_grayhound2);
            this.p_racetrack.Controls.Add(this.pB_grayhound1);
            this.p_racetrack.Controls.Add(this.pB_grayhound4);
            this.p_racetrack.Controls.Add(this.pB_grayhound3);
            this.p_racetrack.Location = new System.Drawing.Point(19, 19);
            this.p_racetrack.Margin = new System.Windows.Forms.Padding(10);
            this.p_racetrack.Name = "p_racetrack";
            this.p_racetrack.Size = new System.Drawing.Size(762, 203);
            this.p_racetrack.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_racetrack);
            this.Controls.Add(this.gB_betOptions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            this.gB_betOptions.ResumeLayout(false);
            this.gB_betOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_grayhoundNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_grayhound1)).EndInit();
            this.p_racetrack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gB_betOptions;
        private Button b_bet;
        private Label label4;
        private Label l_name;
        private Label label2;
        private Label l_minimumBet;
        private PictureBox pB_grayhound4;
        private PictureBox pB_grayhound3;
        private PictureBox pB_grayhound2;
        private PictureBox pB_grayhound1;
        private Button b_start;
        private NumericUpDown nUD_amount;
        private NumericUpDown nUD_grayhoundNumber;
        private TextBox tB_guy1;
        private TextBox tB_guy2;
        private TextBox tB_guy3;
        private RadioButton rB_guy3;
        private RadioButton rB_guy2;
        private RadioButton rB_guy1;
        private System.Windows.Forms.Timer t_grayhoundRace;
        private Panel p_racetrack;
    }
}