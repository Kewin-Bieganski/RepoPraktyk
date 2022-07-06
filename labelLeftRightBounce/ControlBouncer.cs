namespace labelLeftRightBounce
{
    internal class ControlBouncer
    {
        private static class Sense { public readonly static bool Positive = true; public readonly static bool Negative = false; };
        private Control bouncyControl;
        private bool xAxisSense = Sense.Positive;
        private bool yAxisSense = Sense.Positive;
        private int jumpSize = 0;
        private bool bouncingEnabled = true;

        public Control BouncyControl { get => bouncyControl; set => bouncyControl = value; }
        public int JumpSize { get => jumpSize; set => jumpSize = value; }
        public bool BouncingEnabled { get => bouncingEnabled; set => bouncingEnabled = value; }

        public ControlBouncer(Control bouncyControl, int jumpSize)
        {
            BouncyControl = bouncyControl;
            JumpSize = jumpSize;
        }

        public void Bounce()
        {
            if (bouncyControl != null && bouncingEnabled)
            {
                if (xAxisSense)
                {

                    if (bouncyControl.Left + jumpSize > bouncyControl.Parent.Width - bouncyControl.Width)
                    {
                        bouncyControl.Left = bouncyControl.Parent.Width - bouncyControl.Width;
                        xAxisSense = Sense.Negative;
                    }
                    else
                    {
                        bouncyControl.Left += jumpSize;
                    }
                }
                else
                {

                    if (bouncyControl.Left - jumpSize < 0)
                    {
                        bouncyControl.Left = 0;
                        xAxisSense = Sense.Positive;
                    }
                    else
                    {
                        bouncyControl.Left -= jumpSize;
                    }
                }
                if (yAxisSense)
                {

                    if (bouncyControl.Top + jumpSize > bouncyControl.Parent.Height - bouncyControl.Height)
                    {
                        bouncyControl.Top = bouncyControl.Parent.Height - bouncyControl.Height;
                        yAxisSense = Sense.Negative;
                    }
                    else
                    {
                        bouncyControl.Top += jumpSize;
                    }
                }
                else
                {

                    if (bouncyControl.Top - jumpSize < 0)
                    {
                        bouncyControl.Top = 0;
                        yAxisSense = Sense.Positive;
                    }
                    else
                    {
                        bouncyControl.Top -= jumpSize;
                    }
                }
            }
        }
    }
}
