namespace excuses
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
            this.b_folder = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.b_randomExcuse = new System.Windows.Forms.Button();
            this.tB_excuse = new System.Windows.Forms.TextBox();
            this.tB_result = new System.Windows.Forms.TextBox();
            this.dTP_lastTimeUsed = new System.Windows.Forms.DateTimePicker();
            this.l_fileDate = new System.Windows.Forms.Label();
            this.oFD_open = new System.Windows.Forms.OpenFileDialog();
            this.sFD_save = new System.Windows.Forms.SaveFileDialog();
            this.fBD_browse = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wymówka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wyniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data pliku";
            // 
            // b_folder
            // 
            this.b_folder.Location = new System.Drawing.Point(19, 179);
            this.b_folder.Margin = new System.Windows.Forms.Padding(10);
            this.b_folder.Name = "b_folder";
            this.b_folder.Size = new System.Drawing.Size(94, 29);
            this.b_folder.TabIndex = 4;
            this.b_folder.Text = "Folder";
            this.b_folder.UseVisualStyleBackColor = true;
            this.b_folder.Click += new System.EventHandler(this.b_folder_Click);
            // 
            // b_save
            // 
            this.b_save.Enabled = false;
            this.b_save.Location = new System.Drawing.Point(133, 179);
            this.b_save.Margin = new System.Windows.Forms.Padding(10);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(94, 29);
            this.b_save.TabIndex = 5;
            this.b_save.Text = "Zapisz";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_open
            // 
            this.b_open.Enabled = false;
            this.b_open.Location = new System.Drawing.Point(247, 179);
            this.b_open.Margin = new System.Windows.Forms.Padding(10);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(94, 29);
            this.b_open.TabIndex = 6;
            this.b_open.Text = "Otwórz";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // b_randomExcuse
            // 
            this.b_randomExcuse.Enabled = false;
            this.b_randomExcuse.Location = new System.Drawing.Point(361, 179);
            this.b_randomExcuse.Margin = new System.Windows.Forms.Padding(10);
            this.b_randomExcuse.Name = "b_randomExcuse";
            this.b_randomExcuse.Size = new System.Drawing.Size(234, 27);
            this.b_randomExcuse.TabIndex = 7;
            this.b_randomExcuse.Text = "Losowa wymówka";
            this.b_randomExcuse.UseVisualStyleBackColor = true;
            this.b_randomExcuse.Click += new System.EventHandler(this.b_randomExcuse_Click);
            // 
            // tB_excuse
            // 
            this.tB_excuse.Location = new System.Drawing.Point(143, 16);
            this.tB_excuse.Margin = new System.Windows.Forms.Padding(10);
            this.tB_excuse.Name = "tB_excuse";
            this.tB_excuse.Size = new System.Drawing.Size(452, 27);
            this.tB_excuse.TabIndex = 8;
            this.tB_excuse.TextChanged += new System.EventHandler(this.tB_excuse_TextChanged);
            // 
            // tB_result
            // 
            this.tB_result.Location = new System.Drawing.Point(143, 56);
            this.tB_result.Margin = new System.Windows.Forms.Padding(10);
            this.tB_result.Name = "tB_result";
            this.tB_result.Size = new System.Drawing.Size(452, 27);
            this.tB_result.TabIndex = 9;
            this.tB_result.TextChanged += new System.EventHandler(this.tB_result_TextChanged);
            // 
            // dTP_lastTimeUsed
            // 
            this.dTP_lastTimeUsed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_lastTimeUsed.Location = new System.Drawing.Point(143, 94);
            this.dTP_lastTimeUsed.Margin = new System.Windows.Forms.Padding(10);
            this.dTP_lastTimeUsed.Name = "dTP_lastTimeUsed";
            this.dTP_lastTimeUsed.Size = new System.Drawing.Size(452, 27);
            this.dTP_lastTimeUsed.TabIndex = 10;
            this.dTP_lastTimeUsed.ValueChanged += new System.EventHandler(this.dTP_lastTimeUsed_ValueChanged);
            // 
            // l_fileDate
            // 
            this.l_fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_fileDate.Location = new System.Drawing.Point(143, 138);
            this.l_fileDate.Margin = new System.Windows.Forms.Padding(10);
            this.l_fileDate.Name = "l_fileDate";
            this.l_fileDate.Size = new System.Drawing.Size(452, 25);
            this.l_fileDate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_fileDate);
            this.Controls.Add(this.dTP_lastTimeUsed);
            this.Controls.Add(this.tB_result);
            this.Controls.Add(this.tB_excuse);
            this.Controls.Add(this.b_randomExcuse);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_folder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program do zarządzania wymówkami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button b_folder;
        private Button b_save;
        private Button b_open;
        private Button b_randomExcuse;
        private TextBox tB_excuse;
        private TextBox tB_result;
        private DateTimePicker dTP_lastTimeUsed;
        private Label l_fileDate;
        private OpenFileDialog oFD_open;
        private SaveFileDialog sFD_save;
        private FolderBrowserDialog fBD_browse;
    }
}