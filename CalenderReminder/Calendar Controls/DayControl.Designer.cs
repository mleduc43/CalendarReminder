namespace CalenderReminder.Calendar_Controls
{
    partial class DayControl
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
            this.lDayInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lDayInfo
            // 
            this.lDayInfo.Location = new System.Drawing.Point(3, 5);
            this.lDayInfo.Name = "lDayInfo";
            this.lDayInfo.Size = new System.Drawing.Size(195, 20);
            this.lDayInfo.TabIndex = 0;
            this.lDayInfo.Text = "lDayInfo";
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lDayInfo);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(128, 131);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lDayInfo;
    }
}
