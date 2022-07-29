using System;
using System.Runtime.Serialization;

namespace serializeGuyXamlWithGui
{
    [DataContract(Namespace = "space_name")]
    internal class Guy
    {
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int Age { get; private set; }
        [DataMember]
        public decimal Cash { get; private set; }
        [DataMember(Name = "MyCard")]
        public Card TrumpCard { get; set; }

        public Guy(string name, int age, decimal cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
            TrumpCard = Card.RandomCard();
        }

        public override string ToString()
        {
            return String.Format("Mam na imię {0}, {1} lat, i {2} zlotych w kieszeni, a moją atutową kartą jest {3}", Name, Age, Cash, TrumpCard);
        }
    }
}
