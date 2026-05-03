using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Targil_ami_tami
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form3_SignIn logInForm = (Form3_SignIn)this.Tag;
            string newName = txt_name.Text;
            string newID = txt_newID.Text;
            bool isAdded = false;

            for (int i = 0; i < logInForm.usersLogIn.GetLength(0); i++)
            {
                if (logInForm.usersLogIn[i, 0] == null)
                {
                    logInForm.usersLogIn[i, 0] = newName;
                    logInForm.usersLogIn[i, 1] = newID;
                    isAdded = true;
                    break;
                }
            }
            if (isAdded)
            {
                MessageBox.Show("נרשמת בהצלחה , עכשיו אפשר לחזור ולתהחבר ");
                this.Close();
            }
            else
            {
                MessageBox.Show("מצטערים , אין מקום פנוי עבורך במערכת ");
            }
        }
    }
}
