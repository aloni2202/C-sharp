namespace Targil_ami_tami
{
    partial class Form_Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Play));
            pb_apple = new PictureBox();
            pb_candy1 = new PictureBox();
            pb_candy2 = new PictureBox();
            pb_candy3 = new PictureBox();
            pb_candy5 = new PictureBox();
            pb_candy6 = new PictureBox();
            lbl_score = new Label();
            game_timer = new System.Windows.Forms.Timer(components);
            lbl_time = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_apple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy6).BeginInit();
            SuspendLayout();
            // 
            // pb_apple
            // 
            pb_apple.BackColor = Color.Transparent;
            pb_apple.Image = Properties.Resources.apple;
            pb_apple.Location = new Point(351, 39);
            pb_apple.Name = "pb_apple";
            pb_apple.Size = new Size(183, 116);
            pb_apple.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_apple.TabIndex = 0;
            pb_apple.TabStop = false;
            pb_apple.Click += pictureBox1_Click;
            // 
            // pb_candy1
            // 
            pb_candy1.BackColor = Color.Transparent;
            pb_candy1.Image = Properties.Resources.candy1;
            pb_candy1.Location = new Point(107, 155);
            pb_candy1.Name = "pb_candy1";
            pb_candy1.Size = new Size(183, 116);
            pb_candy1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_candy1.TabIndex = 1;
            pb_candy1.TabStop = false;
            pb_candy1.Click += pb_candy1_Click;
            // 
            // pb_candy2
            // 
            pb_candy2.BackColor = Color.Transparent;
            pb_candy2.Image = Properties.Resources.candy2;
            pb_candy2.Location = new Point(107, 305);
            pb_candy2.Name = "pb_candy2";
            pb_candy2.Size = new Size(183, 116);
            pb_candy2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_candy2.TabIndex = 2;
            pb_candy2.TabStop = false;
            pb_candy2.Click += pb_candy2_Click;
            // 
            // pb_candy3
            // 
            pb_candy3.BackColor = Color.Transparent;
            pb_candy3.Image = Properties.Resources.candy3;
            pb_candy3.Location = new Point(351, 209);
            pb_candy3.Name = "pb_candy3";
            pb_candy3.Size = new Size(183, 116);
            pb_candy3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_candy3.TabIndex = 3;
            pb_candy3.TabStop = false;
            pb_candy3.Click += pb_candy3_Click;
            // 
            // pb_candy5
            // 
            pb_candy5.BackColor = Color.Transparent;
            pb_candy5.Image = Properties.Resources.candy5;
            pb_candy5.Location = new Point(591, 39);
            pb_candy5.Name = "pb_candy5";
            pb_candy5.Size = new Size(183, 116);
            pb_candy5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_candy5.TabIndex = 4;
            pb_candy5.TabStop = false;
            pb_candy5.Click += pb_candy5_Click;
            // 
            // pb_candy6
            // 
            pb_candy6.BackColor = Color.Transparent;
            pb_candy6.Image = Properties.Resources.candy6;
            pb_candy6.Location = new Point(591, 209);
            pb_candy6.Name = "pb_candy6";
            pb_candy6.Size = new Size(183, 116);
            pb_candy6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_candy6.TabIndex = 5;
            pb_candy6.TabStop = false;
            pb_candy6.Click += pb_candy6_Click;
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.BackColor = Color.Transparent;
            lbl_score.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_score.ForeColor = SystemColors.Control;
            lbl_score.Location = new Point(12, 88);
            lbl_score.Name = "lbl_score";
            lbl_score.RightToLeft = RightToLeft.Yes;
            lbl_score.Size = new Size(103, 32);
            lbl_score.TabIndex = 6;
            lbl_score.Text = "ניקוד : 0";
            lbl_score.TextAlign = ContentAlignment.TopRight;
            lbl_score.Click += lbl_score_Click;
            // 
            // game_timer
            // 
            game_timer.Enabled = true;
            game_timer.Interval = 2000;
            game_timer.Tick += game_timer_Tick;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.BackColor = Color.Transparent;
            lbl_time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_time.ForeColor = SystemColors.ButtonHighlight;
            lbl_time.Location = new Point(12, 120);
            lbl_time.Name = "lbl_time";
            lbl_time.RightToLeft = RightToLeft.Yes;
            lbl_time.Size = new Size(222, 32);
            lbl_time.TabIndex = 7;
            lbl_time.Text = "הזמן שנותר : 03:00\r\n";
            // 
            // Form_Play
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_time);
            Controls.Add(lbl_score);
            Controls.Add(pb_candy6);
            Controls.Add(pb_candy5);
            Controls.Add(pb_candy3);
            Controls.Add(pb_candy2);
            Controls.Add(pb_candy1);
            Controls.Add(pb_apple);
            DoubleBuffered = true;
            Name = "Form_Play";
            RightToLeftLayout = true;
            Text = "play_game";
            ((System.ComponentModel.ISupportInitialize)pb_apple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_candy6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_apple;
        private PictureBox pb_candy1;
        private PictureBox pb_candy2;
        private PictureBox pb_candy3;
        private PictureBox pb_candy5;
        private PictureBox pb_candy6;
        private Label lbl_score;
        private System.Windows.Forms.Timer game_timer;
        private Label lbl_time;
    }
}