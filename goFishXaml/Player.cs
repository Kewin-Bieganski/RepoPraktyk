using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace goFish
{
    internal class Player
    {
        private string name;
        private Random random;
        private Deck cards;
        private ScrollViewer textBoxOnForm;
        public string Name { get { return name; } }
        public int CardCount { get { return cards.Count; } }

        public Player(String name, Random random, ScrollViewer textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Content += name +
                         " przyłączył się do gry " + Environment.NewLine;
        }

        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Content += Name + " ma " + cardsIHave.Count + " "
                   + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }

        public void AskForACard(List<Player> players, int myIndex,
              Deck stock, Values value)
        {
            textBoxOnForm.Content += Name + " pyta, czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0 && stock.Count > 0)
            {
                textBoxOnForm.Content += Name +
                      " pobrał kartę z kupki." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }
        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }
        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }
        public void SortHand()
        {
            cards.SortByValue();
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
            }
            return books;
        }
    }
}
