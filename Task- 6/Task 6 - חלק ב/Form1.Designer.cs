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
            dataGridView = new DataGridView();
            txtMinPrice = new TextBox();
            btnFilter = new Button();
            btnCancelFilter = new Button();
            btnDelete = new Button();
            btnUpdateDB = new Button();
            txtDelete = new TextBox();
            gbDeleteItem = new GroupBox();
            gbInsertItem = new GroupBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gbDeleteItem.SuspendLayout();
            gbInsertItem.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(35, 26);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(437, 245);
            dataGridView.TabIndex = 0;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(542, 26);
            txtMinPrice.Margin = new Padding(2);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "Above the price for filtering";
            txtMinPrice.Size = new Size(189, 27);
            txtMinPrice.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(683, 76);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(90, 50);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.Location = new Point(511, 76);
            btnCancelFilter.Margin = new Padding(2);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(90, 50);
            btnCancelFilter.TabIndex = 3;
            btnCancelFilter.Text = "Cancel Filter";
            btnCancelFilter.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(58, 88);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 27);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(582, 185);
            btnUpdateDB.Margin = new Padding(2);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(148, 48);
            btnUpdateDB.TabIndex = 6;
            btnUpdateDB.Text = "Update Data Base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(73, 38);
            txtDelete.Margin = new Padding(2);
            txtDelete.Name = "txtDelete";
            txtDelete.PlaceholderText = "Code";
            txtDelete.Size = new Size(121, 27);
            txtDelete.TabIndex = 7;
            // 
            // gbDeleteItem
            // 
            gbDeleteItem.Controls.Add(txtDelete);
            gbDeleteItem.Controls.Add(btnDelete);
            gbDeleteItem.Location = new Point(35, 297);
            gbDeleteItem.Margin = new Padding(2);
            gbDeleteItem.Name = "gbDeleteItem";
            gbDeleteItem.Padding = new Padding(2);
            gbDeleteItem.Size = new Size(262, 130);
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
            gbInsertItem.Location = new Point(370, 297);
            gbInsertItem.Margin = new Padding(2);
            gbInsertItem.Name = "gbInsertItem";
            gbInsertItem.Padding = new Padding(2);
            gbInsertItem.Size = new Size(403, 130);
            gbInsertItem.TabIndex = 9;
            gbInsertItem.TabStop = false;
            gbInsertItem.Text = "Insert item";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(279, 38);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(82, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(151, 38);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(81, 27);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 38);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(81, 27);
            txtName.TabIndex = 7;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(77, 88);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(261, 27);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 479);
            Controls.Add(gbInsertItem);
            Controls.Add(gbDeleteItem);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnCancelFilter);
            Controls.Add(btnFilter);
            Controls.Add(txtMinPrice);
            Controls.Add(dataGridView);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gbDeleteItem.ResumeLayout(false);
            gbDeleteItem.PerformLayout();
            gbInsertItem.ResumeLayout(false);
            gbInsertItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
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
