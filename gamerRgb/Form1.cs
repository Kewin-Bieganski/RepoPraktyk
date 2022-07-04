namespace gamerRgb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_rgb_Click(object sender, EventArgs e)
        {
            while(Visible)
            {
                for (int c = 0; c <= 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(5);
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(5);
                }
            }
        }
    }
}