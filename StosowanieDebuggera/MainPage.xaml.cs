using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StosowanieDebuggera
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

        /** Znane z Javy, polecam.
         * 
         */

        /* Komentarz wielo-wierszowy.
         * 
         */

        /// Jeszcze inny typ komentarza, do dokumentacji.

        // Komentarzy nigdy dość.

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15; // Tutaj umieszczono breakpoint.
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;

            string result = "witam";
            result += " ponownie " + result;
            output.Text = result;
            result = "wartością jest: " + count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;

            string message = "";

            for (int i = 0; i < 1; i++)
            {
                message += "for";
            }

            while (false)
            {
                message += "while";
            }

            if (yesNo)
            {
                message += "yesNo";
            }
            else if (result == "")
            {
                message += "result";
            }
            else
            {
                message += "else";
            }
        }
    }
}
