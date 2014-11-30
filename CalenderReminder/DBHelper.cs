using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderReminder
{
    public static class DBHelper
    {
        public static void PopulateToDoItems()
        {
            Globals.g_ToDoArrayList.Clear();
            using (var db = new CalendarToDoContext())
            {
                foreach (ToDoItemEntity t in db.ToDoItemEntities)
                    if (!Globals.g_ToDoArrayList.Contains(t))
                        Globals.g_ToDoArrayList.Add(t);
            }
        }
    }
}
