using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using YamlDotNet.Serialization;
using Gherkin.CucumberMessages.Types;

namespace IDESdemo1.Utilities
{
    internal class AddProductPageContentLoader
    {
        public static Dictionary<string, Dictionary<string, AddProductPageContent>> Load(string filePath)
        {
            var yaml = File.ReadAllText("AddProductPageContent");
            var deserializer = new DeserializerBuilder().Build();
            return deserializer.Deserialize<Dictionary<string, Dictionary<string, AddProductPageContent>>>(yaml);
        }
    }
}
