namespace CalenderReminder
{
    partial class Calendar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarControl1 = new CalenderReminder.Calendar_Controls.CalendarControl();
            this.bSwitchMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(2, 42);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(939, 721);
            this.calendarControl1.TabIndex = 0;
            // 
            // bSwitchMode
            // 
            this.bSwitchMode.Location = new System.Drawing.Point(13, 13);
            this.bSwitchMode.Name = "bSwitchMode";
            this.bSwitchMode.Size = new System.Drawing.Size(140, 23);
            this.bSwitchMode.TabIndex = 1;
            this.bSwitchMode.Text = "Switch Mode";
            this.bSwitchMode.UseVisualStyleBackColor = true;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 809);
            this.Controls.Add(this.bSwitchMode);
            this.Controls.Add(this.calendarControl1);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar_Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.Button bSwitchMode;
    }
}

