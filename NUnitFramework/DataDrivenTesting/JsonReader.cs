using Newtonsoft.Json.Linq;
using System.IO;

namespace CsharpFramework.Utilities
{

    public class JsonReader
    {
        public string extractData()
        {
            string jsondata = File.ReadAllText("Utilities/testData.json");
            var jsonObject = JToken.Parse(jsondata);
            return jsonObject.SelectToken("password").Value<string>();
        }

    }


}
