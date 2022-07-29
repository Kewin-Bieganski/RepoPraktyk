using System;
using System.Runtime.Serialization;
using cards;

namespace serializeGuyXamlWithGui
{
    [DataContract(Namespace = "space_name")]
    internal class Card
    {
        private static Random random = new Random();
        [DataMember]
        public Suits Suit { get; set; }
        [DataMember]
        public Values Value { get; set; }
        public string Name { 
            get {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public static Card RandomCard()
        {
            return new Card((Suits)random.Next(4), (Values)random.Next(1,14));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
