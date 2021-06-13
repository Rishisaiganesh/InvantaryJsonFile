using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace json
{
    public class Details
    {

        public void GetData()
        {
            var json = File.ReadAllText(@"C:\Users\naren\source\Json\json\json\json1.json");
            var jObject = JObject.Parse(json);
            var ProdectsArray = (JArray)jObject["Prodects"];
            if (jObject != null)
            {
                Console.WriteLine("Prodects");
                foreach (var item in ProdectsArray)
                {
                    Console.WriteLine($"Name:" + (item["Name"]));
                    Console.WriteLine($"Weight:" + (item["Weight"]));
                    Console.WriteLine($"price:" + (item["Price_per_kg"]));
                    Price(item["Weight"], item["Price_per_kg"]);
                    Console.WriteLine();
                }
            }

        }
        public void Price(JToken Weight, JToken Price_per_kg)
        {
            int weight = Weight.ToObject<int>();
            int price = Price_per_kg.ToObject<int>();
            int total = weight * price;
            Console.WriteLine("Total value of the iteam is" + total);
        }
    }

        
    
}
