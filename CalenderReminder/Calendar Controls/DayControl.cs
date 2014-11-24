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
    public partial class DayControl : UserControl
    {
        public DayControl()
        {
            InitializeComponent();
        }

        public DayControl(int day, int dayNum): this()
        {
            string dayInfo = day + " " + dayNum.ToString();
        }
    }
}
