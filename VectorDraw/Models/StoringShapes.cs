using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using VectorDraw.Models;

namespace VectorDraw.Models
{
    public static class StoringShapes
    {
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.Indented
        };

        public static void SaveToFile(string path, List<IShape> shapes)
        {
            string json = JsonConvert.SerializeObject(shapes, settings);
            File.WriteAllText(path, json);
        }

        public static List<IShape> LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new List<IShape>();
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<IShape>>(json, settings) ?? new List<IShape>();
        }
    }
}
