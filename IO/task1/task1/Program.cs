using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\MyDirectories";
            DirectoryInfo dir = new DirectoryInfo(path);
            if(!dir.Exists)
            {
                dir.Create();
            }
            string[] dirs = new string[100];
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    dirs[i] = String.Format("Folder_" + i);
                    dir.CreateSubdirectory(dirs[i]);
                }
                Console.WriteLine("Folders were created successfully! Check it and then press any key.");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                foreach (string directory in dirs)
                {
                    string delpath = String.Format(path + "\\" + directory);

                    Directory.Delete(delpath);
                }
                Console.WriteLine("Folders were deleted successfully! Check and after that press any key.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
