namespace שאלה_1_מבחן_לדגומא
{
    partial class RolletaForm
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
            btnLoop = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnLoop
            // 
            btnLoop.Location = new Point(444, 280);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new Size(127, 54);
            btnLoop.TabIndex = 0;
            btnLoop.Text = "גלגל אותה";
            btnLoop.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(256, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 54);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "סיום";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RolletaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLoop);
            Name = "RolletaForm";
            Text = "Rollete";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoop;
        private Button btnCancel;
    }
}
