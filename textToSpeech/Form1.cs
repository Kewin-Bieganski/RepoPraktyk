using System.Speech.Synthesis;
using System.Text.RegularExpressions;

namespace textToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            speechSynthesizer.Rate = tBar_speed.Value;
        }

        private void b_speak_Click(object sender, EventArgs e)
        {
            if(speechSynthesizer.State.Equals(SynthesizerState.Ready))
            {
                speechSynthesizer.SpeakAsync(new Regex("\n").Replace(rTB_text.Text, " "));
            }
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            speechSynthesizer.SpeakAsyncCancelAll();
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            rTB_text.Text = "";
        }

        private void tBar_speed_Scroll(object sender, EventArgs e)
        {
            speechSynthesizer.Rate = tBar_speed.Value;
        }
    }
}