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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            DayClass _currentSelectedDay = new DayClass();
            InitializeComponent();
            
            //Get current screen resolution and adjust size of window to fit in screen resolution
            Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            Size winSize = new Size();
            winSize.Height = resolution.Height;
            winSize.Width = resolution.Width / 2;
            this.Size = winSize;

            //Get current date and convert it to a DayClass
            _currentSelectedDay = _currentSelectedDay.SetDateFromDateTime(System.DateTime.Now);
            
        }
    }
}
