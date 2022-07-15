namespace cards
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Card> cards = new List<Card>();
        CardComparer_byValue cardComparer_ByValue = new CardComparer_byValue();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_random_Click(object sender, EventArgs e)
        {
            ClearOutput();
            cards.Clear();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            PrintCards(cards);
            cards.Sort(cardComparer_ByValue);
            l_output.Text += "\n> SORTOWANIE <";
            PrintCards(cards);
        }

        private void ClearOutput()
        {
            l_output.Text = "";
        }

        private void PrintCards(List<Card> cards)
        {
            l_output.Text += "\n\tLista kart:";
            foreach (Card card in cards)
            {
                l_output.Text += "\n* " + card.Name;
            }
            l_output.Text += "\n\t*\t*\t*";
        }
    }
}