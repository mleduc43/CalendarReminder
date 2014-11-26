using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalenderReminder
{
    class XMLHelper
    {
        private static string toDoXMLFileName = "Test.xml";
        private static string GetUserDocumentsFolder()
        {
            Environment.SpecialFolder myDocs = Environment.SpecialFolder.MyDocuments;
            return myDocs.ToString();
        }
        
        public static void ReadFrom_ToDoXML()
        {

        }

        /// <summary>
        /// Writes the ToDo items to an XML document to be saved by the software
        /// TODO: Figure out how to change file location
        /// </summary>
        public static void WriteTo_ToDoXML()
        {
            ToDoItem[] toDoItems = (ToDoItem[])Globals.g_ToDoArrayList.ToArray(typeof(ToDoItem));
            XDocument toDoXML = new XDocument();
            string myDocs = GetUserDocumentsFolder();

            //Create object for XElements to add to XML doc
            List<XElement> toDoXElements = new List<XElement>();
            for (int i = 0; i < toDoItems.Count(); i++)
            {
                toDoXElements.Add(
                    new XElement("Item" + i.ToString(), 
                    new XElement("Title", toDoItems[i].Title.Replace(' ', '_').ToString()),
                    new XElement("IsComplete", toDoItems[i].IsComplete.ToString())
                    )
                );
                //Convert title to contain underscores instead of spaces
                //toDoXElements.Add(new XElement("Title", toDoItems[i].Title.Replace(' ', '_').ToString()));
            }

            toDoXML.Add(new XElement("ToDoItems", toDoXElements));

            toDoXML.Save(toDoXMLFileName);
        }
    }
}
