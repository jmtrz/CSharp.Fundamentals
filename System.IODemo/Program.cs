using System;
using System.IO;

namespace System.IODemo
{
    class Program
    {
        //File and File Info
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\mufile.jpg", true);

            File.Delete(path);
            if (File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);

            //No Security Checking
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //
            }
            
        }

        public void DirectoryInfoDemo()
        {
            Directory.CreateDirectory(@"c:\temp\folder");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals","*.*",SearchOption.AllDirectories);
            foreach (var item in files)
                Console.WriteLine(item);

            var directories = Directory.GetDirectories(@"c:\projects\csharpfundamentals","*.*",SearchOption.AllDirectories);
            foreach (var item in directories)
                Console.WriteLine(item);

            Directory.Exists("..");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }

        public void PathDemo()
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
