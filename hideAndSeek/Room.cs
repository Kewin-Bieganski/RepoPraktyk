namespace hideAndSeek
{
    internal class Room : Location
    {
        private string decoration;
        public override string Description
        {
            get
            {
                return $"{base.Description} Widzisz tutaj {decoration}.";
            }
        }
        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
    }
}
