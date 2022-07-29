using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace excuseManagerXaml
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

        private void b_setToCurrentTime_Click(object sender, RoutedEventArgs e)
        {
            excuseManager.SetToCurrentTime();
        }

        private void b_newExcuse_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void b_folder_Click(object sender, RoutedEventArgs e)
        {
            bool folderChosen = await excuseManager.ChooseNewFolderAsync();
            if(folderChosen)
            {
                b_save.IsEnabled = true;
                b_randomExcuse.IsEnabled = true;
            }
        }

        private void b_randomExcuse_Click(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenRandomExcuseAsync();
        }

        private void b_open_Click(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenExcuseAsync();
        }

        private void b_save_Click(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsync();
        }

        private void b_saveAs_Click(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsAsync();
        }
    }
}
