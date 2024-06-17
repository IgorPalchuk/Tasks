using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2._2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            try
            {
                string result = await FetchDataFromApi(url);
                DisplayResults(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static async Task<string> FetchDataFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return content;
            }

        }
        static void DisplayResults(string result)
        {
            JArray jsonArray = JArray.Parse(result);
            foreach (JObject json in jsonArray)
            {
                Console.WriteLine("Post Details:");
                Console.WriteLine($"ID: {json["id"]}");
                Console.WriteLine($"Title: {json["title"]}");
                Console.WriteLine($"Body: {json["body"]}");
                Console.WriteLine();
            }
        }
    }
}
