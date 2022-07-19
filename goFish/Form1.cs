namespace goFish
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            lB_hand.Items.Clear();
            foreach (var cardName in game.GetPlayerCardNames())
            {
                lB_hand.Items.Add(cardName);
            }
            tB_books.Text = game.DescribeBooks();
            tB_progress.Text += game.DescribePlayerHands();
            tB_progress.SelectionStart = tB_progress.Text.Length;
            tB_progress.ScrollToCaret();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tB_name.Text))
            {
                MessageBox.Show("Wpisz swoje imiê", "Nie mo¿na jeszcze rozpocz¹æ gry.");
                return;
            }
            game = new Game(tB_name.Text, new List<string> { "Janek", "Bartek"}, tB_progress);
            b_start.Enabled = false;
            tB_name.Enabled = false;
            b_ask.Enabled = true;
            UpdateForm();
        }

        private void b_ask_Click(object sender, EventArgs e)
        {
            tB_progress.Text = "";
            if(lB_hand.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz kartê.");
                return;
            }
            if (game.PlayOneRound(lB_hand.SelectedIndex))
            {
                tB_progress.Text += "Zwyciezc¹ jest... " + game.GetWinnerName();
                tB_books.Text = game.DescribeBooks();
                b_ask.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}