namespace cards
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Deck deck;
        Deck deck2;

        List<Card> cards = new List<Card>();
        CardComparer_byValue cardComparer_ByValue = new CardComparer_byValue();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        /*        private void b_random_Click(object sender, EventArgs e)
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
        */
        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deck.Sort();
            } else
            {
                deck2 = new Deck();
            }
        }
        public void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                lB_deck.Items.Clear();
                foreach (string cardName in deck.GetCardNames())
                    lB_deck.Items.Add(cardName);
                l_deckHeader.Text = $"Zestaw 1. ({deck.Count} kart)";
            }
            else
            {
                lB_deck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    lB_deck2.Items.Add(cardName);
                l_deckHeader2.Text = $"Zestaw 2. ({deck2.Count} kart)";
            }
        }

        private void b_deckToDeck2_Click(object sender, EventArgs e)
        {
            if (lB_deck2.SelectedIndex >= 0)
                if (deck2.Count > 0)
                {
                    deck.Add(deck2.Deal(lB_deck2.SelectedIndex));
                }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void b_deck2ToDeck_Click(object sender, EventArgs e)
        {
            if (lB_deck.SelectedIndex >= 0)
                if (deck.Count > 0)
                {
                    deck2.Add(deck.Deal(lB_deck.SelectedIndex));
                }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void b_restoreDeck_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void b_restoreDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void b_reshuffleDeck_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            RedrawDeck(1);
        }

        private void b_reshuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}