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
            }
        }

        public static void WriteTo_SettingsXML()
        {
            /*
            //Write categories to settings XML file
            XDocument toDoXML = new XDocument();

            //Create object for XElements to add to XML doc
            List<XElement> categoriesXElements = new List<XElement>();
            var categories;
            foreach (string category in categories)
            {
                categoriesXElements.Add(
                    new XElement("Category", category)
                );
            }

            toDoXML.Add(new XElement("Categories", categoriesXElements));

            toDoXML.Save(settingsXMLFileName);
             * */
        }
        #endregion
    }
}
