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
        public ToDoItemControl()
        {
            InitializeComponent();
        }

        public ToDoItemControl(ToDoItem item)
            : this()
        {
            lToDoTitle.Text = item.Title;
        }
    }
}
