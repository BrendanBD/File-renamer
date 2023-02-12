using System;
using System.IO;

namespace FileRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a folder containing PNG or DDS files to rename:");

            string folderPath = Console.ReadLine();

            string[] fileNames = Directory.GetFiles(folderPath);

            foreach (string fileName in fileNames)
            {
                string fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".png" || fileExtension == ".dds")
                {
                    string newFileName = "File" + Path.GetFileName(fileName);
                    string newFilePath = Path.Combine(Path.GetDirectoryName(fileName), newFileName);
                    File.Move(fileName, newFilePath);
                }
            }

            Console.WriteLine("Files renamed successfully!");
            Console.ReadLine();
        }
    }
}

