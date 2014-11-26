using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderReminder
{
    public partial class AddNewEventForm : Form
    {
        public AddNewEventForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            ToDoItem newItem = new ToDoItem();
            if (txtTitle.Text != String.Empty)
                newItem.Title = txtTitle.Text;
            Globals.g_ToDoArrayList.Add(newItem);
            this.Close();
        }
    }
}
