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
            
            //Populate the list of available categories
            List<string> categoriesList = new List<string>();
            using (var db = new CalendarToDoContext())
            {
                categoriesList = db.CategoryEntities.Select(a => a.category).ToList();
            }
            cbCategory.DataSource = categoriesList;
        }
        
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateTextbox(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title that is not empty.");
            }
            else
            {
                ToDoItemEntity newItem = new ToDoItemEntity();
                newItem.id = Guid.NewGuid();
                newItem.title = txtTitle.Text;
                newItem.category = cbCategory.Text;
                newItem.description = txtDescription.Text;
                newItem.created_on = DateTime.Now;

                bool categoryAlreadyExists = false;
                //Check to see if category is already in database
                using (var db = new CalendarToDoContext())
                {
                    categoryAlreadyExists = db.CategoryEntities.Any(a => a.category == cbCategory.Text);

                    //If category does not exist, add it to database
                    if (!categoryAlreadyExists)
                    {
                        CategoryEntity ce = new CategoryEntity();
                        ce.category = cbCategory.Text;
                        ce.created_on = DateTime.Now;
                        db.CategoryEntities.Add(ce);
                    }

                    db.ToDoItemEntities.Add(newItem);
                    db.SaveChanges();
                }

                DBHelper.PopulateToDoItems();
                this.Close();
            }
        }

        private bool ValidateTextbox(string text)
        {
            if (text.Trim() == string.Empty)
                return false;
            else
                return true;
        }
    }
}
