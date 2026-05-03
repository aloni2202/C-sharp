namespace Targil_ami_tami
{
    partial class Form3_SignIn
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
            lblUserID = new Label();
            txt_ID = new TextBox();
            btnSignIn = new Button();
            btn_goToSignUp = new Button();
            SuspendLayout();
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(313, 34);
            lblUserID.Name = "lblUserID";
            lblUserID.RightToLeft = RightToLeft.Yes;
            lblUserID.Size = new Size(150, 25);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "הכנס תעודת זהות";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(313, 82);
            txt_ID.Name = "txt_ID";
            txt_ID.PlaceholderText = "הכנס כאן ..";
            txt_ID.RightToLeft = RightToLeft.Yes;
            txt_ID.Size = new Size(150, 31);
            txt_ID.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(329, 140);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.RightToLeft = RightToLeft.Yes;
            btnSignIn.Size = new Size(112, 34);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "התחבר ";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btn_goToSignUp
            // 
            btn_goToSignUp.Location = new Point(329, 201);
            btn_goToSignUp.Name = "btn_goToSignUp";
            btn_goToSignUp.RightToLeft = RightToLeft.Yes;
            btn_goToSignUp.Size = new Size(112, 34);
            btn_goToSignUp.TabIndex = 3;
            btn_goToSignUp.Text = "להרשמה";
            btn_goToSignUp.UseVisualStyleBackColor = true;
            btn_goToSignUp.Visible = false;
            btn_goToSignUp.Click += btn_goToSignUp_Click;
            // 
            // Form3_SignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_goToSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txt_ID);
            Controls.Add(lblUserID);
            Name = "Form3_SignIn";
            RightToLeftLayout = true;
            Text = "Sign in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserID;
        private TextBox txt_ID;
        private Button btnSignIn;
        private Button btn_goToSignUp;
    }
}