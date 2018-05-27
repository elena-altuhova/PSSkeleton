using System;
using System.IO;
using System.Reflection;

namespace PSSkeleton.utils
{
    public class PathUtils
    {
        public static string GetPath(string path)
        {
            string fullPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\" + path);
            if (string.IsNullOrEmpty(Path.GetFullPath(fullPath)))
            {
                throw new Exception($"{path} is not a valid path. Please specify correct one.");
            }
            return fullPath;
        }
    }
}
