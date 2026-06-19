namespace תרגיל_3___ניהול_מלאי_וקליטת_ספקים
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAmount.Text == "" || txtPrice.Text == "")
                {
                    throw new Exception("נדרש למלא את כל השדות !");
                }
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                int amount = int.Parse(txtAmount.Text);
                if(amount <= 0)
                {
                    throw new Exception("מספר צריך להיות שלם וחיובי");
                }
                if (price <= 0)
                {
                    throw new Exception("דמי הניהול המינימליים לא מאפשרים קליטת פריטים בחינם");
                }

                MessageBox.Show($"The Item : {name} was succusfully added\n" +
                    $"added inventory value: {price * amount}");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "לוגיקה עסקית", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtAmount.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
        }
    }
}

