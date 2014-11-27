using CalenderReminder.Calendar_Controls;
using CalenderReminder.ToDo_List_Controls;
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
    public partial class MainForm : Form
    {
        // Mode dictates if user is in ToDo List mode or Calender mode
        // false = calender, true = todo list
        private bool Mode = false;
        public MainForm()
        {
            InitializeComponent();
            DayClass _currentSelectedDay = new DayClass();
            //Initialize global variables
            Globals.g_ToDoArrayList = new System.Collections.ArrayList();
            Globals.g_Categories = new List<string>();

            //Populate Global ToDoItem List
            XMLHelper.ReadFrom_ToDoXML();
            XMLHelper.ReadFrom_SettingsXML();

            //Get current screen resolution and adjust size of window to fit in screen resolution
            Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            Size winSize = new Size();
            winSize.Height = resolution.Height;
            winSize.Width = resolution.Width / 2;
            this.Size = winSize;

            //Get current date and convert it to a DayClass
            _currentSelectedDay = _currentSelectedDay.SetDateFromDateTime(System.DateTime.Now);

            //Set the calendar control to appear on startup
            CalendarControl calendar = new CalendarControl();
            activePanel.Controls.Add(calendar);
            calendar.UpdateCurrentDate(_currentSelectedDay);
        }

        //Switch the mode the user is currently in
        private void bSwitchMode_Click(object sender, EventArgs e)
        {
            if (!Mode)
            {
                this.Text = "To Do List";
                activePanel.Controls.Clear();
                ToDoListControl todo = new ToDoListControl(); 
                activePanel.Controls.Add(todo);
                Mode = true;
            }
            else
            {
                this.Text = "Calendar";
                activePanel.Controls.Clear();
                CalendarControl calendar = new CalendarControl();
                activePanel.Controls.Add(calendar);
                Mode = false;
            }
        }

        //On close, save settings to XML files
        //TODO: Figure out how to only save if things have been changed
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            XMLHelper.WriteTo_ToDoXML();
        }
    }
}
