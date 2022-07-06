namespace elephantReference
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();

            lloyd = new Elephant() { earSize = 33, name = "Lloyd" };
            lucinda = new Elephant() { earSize = 40, name = "Lucinda" };
        }

        private void b_lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void b_lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void l_swap_Click(object sender, EventArgs e)
        {
            object swap = lloyd;
            lloyd = lucinda;
            lucinda = (Elephant)swap;
            MessageBox.Show("Obiekty zamienione.");
        }

        private void l_extra_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.earSize = 4321;
            lloyd.WhoAmI();
        }
    }
}