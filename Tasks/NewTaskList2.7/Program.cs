using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2._7
{
    internal class Program
    {
        static string result1;
        static string result2;
        static async Task Main(string[] args)
        {
            List<string> urls = new List<string>
            {
                "https://jsonplaceholder.typicode.com/posts/1",
                "https://jsonplaceholder.typicode.com/posts/2",
                "https://jsonplaceholder.typicode.com/posts/3"
            };

            try
            {
                List<Task<string>> tasks = new List<Task<string>>();
                foreach (string url in urls)
                {
                    tasks.Add(GetResult(url));
                }
                    
                string[] results = await Task.WhenAll(tasks);

                foreach(string result in results)
                {
                    DisplayResult(result);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static async Task<string> GetResult(string url)
            {
                using (HttpClient client = new HttpClient())
                {
                  HttpResponseMessage httpResponse =  await client.GetAsync(url);
                  string result = await httpResponse.Content.ReadAsStringAsync();
                  return result;
              
                }
            }
        static void DisplayResult(string result)
        {
            JObject json = JObject.Parse(result);
            Console.WriteLine("Post Details:");
            Console.WriteLine($"ID: {json["id"]}");
            Console.WriteLine($"Title: {json["title"]}");
            Console.WriteLine($"Body: {json["body"]}");
            Console.WriteLine();
        }

    }
    }

