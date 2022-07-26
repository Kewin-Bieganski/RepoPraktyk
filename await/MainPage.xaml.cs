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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace await
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int i = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(50);
            dispatcherTimer.Start();
            CheckHappiness();
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            ticker.Text = "Chwila nr " + i++;
        }

        private async void CheckHappiness()
        {
            MessageDialog messageDialog = new MessageDialog("Czy jesteś szczęsliwy?");
            messageDialog.Commands.Add(new UICommand("Szczęsliwy i radosny!"));
            messageDialog.Commands.Add(new UICommand("Żałośnie smutny"));
            messageDialog.DefaultCommandIndex = 1;
            UICommand result = await messageDialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Szczęsliwy i radosny!")
                response.Text = "Użytkownik jest szczęśliwy.";
            else
                response.Text = "Użytkownik jest smutny.";
            dispatcherTimer.Stop();
        }
    }
}
