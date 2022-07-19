namespace serializeAClass
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
            this.l_joeCash = new System.Windows.Forms.Label();
            this.b_giveToJoe = new System.Windows.Forms.Button();
            this.l_bobCash = new System.Windows.Forms.Label();
            this.l_bankCash = new System.Windows.Forms.Label();
            this.b_receiveFromBob = new System.Windows.Forms.Button();
            this.b_bobToJoe = new System.Windows.Forms.Button();
            this.b_joeToBob = new System.Windows.Forms.Button();
            this.b_saveJoe = new System.Windows.Forms.Button();
            this.b_readJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_joeCash
            // 
            this.l_joeCash.AutoSize = true;
            this.l_joeCash.Location = new System.Drawing.Point(19, 19);
            this.l_joeCash.Margin = new System.Windows.Forms.Padding(10);
            this.l_joeCash.Name = "l_joeCash";
            this.l_joeCash.Size = new System.Drawing.Size(31, 20);
            this.l_joeCash.TabIndex = 0;
            this.l_joeCash.Text = "Joe";
            // 
            // b_giveToJoe
            // 
            this.b_giveToJoe.Location = new System.Drawing.Point(19, 139);
            this.b_giveToJoe.Margin = new System.Windows.Forms.Padding(10);
            this.b_giveToJoe.Name = "b_giveToJoe";
            this.b_giveToJoe.Size = new System.Drawing.Size(188, 29);
            this.b_giveToJoe.TabIndex = 1;
            this.b_giveToJoe.Text = "Daj 10 zł Joemu";
            this.b_giveToJoe.UseVisualStyleBackColor = true;
            this.b_giveToJoe.Click += new System.EventHandler(this.b_giveToJoe_Click);
            // 
            // l_bobCash
            // 
            this.l_bobCash.AutoSize = true;
            this.l_bobCash.Location = new System.Drawing.Point(50, 59);
            this.l_bobCash.Margin = new System.Windows.Forms.Padding(10);
            this.l_bobCash.Name = "l_bobCash";
            this.l_bobCash.Size = new System.Drawing.Size(36, 20);
            this.l_bobCash.TabIndex = 2;
            this.l_bobCash.Text = "Bob";
            // 
            // l_bankCash
            // 
            this.l_bankCash.AutoSize = true;
            this.l_bankCash.Location = new System.Drawing.Point(86, 99);
            this.l_bankCash.Margin = new System.Windows.Forms.Padding(10);
            this.l_bankCash.Name = "l_bankCash";
            this.l_bankCash.Size = new System.Drawing.Size(41, 20);
            this.l_bankCash.TabIndex = 3;
            this.l_bankCash.Text = "Bank";
            // 
            // b_receiveFromBob
            // 
            this.b_receiveFromBob.Location = new System.Drawing.Point(227, 139);
            this.b_receiveFromBob.Margin = new System.Windows.Forms.Padding(10);
            this.b_receiveFromBob.Name = "b_receiveFromBob";
            this.b_receiveFromBob.Size = new System.Drawing.Size(188, 29);
            this.b_receiveFromBob.TabIndex = 4;
            this.b_receiveFromBob.Text = "Weź 5 zł od Boba";
            this.b_receiveFromBob.UseVisualStyleBackColor = true;
            this.b_receiveFromBob.Click += new System.EventHandler(this.b_receiveFromBob_Click);
            // 
            // b_bobToJoe
            // 
            this.b_bobToJoe.Location = new System.Drawing.Point(227, 188);
            this.b_bobToJoe.Margin = new System.Windows.Forms.Padding(10);
            this.b_bobToJoe.Name = "b_bobToJoe";
            this.b_bobToJoe.Size = new System.Drawing.Size(188, 29);
            this.b_bobToJoe.TabIndex = 6;
            this.b_bobToJoe.Text = "Bob daje 5 zł Joemu";
            this.b_bobToJoe.UseVisualStyleBackColor = true;
            this.b_bobToJoe.Click += new System.EventHandler(this.b_bobToJoe_Click);
            // 
            // b_joeToBob
            // 
            this.b_joeToBob.Location = new System.Drawing.Point(19, 188);
            this.b_joeToBob.Margin = new System.Windows.Forms.Padding(10);
            this.b_joeToBob.Name = "b_joeToBob";
            this.b_joeToBob.Size = new System.Drawing.Size(188, 29);
            this.b_joeToBob.TabIndex = 5;
            this.b_joeToBob.Text = "Joe daje 10 zł Bobowi";
            this.b_joeToBob.UseVisualStyleBackColor = true;
            this.b_joeToBob.Click += new System.EventHandler(this.b_joeToBob_Click);
            // 
            // b_saveJoe
            // 
            this.b_saveJoe.Location = new System.Drawing.Point(19, 237);
            this.b_saveJoe.Margin = new System.Windows.Forms.Padding(10);
            this.b_saveJoe.Name = "b_saveJoe";
            this.b_saveJoe.Size = new System.Drawing.Size(188, 29);
            this.b_saveJoe.TabIndex = 7;
            this.b_saveJoe.Text = "Zapisz Joego";
            this.b_saveJoe.UseVisualStyleBackColor = true;
            this.b_saveJoe.Click += new System.EventHandler(this.b_saveJoe_Click);
            // 
            // b_readJoe
            // 
            this.b_readJoe.Location = new System.Drawing.Point(227, 237);
            this.b_readJoe.Margin = new System.Windows.Forms.Padding(10);
            this.b_readJoe.Name = "b_readJoe";
            this.b_readJoe.Size = new System.Drawing.Size(188, 29);
            this.b_readJoe.TabIndex = 8;
            this.b_readJoe.Text = "Wczytaj Joego";
            this.b_readJoe.UseVisualStyleBackColor = true;
            this.b_readJoe.Click += new System.EventHandler(this.b_readJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 292);
            this.Controls.Add(this.b_readJoe);
            this.Controls.Add(this.b_saveJoe);
            this.Controls.Add(this.b_bobToJoe);
            this.Controls.Add(this.b_joeToBob);
            this.Controls.Add(this.b_receiveFromBob);
            this.Controls.Add(this.l_bankCash);
            this.Controls.Add(this.l_bobCash);
            this.Controls.Add(this.b_giveToJoe);
            this.Controls.Add(this.l_joeCash);
            this.Name = "Form1";
            this.Text = "Zabawa z Bobem i Joem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_joeCash;
        private Button b_giveToJoe;
        private Label l_bobCash;
        private Label l_bankCash;
        private Button b_receiveFromBob;
        private Button b_bobToJoe;
        private Button b_joeToBob;
        private Button b_saveJoe;
        private Button b_readJoe;
    }
}