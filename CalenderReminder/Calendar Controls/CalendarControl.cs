using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalenderReminder.Calendar_Controls
{
    public partial class CalendarControl : UserControl
    {
        DayClass _currentSelectedDay = new DayClass();
        public CalendarControl()
        {
            InitializeComponent();
            //TODO: Figure out how to properly populate the Day Controls 
        }

        /// <summary>
        /// Updates the currently selected date
        /// </summary>
        /// <param name="d">The currently selected day, will usually be the current date</param>
        public void UpdateCurrentDate(DayClass d)
        {
            _currentSelectedDay = d;
            lSelectedMonthYear.Text = _currentSelectedDay.GetMonthAsString() + " - " + _currentSelectedDay.Year.ToString();
        }

        private void bPrevMonth_Click(object sender, EventArgs e)
        {
            _currentSelectedDay.Month--;
            lSelectedMonthYear.Text = _currentSelectedDay.GetMonthAsString() + " - " + _currentSelectedDay.Year.ToString();
            UpdateCalendarMonth();
        }

        private void bNextMonth_Click(object sender, EventArgs e)
        {
            _currentSelectedDay.Month++;
            lSelectedMonthYear.Text = _currentSelectedDay.GetMonthAsString() + " - " + _currentSelectedDay.Year.ToString();
            UpdateCalendarMonth();
        }

        public void UpdateCalendarMonth()
        {
        }
    }
}
