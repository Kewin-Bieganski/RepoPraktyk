using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace textEditorXaml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool textChanged = false;
        bool loading = false;
        IStorageFile saveFile = null;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void b_open_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                MessageDialog overwriteDialog = new MessageDialog($"Plik został zmieniony. Na pewno chcesz wczytać nowy plik?");
                overwriteDialog.Commands.Add(new UICommand("Tak"));
                overwriteDialog.Commands.Add(new UICommand("Nie"));
                overwriteDialog.DefaultCommandIndex = 1;
                UICommand result = await overwriteDialog.ShowAsync() as UICommand;
                if (result != null && result.Label.Equals("Nie")) return;
            }
            OpenFile();
        }

        private void b_save_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void b_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (loading)
            {
                loading = false;
                return;
            }
            if (!textChanged)
            {
                tB_filename.Text += "*";
                b_save.IsEnabled = true;
                textChanged = true;
            }
        }

        private async void OpenFile()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.List,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            picker.FileTypeFilter.Add(".txt");
            picker.FileTypeFilter.Add(".xml");
            picker.FileTypeFilter.Add(".xaml");
            IStorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                string fileContents = await FileIO.ReadTextAsync(file);
                loading = true;
                tBox_text.Text = fileContents;
                textChanged = false;
                tB_filename.Text = file.Name;
                saveFile = file;
            }
        }

        private async void SaveFile()
        {
            if (saveFile != null)
            {
                FileSavePicker picker = new FileSavePicker
                {
                    DefaultFileExtension = ".txt",
                    SuggestedStartLocation = PickerLocationId.Desktop,
                };
                picker.FileTypeChoices.Add("Plik tekstowy", new List<string>() { ".txt" });
                picker.FileTypeChoices.Add("Plik XML", new List<string>() { ".xml", ".xaml" });
                saveFile = await picker.PickSaveFileAsync();
                if (saveFile == null) return;
            }
            await FileIO.WriteTextAsync(saveFile, tBox_text.Text);
            await new MessageDialog("Zapisano plik " + saveFile.Name).ShowAsync();
            textChanged = false;
            tB_filename.Text = saveFile.Name;
        }
    }
}
