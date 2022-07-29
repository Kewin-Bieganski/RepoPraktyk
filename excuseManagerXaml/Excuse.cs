using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace excuseManagerXaml
{
    [DataContract(Name = "http://namespace.com/MenadzerWymowek")]
    internal class Excuse : INotifyPropertyChanged
    {
        public string DateWarning { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        private DateTime lastUsed = DateTime.MinValue;
        public string LastUsed
        {
            get
            {
                if (lastUsed != DateTime.MinValue)
                    return lastUsed.ToString();
                else
                    return String.Empty;
            }
            set
            {
                DateTime d = DateTime.MinValue;
                bool dateIsValid = DateTime.TryParse(value, out d);
                lastUsed = d;
                if(!String.IsNullOrEmpty(value) && !dateIsValid)
                    DateWarning = "Nieprawidłpwa data: " + value;
                else
                    DateWarning = String.Empty;
                OnPropertyChanged("DateWarning");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
