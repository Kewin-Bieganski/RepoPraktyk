namespace dialogs2
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
            this.oFD_open = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tB_io = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.b_save = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.sFD_save = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oFD_open
            // 
            this.oFD_open.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tB_io, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.23529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tB_io
            // 
            this.tB_io.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_io.Location = new System.Drawing.Point(0, 0);
            this.tB_io.Margin = new System.Windows.Forms.Padding(0);
            this.tB_io.Multiline = true;
            this.tB_io.Name = "tB_io";
            this.tB_io.Size = new System.Drawing.Size(891, 397);
            this.tB_io.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.b_save);
            this.flowLayoutPanel1.Controls.Add(this.b_open);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 397);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 53);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(787, 10);
            this.b_save.Margin = new System.Windows.Forms.Padding(10);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(94, 29);
            this.b_save.TabIndex = 0;
            this.b_save.Text = "Zapisz";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(673, 10);
            this.b_open.Margin = new System.Windows.Forms.Padding(10);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(94, 29);
            this.b_open.TabIndex = 1;
            this.b_open.Text = "Otwórz";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Prymitywny Notatnik";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog oFD_open;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tB_io;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button b_save;
        private Button b_open;
        private SaveFileDialog sFD_save;
    }
}