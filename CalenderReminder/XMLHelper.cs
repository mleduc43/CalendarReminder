using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalenderReminder
{
    class XMLHelper
    {
        private static string toDoXMLFileName = "To_Do.xml";
        private static string settingsXMLFileName = "settings.xml";

        /// <summary>
        /// Get currents user's "My Documents" folder
        /// This does not curently work as intended.
        /// </summary>
        /// <returns></returns>
        private static string GetUserDocumentsFolder()
        {
            Environment.SpecialFolder myDocs = Environment.SpecialFolder.MyDocuments;
            return myDocs.ToString();
        }

        #region To Do XML Operations
        /// <summary>
        /// Reads from the XML file and populates the global class of to do items
        /// </summary>
        public static void ReadFrom_ToDoXML()
        {
            XDocument toDoXml = XDocument.Load(toDoXMLFileName);
            var q = from a in toDoXml.Descendants("ToDoItem")
                    select new ToDoItem
                {
                    Title = a.Element("Title").Value,
                    IsComplete = (bool)a.Element("IsComplete"),
                    Recurrance = (int)a.Element("Recurrance"),
                    Category = a.Element("Category").Value
                };

            foreach (ToDoItem t in q)
            {
                Globals.g_ToDoArrayList.Add(t);
            }
        }

        /// <summary>
        /// Writes the ToDo items to an XML document to be saved by the software
        /// TODO: Figure out how to change file location
        /// </summary>
        public static void WriteTo_ToDoXML()
        {
            ToDoItem[] toDoItems = (ToDoItem[])Globals.g_ToDoArrayList.ToArray(typeof(ToDoItem));
            XDocument toDoXML = new XDocument();

            //Create object for XElements to add to XML doc
            List<XElement> toDoXElements = new List<XElement>();
            for (int i = 0; i < toDoItems.Count(); i++)
            {
                toDoXElements.Add(
                    new XElement("ToDoItem", 
                    new XElement("Title", toDoItems[i].Title.ToString()),
                    new XElement("IsComplete", toDoItems[i].IsComplete.ToString()),
                    new XElement("Recurrance", toDoItems[i].Recurrance.ToString()),
                    new XElement("Category", toDoItems[i].Category.ToString())
                    )
                );
            }

            toDoXML.Add(new XElement("ToDoItems", toDoXElements));

            toDoXML.Save(toDoXMLFileName);
        }
        #endregion

        #region Settings XML Operations
        /// <summary>
        /// Populates the settings dictionary and the categories list
        /// </summary>
        public static void ReadFrom_SettingsXML()
        {
            XDocument toDoXml = XDocument.Load(settingsXMLFileName);

            //Populate the categories list
            var q = from a in toDoXml.Descendants("Categories")
                    select new 
                    {
                       category = (string)a.Element("Category")
                    };

            foreach (object cat in q)
            {
                string s = cat.ToString();
                Globals.g_Categories.Add(s);
            }
        }

        public static void WriteTo_SettingsXML()
        {
            //Write categories to settings XML file
            List<string> categories = Globals.g_Categories;
            XDocument toDoXML = new XDocument();

            //Create object for XElements to add to XML doc
            List<XElement> categoriesXElements = new List<XElement>();
            foreach (string category in categories)
            {
                categoriesXElements.Add(
                    new XElement("Category", category)
                );
            }

            toDoXML.Add(new XElement("Categories", categoriesXElements));

            toDoXML.Save(settingsXMLFileName);
        }
        #endregion
    }
}
