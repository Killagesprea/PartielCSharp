using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace PartielCSharp_XML_JSON_GIT.Models
{
    [Serializable]
    public class Log
    {
        public DateTime localDate { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }

        public Log() { }

        public Log(DateTime _localDate, String _message, String _level)
        {
            localDate = _localDate;
            Message = _message;
            Level = _level;
        }

        public override string ToString()
        {
            return $"[{localDate.ToString()}] - Niveau : {Level} – message : {Message}";
        }


        public static void SaveJSON(Object Log)
        {
            if (File.Exists("data.json"))
            {
                var json = JsonConvert.SerializeObject(data);
                var data = JsonConvert.DeserializeObject<List<Log>>("");

                foreach (var item in data)
                {
                }

                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\JSON et XML folder\data.json", json);
            }
            else
            {
                var data = 
                var json = JsonConvert.SerializeObject(data);

                Console.WriteLine("data.json doesn't exist, creation et sauvegarde..");

                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\JSON et XML folder\data.json", json);

            }
            
        }

        public static void ConvertJSONtoXMLAndSave()
        {
            var json = File.ReadAllText("data.json");
            if (File.Exists("data.json"))
            {
                System.Xml.XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(json);
                System.Xml.XmlTextWriter xmlTextWriter = new System.Xml.XmlTextWriter("json.xml", null);
                xmlTextWriter.Formatting = System.Xml.Formatting.Indented;
                xmlDocument.Save(xmlTextWriter);
            }
            else
            {
                Console.WriteLine("data.json doesn't exist, can't convert into XML");
            }
        }

        public static void ShowLogs()
        {

        }
    }
}
