using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ets2mplauncher.Kharenis
{
    class ConfigFile
    {
        private string filename;
        private List<string> configData = new List<string>();
        private Dictionary<int, Setting> EditableSettings = new Dictionary<int, Setting>();
        public bool IsLoaded = false;
        public ConfigFile(string root)
        {
            this.filename = string.Format(@"{0}\config.cfg", root);
        }

        public bool LoadFile()
        {
            if (File.Exists(filename)) //if the file exists then read it, else return false
            {
                StreamReader file = new StreamReader(filename);
                string line = "";
                while((line = file.ReadLine()) != null)
                {
                    configData.Add(line);
                    if(line.Contains("uset")) //If the line is a value, parse the line
                    {
                        line = line.Remove(0, 5);
                        Setting newSetting = new Setting();
                        newSetting.Name = line.Substring(0, line.IndexOf(' '));
                        line = line.Remove(0, line.IndexOf('"') + 1);
                        newSetting.Value = line.Substring(0, line.IndexOf('"'));
                        EditableSettings.Add(configData.Count - 1, newSetting);
                    }
                }

                file.Close();
                IsLoaded = true;

            }
            else
                return false;

            return true;
        }

        public bool SaveFile()
        {
            if (File.Exists(filename))
            {
                foreach(KeyValuePair<int, Setting> entry in EditableSettings)
                {
                    configData[entry.Key] = entry.Value.ToString();
                }

                StreamWriter file = new StreamWriter(filename, false);
                foreach (string line in configData)
                    file.WriteLine(line);

                file.Close();
            }
            else
                return false;

            return true;
        }

        public Setting GetSettingByName(string Name)
        {
            foreach (KeyValuePair<int, Setting> entry in EditableSettings)
            {
                if (entry.Value.Name == Name)
                    return entry.Value;
            }
            return null;
        }

        public bool GetBoolSettingByName(string Name)
        {
            Setting sett = GetSettingByName(Name);

            if(sett!=null)
            {
                return stringToBool(sett.Value);
            }

            return false;
        }

        public void SetSettingByName(string Name, string Value)
        {
            if (this.IsLoaded)
            {
                foreach (KeyValuePair<int, Setting> entry in EditableSettings)
                {
                    if (entry.Value.Name == Name)
                    {
                        entry.Value.Value = Value;
                        return;
                    }
                }
            }
            else
                MessageBox.Show("Please set config file location first!", "Error: Config file not loaded");
        }

        public void SetSettingByName(string Name, bool Value)
        {
            SetSettingByName(Name, BoolToString(Value));
        }

        private bool stringToBool(string input)
        {
            if (input == "0")
                return false;
            else
                return true;
        }

        private string BoolToString(bool input)
        {
            if (input)
                return "1";
            else
                return "0";
        }
    }

    public class Setting
    {
        public string Name;
        public string Value;

        public override string ToString()
        {
            return string.Format("uset {0} \"{1}\"", this.Name, this.Value);
        }
    }
}
