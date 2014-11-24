using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public CalendarControl(DayClass d)
            : this()
        {
            _currentSelectedDay = d;
        }

        private void bPrevMonth_Click(object sender, EventArgs e)
        {
            _currentSelectedDay.Month--;
            lSelectedMonthYear.Text = _currentSelectedDay.GetMonthAsString() + " - " + _currentSelectedDay.Year.ToString();
        }

        private void bNextMonth_Click(object sender, EventArgs e)
        {
            _currentSelectedDay.Month++;
            lSelectedMonthYear.Text = _currentSelectedDay.GetMonthAsString() + " - " + _currentSelectedDay.Year.ToString();
        }

        public void UpdateCalendarDays()
        {

        }
    }
}
