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
            //Find out how to populate CategoryList
            cbCategory.DataSource = Globals.g_Categories;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            ToDoItem newItem = new ToDoItem();
            if (txtTitle.Text != String.Empty)
                newItem.Title = txtTitle.Text;
            if (cbCategory.Text != String.Empty)
                newItem.Category = cbCategory.Text;

            Globals.g_ToDoArrayList.Add(newItem);
            this.Close();
        }
    }
}
