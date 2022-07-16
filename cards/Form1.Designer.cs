namespace cards
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
            this.p_board = new System.Windows.Forms.Panel();
            this.b_deckToDeck2 = new System.Windows.Forms.Button();
            this.b_deck2ToDeck = new System.Windows.Forms.Button();
            this.b_restoreDeck = new System.Windows.Forms.Button();
            this.b_reshuffleDeck = new System.Windows.Forms.Button();
            this.b_restoreDeck2 = new System.Windows.Forms.Button();
            this.b_reshuffleDeck2 = new System.Windows.Forms.Button();
            this.l_deckHeader2 = new System.Windows.Forms.Label();
            this.l_deckHeader = new System.Windows.Forms.Label();
            this.lB_deck2 = new System.Windows.Forms.ListBox();
            this.lB_deck = new System.Windows.Forms.ListBox();
            this.p_board.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_board
            // 
            this.p_board.Controls.Add(this.b_deckToDeck2);
            this.p_board.Controls.Add(this.b_deck2ToDeck);
            this.p_board.Controls.Add(this.b_restoreDeck);
            this.p_board.Controls.Add(this.b_reshuffleDeck);
            this.p_board.Controls.Add(this.b_restoreDeck2);
            this.p_board.Controls.Add(this.b_reshuffleDeck2);
            this.p_board.Controls.Add(this.l_deckHeader2);
            this.p_board.Controls.Add(this.l_deckHeader);
            this.p_board.Controls.Add(this.lB_deck2);
            this.p_board.Controls.Add(this.lB_deck);
            this.p_board.Location = new System.Drawing.Point(0, 0);
            this.p_board.Margin = new System.Windows.Forms.Padding(0);
            this.p_board.Name = "p_board";
            this.p_board.Size = new System.Drawing.Size(524, 402);
            this.p_board.TabIndex = 12;
            // 
            // b_deckToDeck2
            // 
            this.b_deckToDeck2.Location = new System.Drawing.Point(232, 105);
            this.b_deckToDeck2.Margin = new System.Windows.Forms.Padding(10);
            this.b_deckToDeck2.Name = "b_deckToDeck2";
            this.b_deckToDeck2.Size = new System.Drawing.Size(57, 29);
            this.b_deckToDeck2.TabIndex = 21;
            this.b_deckToDeck2.Text = ">>";
            this.b_deckToDeck2.UseVisualStyleBackColor = true;
            this.b_deckToDeck2.Click += new System.EventHandler(this.b_deckToDeck2_Click);
            // 
            // b_deck2ToDeck
            // 
            this.b_deck2ToDeck.Location = new System.Drawing.Point(232, 191);
            this.b_deck2ToDeck.Margin = new System.Windows.Forms.Padding(10);
            this.b_deck2ToDeck.Name = "b_deck2ToDeck";
            this.b_deck2ToDeck.Size = new System.Drawing.Size(57, 29);
            this.b_deck2ToDeck.TabIndex = 20;
            this.b_deck2ToDeck.Text = "<<";
            this.b_deck2ToDeck.UseVisualStyleBackColor = true;
            this.b_deck2ToDeck.Click += new System.EventHandler(this.b_deck2ToDeck_Click);
            // 
            // b_restoreDeck
            // 
            this.b_restoreDeck.Location = new System.Drawing.Point(19, 303);
            this.b_restoreDeck.Margin = new System.Windows.Forms.Padding(10);
            this.b_restoreDeck.Name = "b_restoreDeck";
            this.b_restoreDeck.Size = new System.Drawing.Size(193, 29);
            this.b_restoreDeck.TabIndex = 19;
            this.b_restoreDeck.Text = "Przywróć zestaw 1.";
            this.b_restoreDeck.UseVisualStyleBackColor = true;
            this.b_restoreDeck.Click += new System.EventHandler(this.b_restoreDeck_Click);
            // 
            // b_reshuffleDeck
            // 
            this.b_reshuffleDeck.Location = new System.Drawing.Point(19, 352);
            this.b_reshuffleDeck.Margin = new System.Windows.Forms.Padding(10);
            this.b_reshuffleDeck.Name = "b_reshuffleDeck";
            this.b_reshuffleDeck.Size = new System.Drawing.Size(193, 29);
            this.b_reshuffleDeck.TabIndex = 18;
            this.b_reshuffleDeck.Text = "Wymieszaj zestaw 1.";
            this.b_reshuffleDeck.UseVisualStyleBackColor = true;
            this.b_reshuffleDeck.Click += new System.EventHandler(this.b_reshuffleDeck_Click);
            // 
            // b_restoreDeck2
            // 
            this.b_restoreDeck2.Location = new System.Drawing.Point(309, 303);
            this.b_restoreDeck2.Margin = new System.Windows.Forms.Padding(10);
            this.b_restoreDeck2.Name = "b_restoreDeck2";
            this.b_restoreDeck2.Size = new System.Drawing.Size(193, 29);
            this.b_restoreDeck2.TabIndex = 17;
            this.b_restoreDeck2.Text = "Przywróć zestaw 2.";
            this.b_restoreDeck2.UseVisualStyleBackColor = true;
            this.b_restoreDeck2.Click += new System.EventHandler(this.b_restoreDeck2_Click);
            // 
            // b_reshuffleDeck2
            // 
            this.b_reshuffleDeck2.Location = new System.Drawing.Point(309, 352);
            this.b_reshuffleDeck2.Margin = new System.Windows.Forms.Padding(10);
            this.b_reshuffleDeck2.Name = "b_reshuffleDeck2";
            this.b_reshuffleDeck2.Size = new System.Drawing.Size(193, 29);
            this.b_reshuffleDeck2.TabIndex = 16;
            this.b_reshuffleDeck2.Text = "Wymieszaj zestaw 2.";
            this.b_reshuffleDeck2.UseVisualStyleBackColor = true;
            this.b_reshuffleDeck2.Click += new System.EventHandler(this.b_reshuffleDeck2_Click);
            // 
            // l_deckHeader2
            // 
            this.l_deckHeader2.AutoSize = true;
            this.l_deckHeader2.Location = new System.Drawing.Point(309, 19);
            this.l_deckHeader2.Margin = new System.Windows.Forms.Padding(10);
            this.l_deckHeader2.Name = "l_deckHeader2";
            this.l_deckHeader2.Size = new System.Drawing.Size(135, 20);
            this.l_deckHeader2.TabIndex = 15;
            this.l_deckHeader2.Text = "Zestaw 2. (??? kart)";
            // 
            // l_deckHeader
            // 
            this.l_deckHeader.AutoSize = true;
            this.l_deckHeader.Location = new System.Drawing.Point(19, 19);
            this.l_deckHeader.Margin = new System.Windows.Forms.Padding(10);
            this.l_deckHeader.Name = "l_deckHeader";
            this.l_deckHeader.Size = new System.Drawing.Size(135, 20);
            this.l_deckHeader.TabIndex = 14;
            this.l_deckHeader.Text = "Zestaw 1. (??? kart)";
            // 
            // lB_deck2
            // 
            this.lB_deck2.FormattingEnabled = true;
            this.lB_deck2.ItemHeight = 20;
            this.lB_deck2.Location = new System.Drawing.Point(309, 59);
            this.lB_deck2.Margin = new System.Windows.Forms.Padding(10);
            this.lB_deck2.Name = "lB_deck2";
            this.lB_deck2.Size = new System.Drawing.Size(193, 224);
            this.lB_deck2.TabIndex = 13;
            // 
            // lB_deck
            // 
            this.lB_deck.FormattingEnabled = true;
            this.lB_deck.ItemHeight = 20;
            this.lB_deck.Location = new System.Drawing.Point(19, 59);
            this.lB_deck.Margin = new System.Windows.Forms.Padding(10);
            this.lB_deck.Name = "lB_deck";
            this.lB_deck.Size = new System.Drawing.Size(193, 224);
            this.lB_deck.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(698, 542);
            this.Controls.Add(this.p_board);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.p_board.ResumeLayout(false);
            this.p_board.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel p_board;
        private Button b_deckToDeck2;
        private Button b_deck2ToDeck;
        private Button b_restoreDeck;
        private Button b_reshuffleDeck;
        private Button b_restoreDeck2;
        private Button b_reshuffleDeck2;
        private Label l_deckHeader2;
        private Label l_deckHeader;
        private ListBox lB_deck2;
        private ListBox lB_deck;
    }
}