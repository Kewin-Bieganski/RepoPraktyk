namespace labelLeftRightBounce
{
    public partial class Form1 : Form
    {
        ControlBouncer controlBouncer;
        List<Control> controls = new List<Control>();
        List<ControlBouncer> bouncyControls = new List<ControlBouncer>();


        public Form1()
        {
            InitializeComponent();
            controls.Add(l_ball);
            controls.Add(l_box);
            controls.Add(l_diamond);
            controls.Add(b_ballControl);
            controls.Add(b_boxControl);
            controls.Add(b_diamondControl);
            foreach (var control in controls)
            {
                bouncyControls.Add(new ControlBouncer(control, new Random().Next(1, 7)));
            }
        }

        private void t_timer_Tick(object sender, EventArgs e)
        {
            foreach (var bouncyControl in bouncyControls)
            {
                bouncyControl.Bounce();
            }
        }

        private void b_ballControl_Click(object sender, EventArgs e)
        {
            bouncyControls[0].BouncingEnabled = !bouncyControls[0].BouncingEnabled;
        }

        private void b_boxControl_Click(object sender, EventArgs e)
        {
            bouncyControls[1].BouncingEnabled = !bouncyControls[1].BouncingEnabled;
        }

        private void b_diamondControl_Click(object sender, EventArgs e)
        {
            bouncyControls[2].BouncingEnabled = !bouncyControls[2].BouncingEnabled;
        }
    }
}