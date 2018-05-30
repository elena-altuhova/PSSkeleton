using Newtonsoft.Json;
using System;
using System.IO;

namespace PSSkeleton.utils
{
    public class PathUtils
    {
        private static dynamic config = JsonConvert.DeserializeObject(File.ReadAllText(PathUtils.GetPath(@"config\config.json")));
        public static string GetPath(string path)
        {
            string fullPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\" + path);
            if (string.IsNullOrEmpty(Path.GetFullPath(fullPath)))
            {
                throw new Exception($"{path} is not a valid path. Please specify correct one.");
            }
            return fullPath;
        }

        public static string GetDrivers()
        {
            string relativePath = config.framework.drivers;
            return GetPath(relativePath);
        }

        public static string GetPageObject(string json)
        {
            string relativePath =  config.framework.pages + json + ".json";
            return GetPath(relativePath);
        }

        public static string GetModule(string json)
        {
            string relativePath = config.framework.modules + json + ".json";
            return GetPath(relativePath);
        }
    }
}
