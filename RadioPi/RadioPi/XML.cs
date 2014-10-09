using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RadioPi
{
    public static class XML
    {
        public static Dictionary<string, Dictionary<string, string>> GetConfig(string url)
        {
            // create dictionary
            Dictionary<string, Dictionary<string,string>> result = new Dictionary<string, Dictionary<string,string>>();

            // load xml file
            XDocument doc = XDocument.Load(url);

            // extract apps
            var apps = from app in doc.Root.Elements("app")
                       select new
                       {
                           name = app.Element("name"),
                           dll = app.Element("dll"),
                           icoN = app.Element("icon-normal"),
                           icoH = app.Element("icon-highlight")
                       };

            // populate dictionary with apps
            foreach (var app in apps)
            {
                // build details dictionary
                Dictionary<string, string> details = new Dictionary<string, string>();
                details.Add("dll", app.dll.Value);
                details.Add("icoN", app.icoN.Value);
                details.Add("icoH", app.icoH.Value);

                // add to main dictionary
                result.Add(app.name.Value, details);
            }

            return result;
        }
    }
}
