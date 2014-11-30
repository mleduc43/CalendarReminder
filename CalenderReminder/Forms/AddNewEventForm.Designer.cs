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
            this.lCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(200, 245);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(133, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add New Event";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(89, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(450, 20);
            this.txtTitle.TabIndex = 0;
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
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(13, 38);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(52, 13);
            this.lCategory.TabIndex = 5;
            this.lCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(89, 35);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(168, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(12, 65);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(63, 13);
            this.lDescription.TabIndex = 6;
            this.lDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 75);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // AddNewEventForm
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 280);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lCategory);
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
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}