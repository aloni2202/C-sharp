namespace תרגיל_בית_2___ממשק_MDI
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
            menuStrip1 = new MenuStrip();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            opAddAnimal = new ToolStripMenuItem();
            opViewSystem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { operationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opAddAnimal, opViewSystem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(116, 29);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // opAddAnimal
            // 
            opAddAnimal.Name = "opAddAnimal";
            opAddAnimal.Size = new Size(270, 34);
            opAddAnimal.Text = "Add Animal";
            opAddAnimal.Click += opAddAnimal_Click;
            // 
            // opViewSystem
            // 
            opViewSystem.Name = "opViewSystem";
            opViewSystem.Size = new Size(270, 34);
            opViewSystem.Text = "View System";
            opViewSystem.Click += opViewSystem_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem opAddAnimal;
        private ToolStripMenuItem opViewSystem;
    }
}
