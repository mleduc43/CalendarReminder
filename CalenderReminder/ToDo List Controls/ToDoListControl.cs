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
            #region Testing
            List<ToDoItemControl> toDoItemControls = new List<ToDoItemControl>();
            Globals.g_ToDoArrayList = new ArrayList();
            ToDoItem a = new ToDoItem();
            ToDoItem b = new ToDoItem();
            ToDoItem c = new ToDoItem();
            b.Title = "TEST2";
            c.Title = "New 1 and testing";
            Globals.g_ToDoArrayList.Add(a);
            Globals.g_ToDoArrayList.Add(b);
            Globals.g_ToDoArrayList.Add(c);
            ToDoItemControl i = new ToDoItemControl(a);
            ToDoItemControl o = new ToDoItemControl(b);
            ToDoItemControl p = new ToDoItemControl(c);
            ToDoItemControl l = new ToDoItemControl(a);
            toDoItemControls.Add(i);
            toDoItemControls.Add(o);
            toDoItemControls.Add(p);
            toDoItemControls.Add(l);
            #endregion

            //Add to do item controls to the flow layout panel
            foreach (ToDoItemControl tdi in toDoItemControls)
            {
                flowLayoutPanel.Controls.Add(tdi);
            }
        }
    }
}
