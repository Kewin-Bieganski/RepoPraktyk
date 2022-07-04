using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ifelseFun
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool leftRight = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void b_changeText_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(cB_enableCheckbox.IsChecked))
            {
                tB_labelToChange.HorizontalAlignment = (leftRight ? HorizontalAlignment.Left : HorizontalAlignment.Right);
                tB_labelToChange.Text = (leftRight ? "Lewo" : "Prawo");
                leftRight = !leftRight;
            }
            else
            {
                tB_labelToChange.Text = "Możliwość zmiany tekstu, wyłączona.";
                tB_labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
