namespace ControlDemoApp
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
            customUserControl1 = new CustomControls.CustomUserControl();
            SuspendLayout();
            // 
            // customUserControl1
            // 
            customUserControl1.EndDate = new DateTime(2024, 6, 2, 0, 0, 0, 0);
            customUserControl1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customUserControl1.Location = new Point(118, 36);
            customUserControl1.Margin = new Padding(5, 6, 5, 6);
            customUserControl1.Name = "customUserControl1";
            customUserControl1.Size = new Size(539, 355);
            customUserControl1.StartDate = new DateTime(2024, 6, 2, 0, 0, 0, 0);
            customUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customUserControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomUserControl customUserControl1;
    }
}
