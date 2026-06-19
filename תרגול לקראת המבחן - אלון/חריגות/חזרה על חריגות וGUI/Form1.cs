namespace חזרה_על_חריגות_וGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalaryPerEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumOfEmployee.Text == "" || txtTotalBudget.Text == "")
                {
                    throw new FormatException();
                }

                double salary = double.Parse(txtTotalBudget.Text);
                int numOfEmployee = int.Parse(txtNumOfEmployee.Text);

                if (salary == 0 || numOfEmployee == 0)
                {
                    throw new DivideByZeroException();
                }
                double calc = salary / numOfEmployee;
                lblResualt.Text = $"Budget per employee : {calc}";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                txtNumOfEmployee.Clear();
                txtTotalBudget.Clear();
            }
        }
    }
}