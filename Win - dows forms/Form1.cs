namespace Win___dows_forms
{
    public partial class Form1 : Form
    {
        bool leftRight = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void b_changeText_Click(object sender, EventArgs e)
        {
            if (cB_changeText.Checked)
            {
                l_text.TextAlign = (leftRight ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleRight);
                l_text.Text = (leftRight ? "Lewo" : "Prawo");
                leftRight = !leftRight;
            }
            else
            {
                l_text.Text = "Mo¿liwoœæ zmiany tekstu, wy³¹czona.";
                l_text.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}