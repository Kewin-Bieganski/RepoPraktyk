using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace serializeGuyXamlWithGui
{
    internal class GuyManager : INotifyPropertyChanged
    {
        private IStorageFile latestGuyFile;
        private Guy joe = new Guy("Joe", 37, 123M);
        private Guy bob = new Guy("Bob", 45, 4.23M);
        private Guy ed = new Guy("Ed", 43, 39.3M);

        public IStorageFile LatestGuyFile { get { return latestGuyFile; } }
        public Guy Joe { get { return joe; } }
        public Guy Bob { get { return bob; } }
        public Guy Ed { get { return ed; } }
        public Guy NewGuy { get; private set; }
        public string Path { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public async Task ReadGuyAsync()
        {
            if (String.IsNullOrEmpty(Path)) return;
            latestGuyFile = await StorageFile.GetFileFromPathAsync(Path);
            using (IRandomAccessStream stream = await latestGuyFile.OpenAsync(FileAccessMode.Read))
            using (Stream inputStream = stream.AsStreamForRead())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Guy));
                NewGuy = serializer.ReadObject(inputStream) as Guy;
                OnPropertyChanged("NewGuy");
                OnPropertyChanged("LatestGuyFile");
            }
        }

        public async Task WriteGuyAsync(Guy guyToWrite)
        {
            IStorageFolder guysFolder = await KnownFolders.DocumentsLibrary.CreateFolderAsync("Faceci", CreationCollisionOption.OpenIfExists);
            latestGuyFile = await guysFolder.CreateFileAsync(guyToWrite.Name + ".xml", CreationCollisionOption.ReplaceExisting);
            using (IRandomAccessStream stream = await latestGuyFile.OpenAsync(FileAccessMode.ReadWrite))
            using (Stream outputStream = stream.AsStreamForWrite())
            {
                DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Guy));
                dataContractSerializer.WriteObject(outputStream, guyToWrite);
            }
            Path = latestGuyFile.Path;
            OnPropertyChanged("Path");
            OnPropertyChanged("LatestGuyFile");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null) propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
