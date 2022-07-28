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

namespace serializeGuyXamlWithGui
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

        private void WriteJoe_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Joe);
        }

        private void WriteBob_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Bob);
        }

        private void WriteEd_Click(object sender, RoutedEventArgs e)
        {
            guyManager.WriteGuyAsync(guyManager.Ed);
        }

        private void ReadNewGuy_Click(object sender, RoutedEventArgs e)
        {
            guyManager.ReadGuyAsync();
        }
    }
}
