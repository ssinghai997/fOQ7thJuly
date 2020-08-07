using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConFileHandling
{
    class FileUtilityClasses
    {
        static void Main()
        {
            //FileStream fs = new FileStream(@"C:\Users\WIN10\OneDrive\Documents\july27th.txt", FileMode.Create,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("We have created our first file using filestream ");
            //sw.WriteLine("FileStream is an utility class of Input Output namespace");
            //sw.WriteLine("FileStream inherits from the abstract class Stream");
            //sw.Close();
            //fs.Close();
            //Console.WriteLine("Data written in the file");
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                new FileStream(@"D:\file2.txt", FileMode.Open, FileAccess.Read);
                new StreamWriter(fs);
                sw.WriteLine("We have created our first file using filestream ");
                sw.WriteLine("FileStream is an utility class of Input Output namespace");
                sw.WriteLine("FileStream inherits from the abstract class Stream");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            finally
            {
                Console.WriteLine("data written");
                sw.Close();
                fs.Close();
                
            }

            Console.Read();
        }
    }
}
