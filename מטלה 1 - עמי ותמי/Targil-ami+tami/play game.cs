using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Targil_ami_tami
{
    public partial class Form_Play : Form
    {
        int score = 0;
        int timeLeft = 180;
        Random rnd = new Random();
        int targetScore = 100;

        int valCandy1 = 1;
        int valCandy2 = 2;
        int valCandy3 = 3;
        int valCandy5 = 2;
        int valCandy6 = 10;
        int valApple = -3;


        public Form_Play()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += valApple;
            if (score < 0)
            {
                score = 0;
            }
            UpdateScore();
            pb_apple.Visible = false;
            MessageBox.Show("אוי לא זה התפוח המורעל");
        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private void game_timer_Tick(object sender, EventArgs e)
        {
            MoveObject(pb_candy1);
            MoveObject(pb_candy2);
            MoveObject(pb_candy3);
            MoveObject(pb_candy5);
            MoveObject(pb_candy6);
            MoveObject(pb_apple);
            timeLeft -= 2 ;
            int minutes = timeLeft / 60;
            int secound = timeLeft % 60;
            lbl_time.Text = string.Format("{0:00}:{1:00} זמן שנותר :" , minutes, secound);
            if (timeLeft <= 0)
            {
                game_timer.Stop();
                MessageBox.Show("נגמר הזמן ! הניקוד הסופי שלך הוא :" + score);
                this.Close();
            }
        }

        private void MoveObject(PictureBox pb)
        {
            pb.Visible = true;
            int x = rnd.Next(0, this.ClientSize.Width - pb.Width);
            int y = rnd.Next(0, this.ClientSize.Height - pb.Height);
            pb.Location = new Point(x, y);
        }

        private void pb_candy5_Click(object sender, EventArgs e)
        {
            score += valCandy5;
            UpdateScore();
            pb_candy5.Visible = false;
        }

        private void pb_candy1_Click(object sender, EventArgs e)
        {
            score += valCandy1;
            UpdateScore();
            pb_candy1.Visible = false;
        }

        private void pb_candy6_Click(object sender, EventArgs e)
        {
            score += valCandy6;
            UpdateScore();
            pb_candy6.Visible = false;
        }

        private void pb_candy3_Click(object sender, EventArgs e)
        {
            score += valCandy3;
            UpdateScore();
            pb_candy3.Visible = false;
        }

        private void pb_candy2_Click(object sender, EventArgs e)
        {
            score += valCandy2;
            UpdateScore();
            pb_candy2.Visible = false;
        }

        private void UpdateScore()
        {
            lbl_score.Text = "הניקוד : " + score;
            if (score >= targetScore) 
            {
                game_timer.Stop();
                MessageBox.Show("כל הכבוד הגעת ל - " + score + "נקודות וניצחת את המכשפה !!");
                this.Close();
            }
        }
    }
}
