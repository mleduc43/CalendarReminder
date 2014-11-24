using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderReminder
{
    class DayClass
    {
        public int Day { get; set; }
        public string Weekday { get; set; }
        public int Year { get; set; }
        private int _month;

        public int Month 
        {
            get
            {
                return _month;
            }
            set
            {
                if (value > 12)
                {
                    _month = 1;
                    Year++;
                }
                else if (value < 1)
                {
                    _month = 12;
                    Year--;
                }
                else
                    _month = value;
            }
        }
        

        /// <summary>
        /// Set the date as a DayClass when given a DateTime
        /// </summary>
        /// <param name="dt">The DateTime to convert into a DayClass</param>
        /// <returns>A DayClass that has been converted from a DateTime</returns>
        public DayClass SetDateFromDateTime(DateTime dt)
        {
            DayClass dc = new DayClass();
            string date = dt.ToString("yyyy-MM-dd");
            string[] sDate;

            sDate = date.Split('-');
            dc.Year = Int32.Parse(sDate[0]);
            dc.Month = Int32.Parse(sDate[1]);
            dc.Day = Int32.Parse(sDate[2]);

            return dc;
        }

        /// <summary>
        /// Converts the current month into a string
        /// </summary>
        /// <returns>Current month as a string</returns>
        public string GetMonthAsString()
        {
            switch (this.Month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default: 
                    return "Could not convert: " + this.Month.ToString();
            }
        }
    }
}
