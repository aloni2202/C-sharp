namespace מטלת_בית_6_חלק_ב
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
            dgvItems = new DataGridView();
            groupBox1 = new GroupBox();
            txtCode = new TextBox();
            btnDelete = new Button();
            groupBox2 = new GroupBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            btnInsert = new Button();
            btnCancelFilter = new Button();
            btnUpdateToDB = new Button();
            btnFilter = new Button();
            txtFilterByPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(42, 32);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(555, 273);
            dgvItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(102, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delete Item";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(97, 56);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(114, 31);
            txtCode.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(66, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Location = new Point(618, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 172);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert Item";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(361, 56);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(114, 31);
            txtPrice.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(192, 56);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(114, 31);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 56);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(114, 31);
            txtName.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(143, 116);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(228, 34);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.Location = new Point(761, 133);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(132, 57);
            btnCancelFilter.TabIndex = 3;
            btnCancelFilter.Text = "Cancel Filter";
            btnCancelFilter.UseVisualStyleBackColor = true;
            btnCancelFilter.Click += btnCancelFilter_Click;
            // 
            // btnUpdateToDB
            // 
            btnUpdateToDB.Location = new Point(800, 226);
            btnUpdateToDB.Name = "btnUpdateToDB";
            btnUpdateToDB.Size = new Size(253, 71);
            btnUpdateToDB.TabIndex = 6;
            btnUpdateToDB.Text = "Update Data Base";
            btnUpdateToDB.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(951, 133);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(142, 57);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtFilterByPrice
            // 
            txtFilterByPrice.Location = new Point(761, 57);
            txtFilterByPrice.Name = "txtFilterByPrice";
            txtFilterByPrice.PlaceholderText = "Above the price for filtering";
            txtFilterByPrice.Size = new Size(332, 31);
            txtFilterByPrice.TabIndex = 8;
            txtFilterByPrice.TextChanged += txtFilterByPrice_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 552);
            Controls.Add(txtFilterByPrice);
            Controls.Add(btnFilter);
            Controls.Add(btnUpdateToDB);
            Controls.Add(btnCancelFilter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvItems);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnCancelFilter;
        private Button btnUpdateToDB;
        private Button btnFilter;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtFilterByPrice;
        private TextBox txtCode;
        private TextBox txtPrice;
    }
}
