using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grayhoundRaceSimulator
{
    internal class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public static Label nameLabel;
        public TextBox myTextBox;

        public void UpdateRadio()
        {
            if (myRadioButton != null)
            {
                myRadioButton.Text = $"{name} ma {cash} zł";
            }
        }

        public void UpdateNameLabel()
        {
            nameLabel.Text = name;
        }

        public void UpdateBetTextBox()
        {
            myTextBox.Text = (myBet == null ? $"{name} nie zawarł zakładu." : $"{name} stawia {myBet.amount} na charta numer {myBet.chosenGrayhound.id}");
        }

        public void ClearBet()
        {
            if(myBet != null)
            {
                myBet = null;
                UpdateBetTextBox();
            }
            
        }

        public void PlaceBet(Grayhound chosenGrayhound, int amount)
        {
            if(cash - amount > 0)
            {
                myBet = new Bet()
                {
                    amount = amount,
                    chosenGrayhound = chosenGrayhound,
                    bettor = this,
                };
                myRadioButton.BackColor = Color.Transparent;
            } else
            {
                MessageBox.Show($"Nie masz już pieniędzy, {name}!","Rozbuj w biały dzień!");
            }
        }

        public void Collect()
        {
            if (myBet != null)
            {
                myBet.PayOut();
            }
        }
    }
}
