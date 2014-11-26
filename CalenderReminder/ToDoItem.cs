using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderReminder
{
    public class ToDoItem
    {
        //Constructor for the ToDoItem, sets the default values in case the user forgets to set some.
        public ToDoItem()
        {
            Title = "New To Do Task";
            Recurrance = -1;
            Category = "";
            IsComplete = false;
        }

        public string Title { get; set; }
        /// <summary>
        /// The recurrance of an event.
        /// If it is set to -1 there is no recurrence
        /// If it is set to 0, it has infinite recurrence
        /// If it is > 0, there is a fixed number of recurrence
        /// </summary>
        public int Recurrance { get; set; }
        public string Category { get; set; }
        public bool IsComplete { get; set; }
    }
}
