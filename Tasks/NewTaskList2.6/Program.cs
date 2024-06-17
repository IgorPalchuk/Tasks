using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTaskList2._6
{
    internal  class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await Exc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static async Task Exc()
        {
             await Task.Delay(5000);
            throw new InvalidOperationException("error");

        }
    }
}
