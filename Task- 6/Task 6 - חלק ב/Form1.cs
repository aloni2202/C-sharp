namespace Task_6___חלק_ב
{
    public partial class Form1 : Form
    {
        DBConnection db = new DBConnection();
        Store store = new Store();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            store.DeleteItem(int.Parse(txtDelete.Text));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            store.InsertItem(txtName.Text , txtDescription.Text , int.Parse(txtPrice.Text));
        }
    }
    }
}

