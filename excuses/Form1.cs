namespace excuses
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dTP_lastTimeUsed.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.tB_excuse.Text = currentExcuse.Description;
                this.tB_result.Text = currentExcuse.Results;
                this.dTP_lastTimeUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    l_fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Program do zarz¹dzania wymówkami";
            }
            else
                this.Text = "Program do zarz¹dzania wymówkami*";
            this.formChanged = changed;
        }

        private bool CheckChanged()
        {
            if(formChanged)
            {
                DialogResult result = MessageBox.Show("Bie¿¹ca wymówka nie zosta³a zapisana. Czy kontynuowaæ?", "Ostrze¿enie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void b_folder_Click(object sender, EventArgs e)
        {
            fBD_browse.SelectedPath = selectedFolder;
            DialogResult result = fBD_browse.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedFolder = fBD_browse.SelectedPath;
                b_save.Enabled = true;
                b_open.Enabled = true;
                b_randomExcuse.Enabled = true;
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tB_excuse.Text) || String.IsNullOrEmpty(tB_result.Text))
            {
                MessageBox.Show("Okreœl wymówkê i rezultat", "Nie mo¿na zapisaæ pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sFD_save.InitialDirectory = selectedFolder;
            sFD_save.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            sFD_save.FileName = tB_excuse.Text + ".txt";
            DialogResult result = sFD_save.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(sFD_save.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                oFD_open.InitialDirectory = selectedFolder;
                oFD_open.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                oFD_open.FileName = tB_excuse.Text + ".txt";
            }
            DialogResult result = oFD_open.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse = new Excuse(oFD_open.FileName);
                UpdateForm(false);
            }
        }

        private void b_randomExcuse_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void tB_excuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = tB_excuse.Text;
            UpdateForm(true);
        }

        private void tB_result_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = tB_result.Text;
            UpdateForm(true);
        }

        private void dTP_lastTimeUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dTP_lastTimeUsed.Value;
            UpdateForm(true);
        }
    }
}