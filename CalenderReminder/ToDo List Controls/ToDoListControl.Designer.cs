namespace CalenderReminder.ToDo_List_Controls
{
    partial class ToDoListControl
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
            this.lTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bAddNewItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Location = new System.Drawing.Point(38, 40);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(62, 23);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "To Do:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(41, 67);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(504, 513);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // bAddNewItem
            // 
            this.bAddNewItem.Location = new System.Drawing.Point(628, 40);
            this.bAddNewItem.Name = "bAddNewItem";
            this.bAddNewItem.Size = new System.Drawing.Size(140, 23);
            this.bAddNewItem.TabIndex = 2;
            this.bAddNewItem.Text = "Add New";
            this.bAddNewItem.UseVisualStyleBackColor = true;
            // 
            // ToDoListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bAddNewItem);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lTitle);
            this.Name = "ToDoListControl";
            this.Size = new System.Drawing.Size(817, 611);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bAddNewItem;
    }
}
