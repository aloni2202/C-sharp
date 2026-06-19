namespace תרגיל_3___ניהול_מלאי_וקליטת_ספקים
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
            txtName = new TextBox();
            txtAmount = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(316, 80);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "שם פריט";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(316, 213);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "כמות להוספה";
            txtAmount.RightToLeft = RightToLeft.Yes;
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(316, 146);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "מחיר ליחידה";
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(316, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "הוסף למלאי";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtAmount);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAmount;
        private TextBox txtPrice;
        private Button btnAdd;
    }
}
