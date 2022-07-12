namespace hideAndSeek
{
    internal class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return $"{base.Description} Ktoś może ukrywać się w {HidingPlaceName}.";
            }
        }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }

    }
}
