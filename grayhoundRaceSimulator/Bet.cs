using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grayhoundRaceSimulator
{
    internal class Bet
    {
        public static Grayhound winningGrayhound;
        public Grayhound chosenGrayhound;
        public int amount;
        public Guy bettor;

        public static void GameOver()
        {
            MessageBox.Show($"Chart numer {winningGrayhound.id} wygrał wyścig! ", "Mamy zwycięzce");
        }

        public void PayOut()
        {
            string results = "";
            if (chosenGrayhound.Equals(winningGrayhound))
            {
                bettor.cash += amount * 2;
                bettor.myRadioButton.BackColor = Color.Lime;
            } else
            {
                bettor.cash -= amount;
                bettor.myRadioButton.BackColor = Color.Red;
            }
        }
    }
}
