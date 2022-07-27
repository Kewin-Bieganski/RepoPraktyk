using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;

namespace asyncFileXaml
{
    public sealed partial class MainPage : Page
    {
        string fileContents;
        public MainPage()
        {
            this.InitializeComponent();
            Read();
        }

        private async void Read()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.List,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            picker.FileTypeFilter.Add(".txt");
            IStorageFile file = await picker.PickSingleFileAsync();
            if(file != null)
            {
                fileContents = await FileIO.ReadTextAsync(file);
            }
            fileText.Text = fileContents;
            Write();
        }

        private async void Write()
        {
            FileSavePicker picker = new FileSavePicker
            {
                DefaultFileExtension = ".txt",
                SuggestedStartLocation = PickerLocationId.Desktop
            };
           picker.FileTypeChoices.Add("Plik tekstowy", new List<string>() { ".txt" });
            picker.FileTypeChoices.Add("Plik dziennika", new List<string>() { ".log", ".dat" });
            IStorageFile saveFile = await picker.PickSaveFileAsync();
            if (saveFile == null) return;
            fileText.Text = fileContents;
            await FileIO.WriteTextAsync(saveFile, fileContents);
        }
    }
}
