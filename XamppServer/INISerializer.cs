using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace INISerializer
{
    public static class INISerializer
    {
        public static string SerializeObject(object obj, string section = null)
        {
            return (obj == null) ? null : buildIniString(getPropertiesInfo(obj), section ?? obj.ToString());
        }
        private static Dictionary<string, string> getPropertiesInfo(object obj)
        {
            Dictionary<string, string> _propertyDict = new Dictionary<string, string>();
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var prop in properties)
            {
                _propertyDict.Add(prop.Name, prop.GetValue(obj, null).ToString());
            }
            return _propertyDict;
        }
        private static string buildIniString(Dictionary<string, string> props, string section)
        {
            string iniString = String.Empty;
            iniString += "[" + section + "]\n";
            foreach (var currentProp in props)
            {
                iniString += currentProp.Key + "=" + currentProp.Value + "\n";
            }
            iniString += "";
            return iniString;
        }
        public static Object deserializeObject(string path)
        {
            if (!isValid(path))
            {
                return null;
            }

            return null;
        }
        private static bool isValid(string path)
        {
            return File.Exists(path);
        }
        private static object buildObject(string path)
        {
            string line = String.Empty;
            string section = String.Empty;
            string pattern = @"\[(.*?)\]";
            int fileCount = File.ReadLines(path).Count();


            StreamReader file = new StreamReader(path);
            for (int i = 0; i < fileCount; i++)
            {
                line = file.ReadLine();
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                MatchCollection matches = rgx.Matches(line);
                if (matches.Count > 0)
                {
                    section = matches[0].ToString();
                    section = section.Replace("[", string.Empty);
                    section = section.Replace("]", string.Empty);
                    /*
                    int i = line.IndexOf('>');
                    if (i >= 0) proj = line.Substring(i + 1);
                    codice = lastLine.Replace("#", string.Empty);
                    addEpsgTocmb(codice, EPSG, proj);
                     * */
                }

            }
            return null;
        }

    }
}
