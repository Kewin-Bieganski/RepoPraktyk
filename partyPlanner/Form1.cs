namespace partyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.CalculateCost(cB_healthyOption.Checked);
            l_cost.Text = cost.ToString("c");
        }


        private void nUD_numberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)nUD_numberOfPeople.Value, cB_fancyDecorations.Checked);
        }

        private void cB_fancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(cB_fancyDecorations.Checked);
            DisplayDinnerPartyCost();
        }

        private void cB_healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(cB_healthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}