using Microsoft.Data.SqlClient;

namespace שאלה_1_מבחן_לדגומא
{
    public partial class RolletaForm : Form
    {
        List<DateTimeIRN> numbers = new List<DateTimeIRN>();
        int counter = 1;
        string path = "numbers.txt";
        public RolletaForm()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(path) != null)
                File.Delete(path);
            DateTimeIRN dateTime = new DateTimeIRN(counter++);
            numbers.Add(dateTime);
            lblNum.Text = dateTime.Number.ToString();
            File.AppendAllText(path, dateTime.ToString() + "\n");
            if (dateTime.Number.ToString().IndexOf("7") != -1)
            {
                MessageBox.Show("There is number that include 7", "GOOD LUCK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int maxNumber = 0;
            int maxIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Number > maxNumber)
                {
                    maxNumber = numbers[i].Number;
                    maxIndex = i;
                }
            }
            string text = File.ReadAllText(path);

            text = text.Replace(
                $"Number : {numbers[maxIndex].Number} Index : {numbers[maxIndex].Index} Date : {numbers[maxIndex].Date} Time : {numbers[maxIndex].Time}",
                 $"Number : {numbers[maxIndex].Number} The Biggest !!!  Index : {numbers[maxIndex].Index} Date : {numbers[maxIndex].Date} Time : {numbers[maxIndex].Time}",
                );
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(text);
            writer.Close();
            UpdateDB(numbers, maxNumber);
            this.Close();
        }
        
        public void UpdateDB(List<DateTimeIRN> numbers,int max)
        {
            int maxGameID;
            string strCon = @"Data Source=LAPTOP-4IDR81RE\SQLEXPRESS;Initial Catalog=DBRollete;Integrated Security=True;Trust Server Certificate=True";
            string strCmd;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader reader;
            con = new SqlConnection(strCon);
            strCmd = $"INSERT INTO TBGames (MaxNumber)" +
                $"VALUES('{max}')";
            cmd = new SqlCommand(strCmd, con);
            cmd.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {

            }



        }
    }
}

