namespace dialogs2
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
            oFD_open.Title = "Otw�rz sw�j plik";
            sFD_save.Title = "Zapisz sw�j plik";
            oFD_open.Filter = sFD_save.Filter = "Plik tekstowy (*.txt)|*.txt";
            oFD_open.InitialDirectory = sFD_save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if(oFD_open.ShowDialog() == DialogResult.OK)
            {
                name = oFD_open.FileName;
                tB_io.Text = File.ReadAllText(name);
            }
        }

        private void b_safe_Click(object sender, EventArgs e)
        {
            if(sFD_save.ShowDialog() == DialogResult.OK)
            {
                name = sFD_save.FileName;
                File.WriteAllText(name, tB_io.Text);
            }
        }
    }
}