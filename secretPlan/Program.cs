using System.IO;

namespace secretPlan
{
    internal class Program
    {
        public static void Main()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //@"c:\tajny_plan.txt"
            StreamWriter streamWriter = new StreamWriter(folder + @"\tajny_plan.txt");
            streamWriter.WriteLine("W jaki sposób pokonać Kapitana Wspaniałego?");
            streamWriter.WriteLine("Kolejny genialny, tajny plan Kanciarza.");
            streamWriter.Write("Stworzę armię klonów, ");
            streamWriter.WriteLine("uwolnię je i wystawię przeciwko mieszkańcom Obiektowa.");
            string location = "centrum handlowe.";
            for (int number = 0; number <= 6; number++)
            {
                streamWriter.WriteLine("Klon numer {0} atakuje {1}", number, location);
                if (location == "centrum handlowe.")
                    location = "centrum miasta.";
                else
                    location = "centrum handlowe.";
            }
            streamWriter.Close();
            StreamReader reader = new StreamReader(folder + @"\tajny_plan.txt");
            StreamWriter writer = new StreamWriter(folder + @"\e-maildoKapitanaWspaniałego.txt");
            writer.WriteLine("To: KapitanWspanialy@obiektowo.net");
            writer.WriteLine("From: Komisarz@obiektowo.net");
            writer.WriteLine("Subject: Czy możesz ocalić świat... po raz kolejeny?");
            writer.Write(Environment.NewLine);
            writer.WriteLine("Odkryliśmy plan Kanciarza:");
            while(!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("Plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Czy możesz nam pomóc?");
            writer.Close();
            reader.Close();
        }
    }
}