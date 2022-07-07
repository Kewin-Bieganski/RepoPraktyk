namespace grayhoundRaceSimulator
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Grayhound[] grayhounds = new Grayhound[4];
        byte currentGuyRadioSelected = 0;

        public Form1()
        {
            InitializeComponent();

            l_minimumBet.Text = $"Minimalny zak³ad: {nUD_amount.Value} z³";
            Guy.nameLabel = l_name;

            guys[0] = new Guy()
            {
                name = "Janek",
                cash = 50,
                myRadioButton = rB_guy1,
                myTextBox = tB_guy1,
            };
            guys[1] = new Guy()
            {
                name = "Bartek",
                cash = 75,
                myRadioButton = rB_guy2,
                myTextBox = tB_guy2,
            };
            guys[2] = new Guy()
            {
                name = "Arek",
                cash = 45,
                myRadioButton = rB_guy3,
                myTextBox = tB_guy3,
            };

            int racetrackLength = p_racetrack.Width;

            grayhounds[0] = new Grayhound()
            {
                myPictureBox = pB_grayhound1,
                id = 1,
            };
            grayhounds[1] = new Grayhound()
            {
                myPictureBox = pB_grayhound2,
                id = 2,
            };
            grayhounds[2] = new Grayhound()
            {
                myPictureBox = pB_grayhound3,
                id = 3,
            };
            grayhounds[3] = new Grayhound()
            {
                myPictureBox = pB_grayhound4,
                id = 4,
            };

            foreach (var guy in guys)
            {
                guy.UpdateRadio();
                guy.UpdateBetTextBox();
            }
            l_name.Text = guys[0].name;
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            gB_betOptions.Enabled = false;
            foreach (var grayhound in grayhounds)
            {
                grayhound.TakeStartingPosition();
            }
            t_grayhoundRace.Start();
        }

        private void t_grayhoundRace_Tick(object sender, EventArgs e)
        {
            if(Bet.winningGrayhound != null)
            {
                t_grayhoundRace.Stop();
                foreach (var guy in guys)
                {
                    guy.Collect();
                    guy.UpdateRadio();
                    guy.ClearBet();
                    gB_betOptions.Enabled = true;
                }
            }
            foreach (var grayhound in grayhounds)
            {
                grayhound.Run();
            }
        }

        private void rB_guy1_CheckedChanged(object sender, EventArgs e)
        {
            currentGuyRadioSelected = 0;
            guys[currentGuyRadioSelected].UpdateNameLabel();
            guys[currentGuyRadioSelected].UpdateBetTextBox();
        }

        private void rB_guy2_CheckedChanged(object sender, EventArgs e)
        {
            currentGuyRadioSelected = 1;
            guys[currentGuyRadioSelected].UpdateNameLabel();
            guys[currentGuyRadioSelected].UpdateBetTextBox();
        }

        private void rB_guy3_CheckedChanged(object sender, EventArgs e)
        {
            currentGuyRadioSelected = 2;
            guys[currentGuyRadioSelected].UpdateNameLabel();
            guys[currentGuyRadioSelected].UpdateBetTextBox();
        }

        private void b_bet_Click(object sender, EventArgs e)
        {
            if (guys[currentGuyRadioSelected].myBet == null)
            {
                guys[currentGuyRadioSelected].PlaceBet(grayhounds[(int)nUD_grayhoundNumber.Value-1], (int)nUD_amount.Value);
                guys[currentGuyRadioSelected].UpdateRadio();
                guys[currentGuyRadioSelected].UpdateBetTextBox();
            }
            else
            {
                guys[currentGuyRadioSelected].ClearBet();
                guys[currentGuyRadioSelected].UpdateRadio();
                guys[currentGuyRadioSelected].UpdateBetTextBox();
            }
        }
    }
}
