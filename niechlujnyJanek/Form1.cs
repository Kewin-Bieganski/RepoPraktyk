namespace niechlujnyJanek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuMaker menuMaker = new MenuMaker() { randomizer = new Random()};
            l_1.Text = menuMaker.GetMenuItem();
            l_2.Text = menuMaker.GetMenuItem();
            l_3.Text = menuMaker.GetMenuItem();
            l_4.Text = menuMaker.GetMenuItem();
            l_5.Text = menuMaker.GetMenuItem();
            l_6.Text = menuMaker.GetMenuItem();
        }
    }
}