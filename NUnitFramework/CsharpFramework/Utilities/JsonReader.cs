using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CsharpFramework.Utilities
{

    public class JsonReader
    {
        public string extractData(string path)
        {
            string jsondata = File.ReadAllText("Utilities/testData.json");
            var jsonObject = JToken.Parse(jsondata);
            return jsonObject.SelectToken(path).Value<string>();

        }
        public string[] ExtractDataArray(string path)
        {
            String data = File.ReadAllText("Utilities/testData.json");
            var jsonObject = JToken.Parse(data);
            List<string> products = jsonObject.SelectTokens(path).Values<string>().ToList();
            return products.ToArray();
        }

    }


}
