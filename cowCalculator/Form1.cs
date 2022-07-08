using System.Diagnostics;

namespace cowCalculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            //farmer = new Farmer{ NumberOfCows = 15 };
            farmer = new Farmer(15, 30);
        }

        private void b_calculate_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Potrzebujê {farmer.BagsOfFeed} worków paszy do wykarmienia {farmer.NumberOfCows} krów");
        }

        private void nUD_numberOfCows_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)nUD_numberOfCows.Value;
        }

        private void b_error_Click(object sender, EventArgs e)
        {
            //farmer.BagsOfFeed = 5;
        }
    }
}