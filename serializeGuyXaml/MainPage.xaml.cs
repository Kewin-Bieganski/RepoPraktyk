using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace serializeGuyXaml
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Guy joe = new Guy("Joe", 37, 150.50M);
            DataContractSerializer serializer = new DataContractSerializer(typeof(Guy));
            IStorageFolder localFolder = ApplicationData.Current.LocalFolder;
            await new MessageDialog(ApplicationData.Current.LocalFolder.Path).ShowAsync();
            DataPackage package = new DataPackage();
            package.SetText(ApplicationData.Current.LocalFolder.Path);
            Clipboard.SetContent(package);
            IStorageFile guyFile = await localFolder.CreateFileAsync("Joe.xml", CreationCollisionOption.ReplaceExisting);
            using (IRandomAccessStream stream = await guyFile.OpenAsync(FileAccessMode.ReadWrite))
            using (Stream outputStream = stream.AsStreamForWrite())
            {
                serializer.WriteObject(outputStream, joe);
            }
            Guy copyOfJoe;
            using (IRandomAccessStream stream = await guyFile.OpenAsync(FileAccessMode.ReadWrite))
            using (Stream inputStream = stream.AsStreamForWrite())
            {
                copyOfJoe = serializer.ReadObject(inputStream) as Guy;
            }
            await new MessageDialog($"Cześć jestem {copyOfJoe.Name} i mam {copyOfJoe.Cash} dolców.").ShowAsync();
        }
    }

    [DataContract(Namespace = "MyNamespace")]
    internal class Guy
    {
        [IgnoreDataMember]
        public static string Version = "1.0.0.0";

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public int Age { get; private set; }

        [DataMember(Name="Kesz")]
        public decimal Cash { get; private set; }

        public Guy(string name, int age, decimal cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
        }
    }
}
