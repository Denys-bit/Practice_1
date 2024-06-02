namespace CustomControls
{
    partial class CustomUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            monthCalendarStart = new MonthCalendar();
            monthCalendarEnd = new MonthCalendar();
            labelInterval = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(27, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 29);
            label1.TabIndex = 0;
            label1.Text = "Вибір часового інтервалу";
            // 
            // monthCalendarStart
            // 
            monthCalendarStart.Location = new Point(27, 109);
            monthCalendarStart.Margin = new Padding(10);
            monthCalendarStart.Name = "monthCalendarStart";
            monthCalendarStart.TabIndex = 1;
            //monthCalendarStart.DateSelected += monthCalendarStart_DateSelected;
            // 
            // monthCalendarEnd
            // 
            monthCalendarEnd.Location = new Point(284, 109);
            monthCalendarEnd.Margin = new Padding(10);
            monthCalendarEnd.Name = "monthCalendarEnd";
            monthCalendarEnd.TabIndex = 2;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Location = new Point(27, 303);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(113, 29);
            labelInterval.TabIndex = 3;
            labelInterval.Text = "Інтервал: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(75, 76);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 4;
            label3.Text = "Початкова дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(343, 76);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 5;
            label4.Text = "Кінцева дата";
            // 
            // CustomUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelInterval);
            Controls.Add(monthCalendarEnd);
            Controls.Add(monthCalendarStart);
            Controls.Add(label1);
            Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CustomUserControl";
            Size = new Size(539, 355);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendarStart;
        private MonthCalendar monthCalendarEnd;
        private Label labelInterval;
        private Label label3;
        private Label label4;
    }
}
