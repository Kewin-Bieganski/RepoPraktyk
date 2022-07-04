using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SensownyProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void b_showInfo_Click(object sender, RoutedEventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            tB_myLabel.Text = $"nazwa to {name}\nx jest równe {x}\nd jest równe {d}";
        }

        private void b_ifElse_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                tB_myLabel.Text = "x jest równe 10";
            }
            else
            {
                tB_myLabel.Text = "x nie jest równe 10";
            }
        }

        private void b_nextCondition_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Kewin";
            if ((someValue == 3) && (name.Equals("Kewin")))
            {
                tB_myLabel.Text = $"someValue jest równe {someValue} i name jest równe {name}";
            }
            tB_myLabel.Text = "nadpisanie stringa";
        }

        private void b_loop_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            tB_myLabel.Text = $"Odpowiedź brzmi {count}";
/*
 // Ta zmienna będzie zawierała końcowy wynik.
 int result = 0;
            // Zadeklaruj zmienną x i ustaw jej wartość na 6 
            int x = 6;
            // Wykonuj te instrukcje, dopóki x jest większe od 3.
            while (x > 3)
            {
                result = result + x; // Dodaj x i przypisz wynik opreacji do result.
                x--; // Post-dekrementuj.
            }

            for (int i = 0; i < 3; i++)
            {
                // 1. Przypisz zmiennej i wartość 0.
                // 2. Sprawdź czy i < 3.
                // 3. Wykonaj kod.
                // 4. Iteruj.
                // 5. Powtarzaj 2-4.
            }

            // Przypisz polu elementu Text Block wartość ...
            tB_myLabel.Text = "Zmienna result jest równa " + result;
            */
            /*            string result = "";
                        int x = 3;

                        while(x > 0) {
                            if (x > 2)
                            {
                                result = result + "a";
                            }
                            result = result + "-";
                            x = x - 1;
                            if (x == 1)
                            {
                                result = result + "d";
                                x = x - 1;
                            }
                            if (x == 2)
                            {
                                result = result + "b c";
                            }
                        }
                        tB_myLabel.Text = result;*/
        }
    }
}
