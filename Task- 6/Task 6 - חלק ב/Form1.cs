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
            Item item = new Item(txtName.Text, txtDescription.Text, int.Parse(txtPrice.Text));
            store.InsertItem(item);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.RefreshTabel();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}


