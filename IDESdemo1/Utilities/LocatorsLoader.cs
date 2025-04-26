using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YamlDotNet.Serialization;

namespace IDESdemo1.Utilities
{
    internal class AddProductPageContent
    {
        public string? NameErrorMessage { get; set; }  
        public string? PriceErrorMessage { get; set; } 
        public string? DateErrorMessage { get; set; } 
        public static Dictionary<string, Dictionary<string, AddProductPageContent>> Load(string filePath)
        {
            var yaml = File.ReadAllText(filePath);
            var deserializer = new DeserializerBuilder().Build();
            return deserializer.Deserialize<Dictionary<string, Dictionary<string, AddProductPageContent>>>(yaml);
        }
    }

}
