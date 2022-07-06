using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elephantReference
{
    internal class Elephant
    {
        public int earSize;
        public string name;

        public void WhoAmI()
        {
            MessageBox.Show($"Moje uszy mają {earSize} centymetrów szerokości.", $"{name} mówi...");
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show($"{whoSaidIt.name} mówi: {message}");
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
        }
    }
}
