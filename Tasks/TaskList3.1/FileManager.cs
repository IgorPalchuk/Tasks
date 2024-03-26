using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._1
{
    public class FileManager
    {
       public static void Copy(string source, string destination)
        {
            try
            {
                FileManager.Copy(source, destination);
            }
            catch (OutOfMemoryException ex)
            {
                throw new OutOfMemoryException(ex.Message);
            }
            catch(UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException(ex.Message);
            }

        }
    }
}
