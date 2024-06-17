using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            var wc = new WordCounter();
            try
            {
                int count = await wc.CountWordsAsync("D:\\Tasks\\Tasks\\NewTaskList2\\file.txt");
                Console.WriteLine(count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
