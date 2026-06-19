namespace תרגיל_2
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
            btnCalc = new Button();
            txtSales = new TextBox();
            txtYears = new TextBox();
            lblBonus = new Label();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(284, 215);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(195, 38);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "לחישוב";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtSales
            // 
            txtSales.Location = new Point(284, 93);
            txtSales.Name = "txtSales";
            txtSales.PlaceholderText = "סך המכירות";
            txtSales.RightToLeft = RightToLeft.Yes;
            txtSales.Size = new Size(195, 31);
            txtSales.TabIndex = 1;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(284, 157);
            txtYears.Name = "txtYears";
            txtYears.PlaceholderText = "שנות ותר";
            txtYears.RightToLeft = RightToLeft.Yes;
            txtYears.Size = new Size(195, 31);
            txtYears.TabIndex = 2;
            // 
            // lblBonus
            // 
            lblBonus.AutoSize = true;
            lblBonus.Location = new Point(336, 286);
            lblBonus.Name = "lblBonus";
            lblBonus.RightToLeft = RightToLeft.Yes;
            lblBonus.Size = new Size(108, 25);
            lblBonus.TabIndex = 3;
            lblBonus.Text = "הבונוס הוא...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBonus);
            Controls.Add(txtYears);
            Controls.Add(txtSales);
            Controls.Add(btnCalc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private TextBox txtSales;
        private TextBox txtYears;
        private Label lblBonus;
    }
}
