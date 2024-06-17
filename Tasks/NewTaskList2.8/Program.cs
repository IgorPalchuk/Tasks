using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2._8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string file = "D:\\Tasks\\Tasks\\NewTaskList2.8\\file.txt";
            string file2 = "D:\\Tasks\\Tasks\\NewTaskList2.8\\file2.txt";

            Stopwatch sw = Stopwatch.StartNew();
            await ReverseFileContentAsync(file, file2);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
        static async Task ReverseFileContentAsync(string inputFile,  string outputFile)
        {
            try
            {
                string content;
                using (StreamReader sr = new StreamReader(inputFile,Encoding.UTF8))
                {
                    content = await sr.ReadToEndAsync();
                }

                char[] contentArray = content.ToCharArray();
                Array.Reverse(contentArray);
                string reversed =  new string(contentArray);

                using (StreamWriter sw = new StreamWriter(outputFile,false,Encoding.UTF8))
                {
                    await sw.WriteAsync(reversed);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
