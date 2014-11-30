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
        private ToDoItemEntity _toDoItem;

        public ToDoItemControl()
        {
            InitializeComponent();
        }

        public ToDoItemControl(ToDoItemEntity item)
            : this()
        {
            _toDoItem = item;
            lToDoTitle.Text = _toDoItem.title;
            if (_toDoItem.IsComplete == 1)
                bComplete.Text = "Return";
            else
                bComplete.Text = "Done";
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            if (_toDoItem.IsComplete == 0)
            {
                _toDoItem.IsComplete = 1;
                bComplete.Text = "Return";
            }
            else
            {
                _toDoItem.IsComplete = 0;
                bComplete.Text = "Done";
            }

            using (var db = new CalendarToDoContext())
            {
                ToDoItemEntity td = db.ToDoItemEntities.Where(a => a.id == _toDoItem.id).First();
                td.IsComplete = _toDoItem.IsComplete;

                db.SaveChanges();
            }
        }

        private void bExpandDescription_Click(object sender, EventArgs e)
        {
            if (!lDescription.Visible)
            {
                lDescription.Visible = true;
                if (_toDoItem.description == string.Empty)
                    lDescription.Text = "No description attached to To Do item";
                else
                    lDescription.Text = _toDoItem.description;

                bExpandDescription.Text = "Hide Description";
            }
            else
            {
                lDescription.Text = String.Empty;
                lDescription.Visible = false;
                bExpandDescription.Text = "Expand Description";
            }
        }
    }
}
