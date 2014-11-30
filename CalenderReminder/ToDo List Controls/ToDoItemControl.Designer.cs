namespace CalenderReminder.ToDo_List_Controls
{
    partial class ToDoItemControl
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
            this.bComplete = new System.Windows.Forms.Button();
            this.lToDoTitle = new System.Windows.Forms.Label();
            this.bExpandDescription = new System.Windows.Forms.Button();
            this.lDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(378, -1);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(56, 23);
            this.bComplete.TabIndex = 0;
            this.bComplete.Text = "Done";
            this.bComplete.UseVisualStyleBackColor = true;
            this.bComplete.Click += new System.EventHandler(this.bComplete_Click);
            // 
            // lToDoTitle
            // 
            this.lToDoTitle.Location = new System.Drawing.Point(3, 0);
            this.lToDoTitle.Name = "lToDoTitle";
            this.lToDoTitle.Size = new System.Drawing.Size(369, 15);
            this.lToDoTitle.TabIndex = 1;
            this.lToDoTitle.Text = "Title";
            // 
            // bExpandDescription
            // 
            this.bExpandDescription.Location = new System.Drawing.Point(4, 19);
            this.bExpandDescription.Name = "bExpandDescription";
            this.bExpandDescription.Size = new System.Drawing.Size(109, 23);
            this.bExpandDescription.TabIndex = 2;
            this.bExpandDescription.Text = "Expand Description";
            this.bExpandDescription.UseVisualStyleBackColor = true;
            this.bExpandDescription.Click += new System.EventHandler(this.bExpandDescription_Click);
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(6, 49);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(0, 13);
            this.lDescription.TabIndex = 3;
            this.lDescription.Visible = false;
            // 
            // ToDoItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.bExpandDescription);
            this.Controls.Add(this.lToDoTitle);
            this.Controls.Add(this.bComplete);
            this.Name = "ToDoItemControl";
            this.Size = new System.Drawing.Size(437, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bComplete;
        private System.Windows.Forms.Label lToDoTitle;
        private System.Windows.Forms.Button bExpandDescription;
        private System.Windows.Forms.Label lDescription;
    }
}
