using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Targil_ami_tami
{
    public partial class Form3_SignIn : Form
    {
        public Form3_SignIn()
        {
            InitializeComponent();
        }
        public string[,] usersLogIn = {{"אורן" , "207012501"} ,
            {"אלון" , "211717590"},
            {null , null } ,
            {null , null } ,
            {null , null } ,
            {null , null } ,
            {null , null }
        };

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string inputID = txt_ID.Text;
            bool isFound = false;
            string userName = "";
            for (int i = 0; i < usersLogIn.GetLongLength(0); i++)
            {
                if (usersLogIn[i, 1] == inputID && usersLogIn[i, 1] != null)
                {
                    isFound = true;
                    userName = usersLogIn[i, 0];
                    break;
                }
            }
            if (isFound)
            {
                DialogResult result = MessageBox.Show(" שלום " + userName + " התחברת בהצלחה , האם תרצה להתחיל במשחק ?", "כניסה ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form_Play game = new Form_Play();
                    game.MdiParent = this.MdiParent;
                    game.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("המשתמש אינו קיים במערכת נא להירשם ");
                btn_goToSignUp.Visible = true;
            }
        }

        private void btn_goToSignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp signUp = new Form_SignUp();
            signUp.MdiParent = this.MdiParent;
            signUp.Tag = this;
            signUp.Show();

        }
    }
}