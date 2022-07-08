namespace partyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)nUD_numberOfPeople.Value, cB_healthyOption.Checked, cB_fancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            l_cost.Text = Cost.ToString("C");
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
    }
}