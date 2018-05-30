using Newtonsoft.Json;
using PSSkeleton.pageobjects.WebPage;
using System.IO;

namespace PSSkeleton.utils
{
    class JsonUtils
    {
        public static T ParseJson<T>(string json)
        {
            using (StreamReader file = File.OpenText(json))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (T)serializer.Deserialize(file, typeof(T));
            }
        }
    }
}
