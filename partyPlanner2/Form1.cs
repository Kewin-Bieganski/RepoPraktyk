namespace partyPlanner2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)nUD_numberOfPeople.Value, cB_healthyOption.Checked, cB_fancyDecorations.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)nUD_numberOfPeople2.Value, cB_fancyDecorations2.Checked, tB_cakeWriting2.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            l_cost.Text = dinnerParty.Cost.ToString("C");
        }


        private void nUD_numberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)nUD_numberOfPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void cB_fancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = cB_fancyDecorations.Checked;
            DisplayDinnerPartyCost();
        }

        private void cB_healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = cB_healthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            l_cakeWritingTooLong2.Visible = birthdayParty.CakeWritingTooLong;
            l_cost2.Text = birthdayParty.Cost.ToString("C");
        }


        private void nUD_numberOfPeople2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)nUD_numberOfPeople2.Value;
            DisplayBirthdayPartyCost();
        }

        private void cB_fancyDecorations2_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = cB_fancyDecorations2.Checked;
            DisplayBirthdayPartyCost();
        }

        private void tB_cakeWriting2_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = tB_cakeWriting2.Text;
            DisplayBirthdayPartyCost();
        }
    }
}