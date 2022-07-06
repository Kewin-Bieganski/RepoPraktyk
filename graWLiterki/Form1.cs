namespace graWLiterki
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void t_gameTimer_Tick(object sender, EventArgs e)
        {
            lB_letters.Items.Add((Keys)random.Next(65, 90));
            if(lB_letters.Items.Count > 7)
            {
                lB_letters.Items.Clear();
                lB_letters.Items.Add("Koniec gry");
                t_gameTimer.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(lB_letters.Items.Contains(e.KeyCode))
            {
                lB_letters.Items.Remove(e.KeyCode);
                lB_letters.Refresh();
                if(t_gameTimer.Interval > 400)
                {
                    t_gameTimer.Interval -= 10;
                }
                if(t_gameTimer.Interval > 250)
                {
                    t_gameTimer.Interval -= 7;
                }
                if(t_gameTimer.Interval > 100)
                {
                    t_gameTimer.Interval -= 2;
                }
                tSSB_difficultyLevel.Value = 800 - t_gameTimer.Interval;
                stats.Update(true);
            } else
            {
                stats.Update(false);
            }
            UpdateStatusStripStatusLabels();
        }

        private void UpdateStatusStripStatusLabels()
        {
            tSSL_correct.Text = "Prawid³owych: " + stats.correct;
            tSSL_missed.Text = "B³êdów: " + stats.missed;
            tSSL_total.Text = "Wszystkich: " + stats.total;
            tSSL_accuracy.Text = "Dok³adnoœæ: " + stats.accuracy + "%";
        }


        private void lB_letters_restart_Click(object sender, EventArgs e)
        {
            if (lB_letters.Items.Contains("Koniec gry"))
            {
                lB_letters.Items.Clear();
                stats = new Stats();
                UpdateStatusStripStatusLabels();
                tSSB_difficultyLevel.Value = 0;
                t_gameTimer.Interval = 800;
                t_gameTimer.Start();
            }
        }
    }
}