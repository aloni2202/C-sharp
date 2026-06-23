namespace מטלת_בית_6_חלק_ב
{
    public partial class Form1 : Form
    {
        DBConnection DBConnection;
        Store s = new Store();
        public Form1()
        {
            InitializeComponent();
            dgvItems.DataSource = s.ItemTable();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvItems.DataSource = s.DeleteItem(int.Parse(txtCode.Text));
            txtCode.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Item item = new Item(txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text));
            dgvItems.DataSource = s.InsertItem(item);
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvItems.DataSource = s.FilterByAbovePrice(int.Parse(txtFilterByPrice.Text));
            txtFilterByPrice.Clear();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            dgvItems.DataSource = s.ItemTable();
        }

        private void txtFilterByPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


