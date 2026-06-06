namespace Task4___Q2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm view = new ViewForm();
            view.MdiParent = this;
            view.Show();
        }
    }
}
