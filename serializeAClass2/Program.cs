using cards;
using System.Runtime.Serialization.Formatters.Binary;

namespace serializeAClass2
{
    internal class Program
    {
        Random random = new Random();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void Main()
        {
            new Program();
        }
        public Program()
        {
            Console.WriteLine(path);
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        {
                            Deck deckToWrite = RandomDeck(5);
                            using (Stream output = File.Create(path + @"\Zestaw1.dat"))
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                formatter.Serialize(output, deckToWrite);
                            }
                            DealCards(deckToWrite, "To, co zapisałem do pliku");
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        {
                            Deck deckFromFile;
                            using (Stream input = File.OpenRead(path + @"\Zestaw1.dat"))
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                deckFromFile = (Deck)formatter.Deserialize(input);
                            }
                            DealCards(deckFromFile, "To, co z pliku odczytałem");
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        using (Stream output = File.Create(path + @"\Zestaw2.dat"))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            for (int i = 1; i <= 5; i++)
                            {
                                Deck deckToWrite = RandomDeck(random.Next(1, 10));
                                formatter.Serialize(output, deckToWrite);
                                DealCards(deckToWrite, "To, co zapisałem do pliku");
                            }
                        }
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        using (Stream input = File.OpenRead(path + @"\Zestaw2.dat"))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            for (int i = 1; i <= 5; i++)
                            {
                                Deck deckToRead = (Deck)binaryFormatter.Deserialize(input);
                                DealCards(deckToRead, "To, co z pliku odczytałem");
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private Deck RandomDeck(int Number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < Number; i++)
            {
                myDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string Title)
        {
            Console.WriteLine(Title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("*\t*\t*");
        }
    }
}