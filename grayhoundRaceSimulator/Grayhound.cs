namespace grayhoundRaceSimulator
{
    internal class Grayhound
    {
        public int id;
        public int startingPosition = 0;
        public int location = 0;
        public static Random random = new Random();
        public PictureBox myPictureBox;

        public int jumpSize = 0;

        public bool Run()
        {
            jumpSize = random.Next(0, 20);
            if (myPictureBox != null)
            {
                if (myPictureBox.Left + jumpSize > myPictureBox.Parent.Width - myPictureBox.Width)
                {
                    myPictureBox.Left = myPictureBox.Parent.Width - myPictureBox.Width;
                    if (Bet.winningGrayhound == null)
                    {
                        Bet.winningGrayhound = this;
                        Bet.GameOver();
                    }
                }
                else
                {
                    myPictureBox.Left += jumpSize;
                }
            }
            return true;
        }
        public void TakeStartingPosition()
        {
            Bet.winningGrayhound = null;
            myPictureBox.Left = startingPosition;
        }
    }
}
