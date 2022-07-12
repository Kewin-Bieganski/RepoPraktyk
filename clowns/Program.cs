namespace clowns
{
    public class Program
    {
        public static void Main()
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }
    }

    public class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave { get { return "Buty."; } }

        public void Honk()
        {
            Console.WriteLine("Honk.");
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"Nazywam się {Name} i mam {Height} centymetrów wzrostu.");
        }
    }

    public class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        
        public string FunnyThingIHave
        {
            get { return $"Cześć dzieciaki! Mam {funnyThingIHave}"; }
        }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }

    public class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return $"Mam {numberOfScaryThings} pająków"; }
        }
     
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam cię!");
        }
    }

    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}