using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ZipAndUnzipFolder
{
public class Class1
    {
        public static void Main()
        {


            Console.WriteLine("Type 1 to zip, 2 to unZip"); // or Console.Write("Type any number:  "); to enter number in the same line
            int zip_or_unzip = Int32.Parse(Console.ReadLine());
            
            if (zip_or_unzip == 1) {
                try
                {
                    Console.WriteLine("Type the path to the directory to zip"); 
                    string source_folder = @Console.ReadLine();
                    string target_zip_file = source_folder+".zip";
                    ZipFile.CreateFromDirectory(source_folder, target_zip_file);
                    Console.WriteLine("Done");
                }
                catch
                {
                    Console.WriteLine("error");
                }
            }
            if (zip_or_unzip == 2)
            {
                try
                {
                    Console.WriteLine("Type the path to zip file"); 
                    string source_zip_file = @Console.ReadLine();
 
                    string target_folder = source_zip_file.Substring(0,source_zip_file.Length -4);
                    Console.WriteLine(target_folder);
                    ZipFile.ExtractToDirectory(source_zip_file, target_folder);
                    Console.WriteLine("Done");
                }
                catch
                {
                    Console.WriteLine("error");
                }
            }
        } 
    }
}