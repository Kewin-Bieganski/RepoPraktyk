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
using lumberjackDinner;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace lumberjackDinnerXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void b_addLumberjack_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tB_name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(tB_name.Text));
            tB_name.Text = "";
            RedrawList();
        }

        private void b_addFlapjacks_Click(object sender, RoutedEventArgs e)
        {
            Flapjack food;
            switch (lB_queue.SelectedIndex)
            {
                case 0:
                    food = Flapjack.Chrupkiego;
                    break;
                case 1:
                    food = Flapjack.Wilgotnego;
                    break;
                case 2:
                    food = Flapjack.Rumianego;
                    break;
                default:
                    food = Flapjack.Bananowego;
                    break;
            }
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, Convert.ToInt32(tB_count.Text));
            RedrawList();
        }

        private void b_nextLumberjack_Click(object sender, RoutedEventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            sV_status.Content = "";
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            lB_queue.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                lB_queue.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                sV_status.Content = "";
            }
            else
            {
                Lumberjack currentLumberjack = breakfastLine.Peek();
                sV_status.Content = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
            }
        }
    }
}
