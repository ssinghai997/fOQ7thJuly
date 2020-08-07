using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConFileHandling
{
   
    class FileMethodsExplore
    {
        FileStream fs;
        
        
        static void Main()
        {
            
            //FileStream fs = File.Create("fileNew.txt");
            Console.WriteLine("New File is created");
            File.WriteAllText("fileText.txt", "This is the demo of Write ALl Text");
            Console.WriteLine("Text is appended");
            File.AppendAllText("fileText.txt", "Now I have appended the text to the existing text file");
            Console.WriteLine("All text has been read");
            File.ReadAllText("fileText.txt");
            Console.WriteLine("copying text from 'filetext' to 'fileText2'");
            //File.Copy("fileText.txt", "fileText2.txt");
            Console.WriteLine("fileText1 id deleted");
            File.Delete("fileText1.txt");

            Console.WriteLine("Moving the file from bin>debug to new folder");
            File.Move(@"D:\file3.txt", @"E:\fileTest\");

            //File Exists Method I

            bool b = File.Exists("fileNew.txt");
            if (b)
            {
                Console.WriteLine("file exists");
            }
            else
            {
                Console.WriteLine("file does not exist.");
            }

            //File Exists Method II

            
            Console.WriteLine(File.Exists("file8.txt") ? "File exists." : "File does not exist.");


            



        }
    }
}
