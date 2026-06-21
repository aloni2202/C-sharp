namespace תרגיל_בית_2___ממשק_MDI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
    

        private void opAddAnimal_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog(this);
        }

        private void opViewSystem_Click(object sender, EventArgs e)
        {
            ViewForm view = new ViewForm();
            view.MdiParent = this;
            view.Show();
        }
    }
}
