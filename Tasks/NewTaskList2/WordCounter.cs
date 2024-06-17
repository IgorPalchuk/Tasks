using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2
{
    public class WordCounter
    {
        public async Task<int> CountWordsAsync(string path)
        {
            if(string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("File is empty");
            }


            try
            {
                using(StreamReader stream = new StreamReader(path))
                {
                    string text = await stream.ReadToEndAsync();
                    int count = CountWords(text);
                    return count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        private int CountWords(string text)
        {
                if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            string[] words = text.Split(new char[] { ' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Length;
            return count;

        }
    }
}
