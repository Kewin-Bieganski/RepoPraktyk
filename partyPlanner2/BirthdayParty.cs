namespace partyPlanner2
{
    internal class BirthdayParty : Party
    {
        
        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong
        {
            get
            {
                return (CakeWriting.Length > MaxWritingLength() ? true : false);
            }
        }
        private int ActualLength
        {
            get
            {
                return (CakeWriting.Length > MaxWritingLength() ? MaxWritingLength() : CakeWriting.Length);
            }
        }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost = (CakeSize() == 20 ? 40M : 75M) + ActualLength * .25M;
                return totalCost + cakeCost + (NumberOfPeople > 12 ? 100 : 0);
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base(numberOfPeople, fancyDecorations)
        {
            CakeWriting = cakeWriting;
        }

        private int CakeSize()
        {
            return (NumberOfPeople <= 4 ? 20 : 40);
        }

        private int MaxWritingLength()
        {
            return (CakeSize() == 8 ? 16 : 40);
        }
    }
}
