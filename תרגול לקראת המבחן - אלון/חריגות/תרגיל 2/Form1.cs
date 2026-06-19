namespace תרגיל_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double percent = 0.1;
                if (txtSales.Text == "" || txtYears.Text == "")
                {
                    throw new FormatException("חייב למלא את השדות עם מספר");
                }

                double sales = double.Parse(txtSales.Text);
                int years = int.Parse(txtYears.Text);

                if (years == 0 || sales == 0)
                {
                    throw new DivideByZeroException();
                }
                if (sales <= 0)
                {
                    throw new Exception("סך המכירות אינו יכול להיות שלילי");
                }
                if (years > 40 || years <= 0)
                {
                    throw new Exception ("שנות הניסיון צריכות להיות בין 0 - 40");
                }
                double bonus = ((sales * percent) + (years * 500));
                lblBonus.Text = bonus.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Null Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("you cant devide by zero", "ERROR Values !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSales.Clear();
                txtYears.Clear();
            }
        }
         }
        }


