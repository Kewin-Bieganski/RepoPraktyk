using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        private async void WriteJoe_Click(object sender, RoutedEventArgs e)
        {
            await guyManager.WriteGuyAsync(guyManager.Joe);
        }

        private async void WriteBob_Click(object sender, RoutedEventArgs e)
        {
            await guyManager.WriteGuyAsync(guyManager.Bob);
        }

        private async void WriteEd_Click(object sender, RoutedEventArgs e)
        {
            await guyManager.WriteGuyAsync(guyManager.Ed);
        }

        private async void ReadNewGuy_Click(object sender, RoutedEventArgs e)
        {
            await guyManager.ReadGuyAsync();
        }
    }
}
