namespace partyPlanner2
{
    internal class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
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
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if(CakeSize() == 20)
                {
                    cakeCost = 40M + ActualLength * .25M;
                } else
                {
                    cakeCost = 75M + ActualLength * .25M;
                }
                return totalCost + cakeCost + (NumberOfPeople > 12 ? 100 : 0);
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
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


        private decimal CalculateCostOfDecorations()
        {
            return (FancyDecorations ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M); 
        }
    }
}
