using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using goFish;
using Windows.UI;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace goFishXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Game game;

        public MainPage()
        {
            this.InitializeComponent();
            lB_hand.Resources["SystemControlHighlightListAccentLowBrush"] = new SolidColorBrush(Colors.Green);
            lB_hand.Resources["SystemControlHighlightListAccentMediumBrush"] = new SolidColorBrush(Colors.Red);
        }

        private void UpdateForm()
        {
            lB_hand.Items.Clear();
            foreach (var cardName in game.GetPlayerCardNames())
            {
                lB_hand.Items.Add(cardName);
            }
            sV_books.Content = game.DescribeBooks();
            sV_progress.Content += game.DescribePlayerHands();
//            tB_progress.SelectionStart = sV_progress.Text.Length;
//            tB_progress.ScrollToCaret();
        }

        private void b_start_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tB_name.Text))
            {
                new MessageDialog("Wpisz swoje imię", "Nie można jeszcze rozpocząć gry.").ShowAsync();
                return;
            }
            game = new Game(tB_name.Text, new List<string> { "Janek", "Bartek" }, sV_progress);
            b_start.IsEnabled = false;
            tB_name.IsEnabled = false;
            b_ask.IsEnabled = true;
            UpdateForm();
        }

        private void b_ask_Click(object sender, RoutedEventArgs e)
        {
            ask_Click();
        }

        private void b_ask_Click(object sender, DoubleTappedRoutedEventArgs e)
        {
            ask_Click();
        }

        private void ask_Click()
        {
            sV_progress.Content = "";
            if (lB_hand.SelectedIndex < 0)
            {
                new MessageDialog("Wybierz kartę.").ShowAsync();
                return;
            }
            if (game.PlayOneRound(lB_hand.SelectedIndex))
            {
                sV_progress.Content += "Zwyciezcą jest... " + game.GetWinnerName();
                sV_books.Content = game.DescribeBooks();
                b_ask.IsEnabled = false;
            }
            else
                UpdateForm();
        }
    }
}
