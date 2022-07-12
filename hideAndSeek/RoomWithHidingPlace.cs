namespace hideAndSeek
{
    internal class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return $"{base.Description} Ktoś może ukrywać się {HidingPlaceName}.";
            }
        }
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
    }
}
