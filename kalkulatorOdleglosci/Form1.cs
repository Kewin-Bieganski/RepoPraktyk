namespace kalkulatorOdleglosci
{
    public partial class Form1 : Form
    {
        private int startingMileage;
        private int endingMileage;
        private double milesTraveled;
        private double reimburseRate = .39;
        private double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void b_calc_Click(object sender, EventArgs e)
        {
            startingMileage = (int)nUD_startingMileage.Value;
            endingMileage = (int)nUD_endingMileage.Value;
            if(startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                l_output.Text = amountOwed.ToString("C");
            } else
            {
                MessageBox.Show("Pocz¹tkowy stan licznika musi byæ mniejszy ni¿ koñcowy", "Nie mogê obliczyæ odleg³oœci");
            }
        }

        private void b_distance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " kilometrów", "Przebyta odleg³oœæ");
        }
    }
}