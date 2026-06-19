namespace חזרה_על_חריגות_וGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotalBudget = new TextBox();
            txtNumOfEmployee = new TextBox();
            btnSalaryPerEmployee = new Button();
            lblResualt = new Label();
            SuspendLayout();
            // 
            // txtTotalBudget
            // 
            txtTotalBudget.Location = new Point(296, 91);
            txtTotalBudget.Name = "txtTotalBudget";
            txtTotalBudget.PlaceholderText = "הזן תקציב כולל";
            txtTotalBudget.RightToLeft = RightToLeft.Yes;
            txtTotalBudget.Size = new Size(169, 31);
            txtTotalBudget.TabIndex = 0;
            // 
            // txtNumOfEmployee
            // 
            txtNumOfEmployee.Location = new Point(296, 159);
            txtNumOfEmployee.Name = "txtNumOfEmployee";
            txtNumOfEmployee.PlaceholderText = "הזן מס עובדים";
            txtNumOfEmployee.RightToLeft = RightToLeft.Yes;
            txtNumOfEmployee.Size = new Size(169, 31);
            txtNumOfEmployee.TabIndex = 1;
            // 
            // btnSalaryPerEmployee
            // 
            btnSalaryPerEmployee.Location = new Point(296, 219);
            btnSalaryPerEmployee.Name = "btnSalaryPerEmployee";
            btnSalaryPerEmployee.Size = new Size(169, 34);
            btnSalaryPerEmployee.TabIndex = 2;
            btnSalaryPerEmployee.Text = "חשב תקציב לעובד";
            btnSalaryPerEmployee.UseVisualStyleBackColor = true;
            btnSalaryPerEmployee.Click += btnSalaryPerEmployee_Click;
            // 
            // lblResualt
            // 
            lblResualt.AutoSize = true;
            lblResualt.Location = new Point(403, 286);
            lblResualt.Name = "lblResualt";
            lblResualt.Size = new Size(0, 25);
            lblResualt.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResualt);
            Controls.Add(btnSalaryPerEmployee);
            Controls.Add(txtNumOfEmployee);
            Controls.Add(txtTotalBudget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalBudget;
        private TextBox txtNumOfEmployee;
        private Button btnSalaryPerEmployee;
        private Label lblResualt;
    }
}
