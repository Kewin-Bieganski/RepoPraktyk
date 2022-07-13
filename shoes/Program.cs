namespace shoes
{
    public class Program
    {
        public static void Main()
        {
            List<Shoe> shoeCloset = new List<Shoe>()
            {
                new Shoe()
                {
                    Style = Style.Sneakers,
                    Color = "Czarny",
                },
                new Shoe()
                {
                    Style = Style.Clogs,
                    Color = "Brązowy",
                },
                new Shoe()
                {
                    Style = Style.Wingtips,
                    Color = "Czarny",
                },
                new Shoe()
                {
                    Style = Style.Loafers,
                    Color = "Biały",
                },
                new Shoe()
                {
                    Style = Style.Loafers,
                    Color = "Czerwony",
                },
                new Shoe()
                {
                    Style = Style.Sneakers,
                    Color = "Zielony",
                },
            };

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Pomarańczowy";
            }

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();
            
            shoeCloset.Add(thirdShoe);
            shoeCloset.Add(secondShoe);
            if(shoeCloset.Contains(secondShoe))
            {
                Console.WriteLine("A to ci niespodzianka");
            }
        }
    }

    public class Shoe
    {
        public Style Style;
        public string Color;
    }

    public enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs,
    }
}