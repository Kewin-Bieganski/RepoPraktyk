namespace zlodziejKlejnotow
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}