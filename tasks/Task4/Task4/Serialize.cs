using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class Serialize
    {
        public void PrintJason(Burger burger)
        {
            Burger x = burger;

            // 1. serialize a single book to a JSON string
            Console.WriteLine(JsonConvert.SerializeObject(burger));

            // 2. ... with nicer formatting
            Console.WriteLine(JsonConvert.SerializeObject(burger, Formatting.Indented));

            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(burger, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(burger, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "burger.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Burger>(textFromFile, settings);
        }
    }
}
