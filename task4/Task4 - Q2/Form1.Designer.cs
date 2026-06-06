namespace Task4___Q2
{
    partial class mainForm
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
            ms_Op = new MenuStrip();
            operationToolStripMenuItem = new ToolStripMenuItem();
            addAnimalToolStripMenuItem = new ToolStripMenuItem();
            viewSystemToolStripMenuItem = new ToolStripMenuItem();
            ms_Op.SuspendLayout();
            SuspendLayout();
            // 
            // ms_Op
            // 
            ms_Op.ImageScalingSize = new Size(24, 24);
            ms_Op.Items.AddRange(new ToolStripItem[] { operationToolStripMenuItem });
            ms_Op.Location = new Point(0, 0);
            ms_Op.Name = "ms_Op";
            ms_Op.Size = new Size(800, 33);
            ms_Op.TabIndex = 1;
            ms_Op.Text = "Operation";
            // 
            // operationToolStripMenuItem
            // 
            operationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAnimalToolStripMenuItem, viewSystemToolStripMenuItem });
            operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            operationToolStripMenuItem.Size = new Size(108, 29);
            operationToolStripMenuItem.Text = "Operation";
            // 
            // addAnimalToolStripMenuItem
            // 
            addAnimalToolStripMenuItem.Name = "addAnimalToolStripMenuItem";
            addAnimalToolStripMenuItem.Size = new Size(270, 34);
            addAnimalToolStripMenuItem.Text = "Add Animal";
            addAnimalToolStripMenuItem.Click += addAnimalToolStripMenuItem_Click;
            // 
            // viewSystemToolStripMenuItem
            // 
            viewSystemToolStripMenuItem.Name = "viewSystemToolStripMenuItem";
            viewSystemToolStripMenuItem.Size = new Size(270, 34);
            viewSystemToolStripMenuItem.Text = "View System";
            viewSystemToolStripMenuItem.Click += viewSystemToolStripMenuItem_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ms_Op);
            IsMdiContainer = true;
            MainMenuStrip = ms_Op;
            Name = "mainForm";
            Text = "MainForm";
            ms_Op.ResumeLayout(false);
            ms_Op.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ms_Op;
        private ToolStripMenuItem operationToolStripMenuItem;
        private ToolStripMenuItem addAnimalToolStripMenuItem;
        private ToolStripMenuItem viewSystemToolStripMenuItem;
    }
}
