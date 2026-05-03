namespace Targil_ami_tami
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            lbl_UserName = new Label();
            lbl_ID_User = new Label();
            txt_name = new TextBox();
            txt_newID = new TextBox();
            btn_save = new Button();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.BackColor = Color.Transparent;
            lbl_UserName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserName.ForeColor = SystemColors.ButtonHighlight;
            lbl_UserName.Location = new Point(420, 115);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.RightToLeft = RightToLeft.Yes;
            lbl_UserName.Size = new Size(122, 29);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "שם משתמש ";
            // 
            // lbl_ID_User
            // 
            lbl_ID_User.AutoSize = true;
            lbl_ID_User.BackColor = Color.Transparent;
            lbl_ID_User.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID_User.ForeColor = SystemColors.ButtonHighlight;
            lbl_ID_User.Location = new Point(428, 177);
            lbl_ID_User.Name = "lbl_ID_User";
            lbl_ID_User.RightToLeft = RightToLeft.Yes;
            lbl_ID_User.Size = new Size(114, 29);
            lbl_ID_User.TabIndex = 1;
            lbl_ID_User.Text = "תעודת זהות";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(221, 115);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "הכנס כאן את שמך ..";
            txt_name.RightToLeft = RightToLeft.Yes;
            txt_name.Size = new Size(173, 31);
            txt_name.TabIndex = 2;
            // 
            // txt_newID
            // 
            txt_newID.Location = new Point(221, 175);
            txt_newID.Name = "txt_newID";
            txt_newID.PlaceholderText = "הכנס את הת\"ז כאן ...";
            txt_newID.RightToLeft = RightToLeft.Yes;
            txt_newID.Size = new Size(173, 31);
            txt_newID.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(308, 263);
            btn_save.Name = "btn_save";
            btn_save.RightToLeft = RightToLeft.Yes;
            btn_save.Size = new Size(173, 34);
            btn_save.TabIndex = 4;
            btn_save.Text = "שמור והירשם";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // Form_SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(txt_newID);
            Controls.Add(txt_name);
            Controls.Add(lbl_ID_User);
            Controls.Add(lbl_UserName);
            Name = "Form_SignUp";
            RightToLeftLayout = true;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserName;
        private Label lbl_ID_User;
        private TextBox txt_name;
        private TextBox txt_newID;
        private Button btn_save;
    }
}