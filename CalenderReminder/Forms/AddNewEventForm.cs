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
            using (var db = new CategoriesContext())
            {
                categoriesList = db.CategoryEntities.Select(a => a.category).ToList();
            }
            cbCategory.DataSource = categoriesList;
        }

        //REWORK THIS TO WORK WITH NEW DB
        private void bAdd_Click(object sender, EventArgs e)
        {
            ToDoItem newItem = new ToDoItem();
            if (txtTitle.Text != String.Empty)
                newItem.Title = txtTitle.Text;

            bool categoryAlreadyExists = false;
            //Check to see if category is already in database
            using (var db = new CategoriesContext())
            {
                categoryAlreadyExists = db.CategoryEntities.Any(a => a.category == cbCategory.Text);

                //If it does not exist, add it to database
                if (!categoryAlreadyExists)
                {
                    CategoryEntity ce = new CategoryEntity();
                    ce.category = cbCategory.Text;
                    ce.created_on = DateTime.Now;
                    db.CategoryEntities.Add(ce);
                    db.SaveChanges();
                }
            }

            if (cbCategory.Text != String.Empty)
                newItem.Category = cbCategory.Text;

            this.Close();
        }
    }
}
