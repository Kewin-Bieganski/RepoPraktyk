using System;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace goFishXaml
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

        private void b_start_Click(object sender, RoutedEventArgs e)
        {
            game.StartGame();
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
            if (lB_hand.SelectedIndex >= 0)
                game.PlayOneRound(lB_hand.SelectedIndex);
        }
    }
}
