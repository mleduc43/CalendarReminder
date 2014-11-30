using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CalenderReminder.ToDo_List_Controls
{
    public partial class ToDoListControl : UserControl
    {
        private int showCompleted;
        public ToDoListControl()
        {
            showCompleted = 0;
            InitializeComponent();
            PopulateToDoItems(showCompleted);
        }
        
        private void bAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewEventForm newEventForm = new AddNewEventForm();
            newEventForm.FormClosed += newEventForm_FormClosed;
            newEventForm.Show();
        }

        private void newEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateToDoItems(0);
        }

        

        private void PopulateToDoItems(int completed)
        {
            flowLayoutPanel.Controls.Clear();

            //Get list of all todo items to convert to controls
            ToDoItemEntity[] toDoItems = (ToDoItemEntity[])Globals.g_ToDoArrayList.ToArray(typeof(ToDoItemEntity));

            //Convert todo entities to todo controls and add them to the flow panel 
            for (int i = 0; i < toDoItems.Length; i++)
            {
                if (toDoItems[i].IsComplete == completed)
                {
                    ToDoItemControl t = new ToDoItemControl(toDoItems[i]);
                    flowLayoutPanel.Controls.Add(t);
                }
            }
        }

        private void bViewCompleted_Click(object sender, EventArgs e)
        {
            if (showCompleted == 0)
            {
                PopulateToDoItems(1);
                lTitle.Text = "Completed Tasks:";
                showCompleted = 1;
            }
            else
            {
                PopulateToDoItems(0);
                lTitle.Text = "To Do Tasks:";
                showCompleted = 0;
            }
        }
    }
}
