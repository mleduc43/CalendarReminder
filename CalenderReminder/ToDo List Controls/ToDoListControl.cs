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
        private bool showCompleted;
        public ToDoListControl()
        {
            showCompleted = false;
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
            PopulateToDoItems(showCompleted);
        }

        private void PopulateToDoItems(bool completed)
        {
            flowLayoutPanel.Controls.Clear();

            //Get list of all todo items to convert to controls
            ToDoItem[] toDoItems = (ToDoItem[])Globals.g_ToDoArrayList.ToArray(typeof(ToDoItem));

            //Convert todo items to todo controls and add them to the flow panel 
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
            if (showCompleted)
            {
                PopulateToDoItems(!showCompleted);
                lTitle.Text = "To Do Tasks:";
                showCompleted = false;
            }
            else
            {
                PopulateToDoItems(!showCompleted);
                lTitle.Text = "Completed Tasks:";
                showCompleted = true;
            }
        }
    }
}
