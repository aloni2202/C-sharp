namespace Targil_ami_tami
{
    public partial class Form1_Menu : Form
    {

        public Form1_Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_About About = new Form2_About();
            About.MdiParent = this;
            About.Show();

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3_SignIn SignIn = new Form3_SignIn();
            SignIn.MdiParent = this;
            SignIn.Show();
        }
    }
}
