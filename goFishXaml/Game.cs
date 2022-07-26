using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace goFishXaml
{
    internal class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;

        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }

        public Game()
        {
            PlayerName = "Edek";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }

        public void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }

        public void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bartek", random, this));
            players.Add(new Player("Janek", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public void PlayOneRound(int selectedPlayerCard)
        {
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    AddProgress(players[i].Name + " ma nową grupę");
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                OnPropertyChanged("Books");
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    AddProgress("Na kupce nie ma żadnych kart. Gra skończona!");
                    AddProgress("Zwycięzcą jest... " + GetWinnerName());
                    ResetGame();
                    return;
                }
            }
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
        }

        public void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Hand.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            foreach (Player player in players)
                PullOutBooks(player);
        }


        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach (Values value in booksPulled)
                books.Add(value, player);
            if (player.CardCount == 0)
                return true;
            return false;
        }

        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach (Values value in books.Keys)
                whoHasWhichBooks += books[value].Name + " ma grupę "
                    + Card.Plural(value, 0) + Environment.NewLine;
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }
            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " i ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += ": " + mostBooks + " grupy";
            if (tie)
                return "Remis pomiędzy " + winnerList;
            else
                return winnerList;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " ma " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " kartę." + Environment.NewLine;
                else if (players[i].CardCount == 2 || players[i].CardCount == 3 || players[i].CardCount == 4)
                    description += " karty." + Environment.NewLine;
                else
                    description += " kart." + Environment.NewLine;
            }
            description += "Na kupce pozostało kart: " + stock.Count + Environment.NewLine;
            return description;
        }
    }
}