using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Storage.FileProperties;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using System.Collections.Generic;

namespace excuseManagerXaml
{
    internal class ExcuseManager : INotifyPropertyChanged
    {
        public Excuse CurrentExcuse { get; set; }
        public string FileDate { get; private set; }
        private Random random = new Random();
        private IStorageFolder excuseFolder = null;
        private IStorageFile excuseFile;

        public ExcuseManager()
        {
            NewExcuseAsync();
        }

        public async void NewExcuseAsync()
        {
            CurrentExcuse = new Excuse();
            excuseFile = null;
            OnPropertyChanged("CurrentExcuse");
            await UpdateFileDateAsync();
        }

        public async Task<bool> ChooseNewFolderAsync()
        {
            FolderPicker folderPicker = new FolderPicker()
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
            };
            folderPicker.FileTypeFilter.Add(".xml");
            IStorageFolder folder = await folderPicker.PickSingleFolderAsync();
            if(folder != null)
            {
                excuseFolder = folder;
                return true;
            }
            MessageDialog warningDialog = new MessageDialog("Nie wybrano folderu wymówek");
            await warningDialog.ShowAsync();
            return false;
        }

        public void SetToCurrentTime()
        {
            CurrentExcuse.LastUsed = DateTimeOffset.Now.ToString();
            OnPropertyChanged("CurrentExcuse");
        }

        public async void OpenExcuseAsync()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
                CommitButtonText = "Otwórz plik wymówki",
            };
            picker.FileTypeFilter.Add(".xml");
            excuseFile = await picker.PickSingleFileAsync();
            if (excuseFile != null)
                await ReadExcuseAsync();
        }

        public async void OpenRandomExcuseAsync()
        {
            IReadOnlyList<IStorageFile> files = await excuseFolder.GetFilesAsync();
            excuseFile = files[random.Next(0, files.Count)];
            await ReadExcuseAsync();
        }

        public async Task UpdateFileDateAsync()
        {
            if (excuseFile != null)
            {
                BasicProperties basicProperties = await excuseFile.GetBasicPropertiesAsync();
                FileDate = basicProperties.DateModified.ToString();
            }
            else
                FileDate = "(nie wczytano pliku)";
            OnPropertyChanged("FileDate");
        }

        public async void SaveCurrentExcuseAsync()
        {
            if(CurrentExcuse == null)
            {
                await new MessageDialog("Nie wczytano wymówki").ShowAsync();
                return;
            }
            if(String.IsNullOrEmpty(CurrentExcuse.Description))
            {
                await new MessageDialog("Bieżąca wymówka nie ma opisu").ShowAsync();
                return;
            }
            if(excuseFile == null)
                excuseFile = await excuseFolder.CreateFileAsync(CurrentExcuse.Description + ".xml", CreationCollisionOption.ReplaceExisting);
            await WriteExcuseAsync();
        }

        public async Task ReadExcuseAsync()
        {
            using(IRandomAccessStream stream = await excuseFile.OpenAsync(FileAccessMode.Read))
            using(Stream inputStream = stream.AsStreamForRead())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Excuse));
                CurrentExcuse = (Excuse)serializer.ReadObject(inputStream);
            }

            await new MessageDialog("Wymówka wczytania z pliku " + excuseFile.Name).ShowAsync();
            OnPropertyChanged("CurrentExcuse");
            await UpdateFileDateAsync();
        }

        public async Task WriteExcuseAsync()
        {
            using (IRandomAccessStream stream = await excuseFile.OpenAsync(FileAccessMode.ReadWrite))
            using(Stream outputStream = stream.AsStreamForWrite())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Excuse));
                serializer.WriteObject(outputStream, CurrentExcuse);
            }
            await new MessageDialog("Wymówka zapisana w pliku " + excuseFile.Name).ShowAsync();
            await UpdateFileDateAsync();
        }

        public async void SaveCurrentExcuseAsAsync()
        {
            FileSavePicker picker = new FileSavePicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
                SuggestedFileName = CurrentExcuse.Description,
                CommitButtonText = "Zapisz plik wymówki",
            };
            picker.FileTypeChoices.Add("Plik XML", new List<string>() { ".xml" });
            IStorageFile newExcuseFile = await picker.PickSaveFileAsync();
            if(newExcuseFile != null)
            {
                excuseFile = newExcuseFile;
                await WriteExcuseAsync();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if(propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
