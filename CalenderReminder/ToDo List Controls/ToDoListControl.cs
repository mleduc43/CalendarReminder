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
        public ToDoListControl()
        {
            InitializeComponent();
            PopulateToDoItems();
        }

        private void bAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewEventForm newEventForm = new AddNewEventForm();
            newEventForm.Show();
        }

        private void PopulateToDoItems()
        {
            //Get list of all todo items to convert to controls
            ToDoItem[] toDoItems = (ToDoItem[])Globals.g_ToDoArrayList.ToArray(typeof(ToDoItem));

            //Convert todo items to todo controls and add them to the flow panel 
            for (int i = 0; i < toDoItems.Length; i++)
            {
                ToDoItemControl t = new ToDoItemControl(toDoItems[i]);
                flowLayoutPanel.Controls.Add(t);
            }
        }
    }
}
