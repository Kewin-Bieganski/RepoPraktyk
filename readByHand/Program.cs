using System.Runtime.Serialization.Formatters.Binary;

namespace readByHand
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
                        Card trojkaTrefl = new Card(Suits.Clubs, Values.Three);
                        Card szostkaKier = new Card(Suits.Hearts, Values.Six);
                        using (Stream output1 = File.Create(path + @"\karta1.dat"))
                        using (Stream output2 = File.Create(path + @"\karta2.dat"))
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(output1, trojkaTrefl);
                            bf.Serialize(output2, szostkaKier);
                        }
                        break;
                    case ConsoleKey.D2:
                        byte[] firstFile = File.ReadAllBytes(path + @"\karta1.dat");
                        byte[] secondFile = File.ReadAllBytes(path + @"\karta2.dat");
                        for (int i = 0; i < firstFile.Length; i++)
                        {
                            if (firstFile[i] != secondFile[i])
                                Console.WriteLine("Bajt numer {0}: {1} i {2}", i, firstFile[i], secondFile[i]);
                        }
                        break;
                    case ConsoleKey.D3:
                        byte[] firstFileChanged = File.ReadAllBytes(path + @"\karta1.dat");
                        firstFileChanged[247] = (byte)Suits.Spades;
                        firstFileChanged[292] = (byte)Values.King;
                        File.WriteAllBytes(path + @"\karta3.dat", firstFileChanged);
                        break;
                    case ConsoleKey.D4:
                        Card changedCard;
                        using (Stream input = File.OpenRead(path + @"\karta3.dat"))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            changedCard = (Card)binaryFormatter.Deserialize(input);
                        }
                        DealCards(new Deck(new List<Card> { changedCard }), "Karta 3");
                        break;
                    case ConsoleKey.D5:
                        using (StreamReader reader = new StreamReader(path + @"\karta3.dat"))
                        using (StreamWriter writer = new StreamWriter(path + @"\karta3Out.dat"))
                        {
                            int position = 0;
                            while(!reader.EndOfStream)
                            {
                                char[] buffer = new char[16];
                                int charactersRead = reader.ReadBlock(buffer, 0, buffer.Length);
                                writer.Write("{0}: ", String.Format("{0:x4}", position));
                                position += charactersRead;
                                for (int i = 0; i < buffer.Length; i++)
                                {
                                    if(i < charactersRead)
                                    {
                                        string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                        writer.Write(hex + " ");
                                    } else
                                    {
                                        writer.Write("---");
                                    }
                                    if(i == 7) { writer.Write("-- "); }
                                    if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                                }
                                string bufferContents = new string(buffer);
                                writer.WriteLine("---" + bufferContents.Substring(0, charactersRead));
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