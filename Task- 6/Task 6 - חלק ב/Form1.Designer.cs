namespace Task_6___חלק_ב
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
            dataGridView1 = new DataGridView();
            txtMinPrice = new TextBox();
            btnFilter = new Button();
            btnCancelFilter = new Button();
            btnDelete = new Button();
            btnUpdateDB = new Button();
            txtDelete = new TextBox();
            gbDeleteItem = new GroupBox();
            gbInsertItem = new GroupBox();
            txtName = new TextBox();
            btnInsert = new Button();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbDeleteItem.SuspendLayout();
            gbInsertItem.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(546, 306);
            dataGridView1.TabIndex = 0;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(677, 32);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Above the price for filtering";
            txtMinPrice.Size = new Size(235, 31);
            txtMinPrice.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(854, 95);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 62);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.Location = new Point(639, 95);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(112, 62);
            btnCancelFilter.TabIndex = 3;
            btnCancelFilter.Text = "Cancel Filter";
            btnCancelFilter.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(72, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(727, 231);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(185, 60);
            btnUpdateDB.TabIndex = 6;
            btnUpdateDB.Text = "Update Data Base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(91, 48);
            txtDelete.Name = "txtDelete";
            txtDelete.PlaceholderText = "Code";
            txtDelete.Size = new Size(150, 31);
            txtDelete.TabIndex = 7;
            // 
            // gbDeleteItem
            // 
            gbDeleteItem.Controls.Add(txtDelete);
            gbDeleteItem.Controls.Add(btnDelete);
            gbDeleteItem.Location = new Point(44, 371);
            gbDeleteItem.Name = "gbDeleteItem";
            gbDeleteItem.Size = new Size(327, 163);
            gbDeleteItem.TabIndex = 8;
            gbDeleteItem.TabStop = false;
            gbDeleteItem.Text = "Delete item";
            // 
            // gbInsertItem
            // 
            gbInsertItem.Controls.Add(txtPrice);
            gbInsertItem.Controls.Add(txtDescription);
            gbInsertItem.Controls.Add(txtName);
            gbInsertItem.Controls.Add(btnInsert);
            gbInsertItem.Location = new Point(462, 371);
            gbInsertItem.Name = "gbInsertItem";
            gbInsertItem.Size = new Size(504, 163);
            gbInsertItem.TabIndex = 9;
            gbInsertItem.TabStop = false;
            gbInsertItem.Text = "Insert item";
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 48);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(100, 31);
            txtName.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(96, 110);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(326, 34);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(189, 48);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(100, 31);
            txtDescription.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(349, 48);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(101, 31);
            txtPrice.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 599);
            Controls.Add(gbInsertItem);
            Controls.Add(gbDeleteItem);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnCancelFilter);
            Controls.Add(btnFilter);
            Controls.Add(txtMinPrice);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbDeleteItem.ResumeLayout(false);
            gbDeleteItem.PerformLayout();
            gbInsertItem.ResumeLayout(false);
            gbInsertItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtMinPrice;
        private Button btnFilter;
        private Button btnCancelFilter;
        private Button btnDelete;
        private Button btnUpdateDB;
        private TextBox txtDelete;
        private GroupBox gbDeleteItem;
        private GroupBox gbInsertItem;
        private TextBox txtName;
        private Button btnInsert;
        private TextBox txtPrice;
        private TextBox txtDescription;
    }
}
