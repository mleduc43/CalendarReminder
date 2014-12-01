namespace CalenderReminder
{
    partial class MainForm
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
            this.bSwitchMode = new System.Windows.Forms.Button();
            this.activePanel = new System.Windows.Forms.Panel();
            this.bOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSwitchMode
            // 
            this.bSwitchMode.Location = new System.Drawing.Point(13, 13);
            this.bSwitchMode.Name = "bSwitchMode";
            this.bSwitchMode.Size = new System.Drawing.Size(140, 23);
            this.bSwitchMode.TabIndex = 1;
            this.bSwitchMode.Text = "Switch Mode";
            this.bSwitchMode.UseVisualStyleBackColor = true;
            this.bSwitchMode.Click += new System.EventHandler(this.bSwitchMode_Click);
            // 
            // activePanel
            // 
            this.activePanel.Location = new System.Drawing.Point(3, 51);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(937, 757);
            this.activePanel.TabIndex = 2;
            // 
            // bOptions
            // 
            this.bOptions.Location = new System.Drawing.Point(854, 12);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(75, 23);
            this.bOptions.TabIndex = 3;
            this.bOptions.Text = "Options";
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 809);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.bSwitchMode);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSwitchMode;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button bOptions;
    }
}

