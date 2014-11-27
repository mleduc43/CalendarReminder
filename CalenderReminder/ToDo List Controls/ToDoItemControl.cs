using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderReminder.ToDo_List_Controls
{
    public partial class ToDoItemControl : UserControl
    {
        private ToDoItem _toDoItem;
        public ToDoItemControl()
        {
            InitializeComponent();
        }

        public ToDoItemControl(ToDoItem item)
            : this()
        {
            _toDoItem = item;
            lToDoTitle.Text = _toDoItem.Title;
            if (_toDoItem.IsComplete)
                bComplete.Text = "Return";
            else
                bComplete.Text = "Done";
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            if (!_toDoItem.IsComplete)
            {
                _toDoItem.IsComplete = true;
                bComplete.Text = "Return";
            }
            else
            {
                _toDoItem.IsComplete = false;
                bComplete.Text = "Done";
            }
        }
    }
}
