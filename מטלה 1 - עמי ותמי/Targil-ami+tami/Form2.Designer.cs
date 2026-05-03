namespace Targil_ami_tami
{
    partial class Form2_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_About));
            lblInstruction = new Label();
            lblinfo = new Label();
            btn_Understand = new Button();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.BackColor = Color.Transparent;
            lblInstruction.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = SystemColors.ButtonHighlight;
            lblInstruction.Location = new Point(529, 21);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.RightToLeft = RightToLeft.Yes;
            lblInstruction.Size = new Size(250, 57);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "הוראות המשחק";
            lblInstruction.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblinfo
            // 
            lblinfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblinfo.BackColor = Color.Transparent;
            lblinfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinfo.ForeColor = SystemColors.InactiveBorder;
            lblinfo.Location = new Point(12, 78);
            lblinfo.Name = "lblinfo";
            lblinfo.RightToLeft = RightToLeft.Yes;
            lblinfo.Size = new Size(758, 295);
            lblinfo.TabIndex = 1;
            lblinfo.Text = resources.GetString("lblinfo.Text");
            lblinfo.TextAlign = ContentAlignment.TopCenter;
            lblinfo.Click += lblinfo_Click;
            // 
            // btn_Understand
            // 
            btn_Understand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Understand.Location = new Point(21, 398);
            btn_Understand.Name = "btn_Understand";
            btn_Understand.RightToLeft = RightToLeft.Yes;
            btn_Understand.Size = new Size(173, 34);
            btn_Understand.TabIndex = 2;
            btn_Understand.Text = "הבנתי , בוא נשחק";
            btn_Understand.TextAlign = ContentAlignment.BottomCenter;
            btn_Understand.UseVisualStyleBackColor = true;
            btn_Understand.Click += button1_Click;
            // 
            // Form2_About
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 594);
            Controls.Add(btn_Understand);
            Controls.Add(lblinfo);
            Controls.Add(lblInstruction);
            Name = "Form2_About";
            RightToLeftLayout = true;
            Text = "Form2_About";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInstruction;
        private Label lblinfo;
        private Button btn_Understand;
    }
}