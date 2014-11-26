namespace CalenderReminder
{
    partial class AddNewEventForm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lRecurrence = new System.Windows.Forms.Label();
            this.txtRecurrence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(209, 142);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(133, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add New Event";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(49, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(490, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(13, 12);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(30, 13);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Title:";
            // 
            // lRecurrence
            // 
            this.lRecurrence.AutoSize = true;
            this.lRecurrence.Location = new System.Drawing.Point(16, 38);
            this.lRecurrence.Name = "lRecurrence";
            this.lRecurrence.Size = new System.Drawing.Size(66, 13);
            this.lRecurrence.TabIndex = 3;
            this.lRecurrence.Text = "Recurrence:";
            // 
            // txtRecurrence
            // 
            this.txtRecurrence.Location = new System.Drawing.Point(89, 39);
            this.txtRecurrence.Name = "txtRecurrence";
            this.txtRecurrence.Size = new System.Drawing.Size(49, 20);
            this.txtRecurrence.TabIndex = 4;
            // 
            // AddNewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 177);
            this.Controls.Add(this.txtRecurrence);
            this.Controls.Add(this.lRecurrence);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.bAdd);
            this.Name = "AddNewEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lRecurrence;
        private System.Windows.Forms.TextBox txtRecurrence;
    }
}