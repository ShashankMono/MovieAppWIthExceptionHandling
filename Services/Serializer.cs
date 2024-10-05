using Microsoft.IdentityModel.Protocols;
using MovieAppWIthFileStructure.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieAppWIthFileStructure.Services
{
    internal class Serializer
    {
        public static string path = ConfigurationManager.AppSettings["path"];
        public static void Serialization(List<Movie> movies)
        {
            string jsonString = JsonSerializer.Serialize(movies);
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(jsonString);
            }
        }

        public static List<Movie> Deserialization()
        {
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Movie>>(jsonString);
            }
            return new List<Movie>();
        }
    }
}
