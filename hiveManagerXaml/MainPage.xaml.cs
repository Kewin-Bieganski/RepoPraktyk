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
using hiveManager;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace hiveManagerXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Queen queen;
        private readonly string[] jobs =
        {
            "Nauczanie pszczółek",
            "Pielęgnacja jaj",
            "Utrzymanie ula",
            "Wytwarzanie miodu",
            "Zbieranie nektaru",
            "Patrol z żądłami"
        };

        public MainPage()
        {
            this.InitializeComponent();
            cBox_workerJob.SelectedIndex = 0;
            cBox_workerJob.Items.Add(jobs);
            cBox_workerJob.Items.RemoveAt(cBox_workerJob.Items.Count - 1);
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { jobs[4], jobs[3] }, 175D);
            workers[1] = new Worker(new string[] { jobs[1], jobs[0] }, 114D);
            workers[2] = new Worker(new string[] { jobs[2], jobs[3] }, 149D);
            workers[3] = new Worker(jobs, 155D);
            queen = new Queen(workers, 275D);
        }

        private void b_assignWork_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (queen.AssingWork(((ComboBoxItem)cBox_workerJob.SelectedItem).Content.ToString(), Convert.ToInt32(tB_shiftCount.Text)) == false)
                    new MessageDialog($"Nie ma dostępnych robotnic do wykonania zadania '{((ComboBoxItem)cBox_workerJob.SelectedItem).Content}'", "Królowa pszczół mówi...").ShowAsync();
                else
                    new MessageDialog($"Zadanie '{((ComboBoxItem)cBox_workerJob.SelectedItem).Content}' będzie ukończone za {tB_shiftCount.Text} zmiany", "Królowa pszczół mówi...").ShowAsync();
            } catch
            {
                new MessageDialog($"Nieoczekiwany błąd", "Error");
            }
        }

        private void b_nextShift_Click(object sender, RoutedEventArgs e)
        {
            sV_output.Content = queen.WorkTheNextShift();
        }
    }
}
