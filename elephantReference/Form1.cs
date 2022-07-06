namespace elephantReference
{
    public partial class Form1 : Form
    {
        Elephant[] elephants;
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();

            lloyd = new Elephant() { earSize = 33, name = "Lloyd" };
            lucinda = new Elephant() { earSize = 40, name = "Lucinda" };
            elephants = new Elephant[] { lloyd, lucinda, new Elephant(){earSize = 100, name = "Larry"} };
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
            //lloyd.TellMe("Czeœæ", lucinda);
            lucinda.SpeakTo(lloyd, "Witaj");
            lloyd.WhoAmI();
            //lloyd = lucinda;
            //lloyd.earSize = 4321;
            Elephant biggestEars = elephants[0];
            for (int i = 1; i < elephants.Length; i++)
            {
                if(elephants[i].earSize > biggestEars.earSize)
                {
                    biggestEars = elephants[i];
                }
            }
            MessageBox.Show($"Najwiêksze uszy ({biggestEars.earSize}) ma {biggestEars.name}");
        }
    }
}