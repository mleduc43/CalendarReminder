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
            this.SuspendLayout();
            // 
            // bComplete
            // 
            this.bComplete.Location = new System.Drawing.Point(392, 3);
            this.bComplete.Name = "bComplete";
            this.bComplete.Size = new System.Drawing.Size(42, 23);
            this.bComplete.TabIndex = 0;
            this.bComplete.Text = "Done";
            this.bComplete.UseVisualStyleBackColor = true;
            // 
            // lToDoTitle
            // 
            this.lToDoTitle.Location = new System.Drawing.Point(3, 3);
            this.lToDoTitle.Name = "lToDoTitle";
            this.lToDoTitle.Size = new System.Drawing.Size(383, 23);
            this.lToDoTitle.TabIndex = 1;
            this.lToDoTitle.Text = "label1";
            this.lToDoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToDoItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lToDoTitle);
            this.Controls.Add(this.bComplete);
            this.Name = "ToDoItemControl";
            this.Size = new System.Drawing.Size(437, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bComplete;
        private System.Windows.Forms.Label lToDoTitle;
    }
}
