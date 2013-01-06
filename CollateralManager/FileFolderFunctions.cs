using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollateralManager
{
    class FileFolderFunctions
    {
        public static void ProcessDirectory(string targetDirectory, Dictionary<string, List<string>> myIndexDictionary, string textFilePath)
        {
            List<string> testFilePaths = new List<string>();
            string[] folders = targetDirectory.Split('\\');
            string currentFolder = folders[folders.Count() - 1];

            // Process the list of files found in the directory. 
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                if (Path.GetExtension(fileName) == ".jpg")
                {
                    testFilePaths.Add(fileName);
                    ProcessFile(fileName);
                }
            }

            //If the current jpeg list, for the given folder is not empty, add it to your dictionary
            if (testFilePaths.Count() > 0)
            {
                //Current Folder --> List of JPEG images of shred scans within that folder
                myIndexDictionary.Add(targetDirectory, testFilePaths);
                //Create an entry to the text file with our test collateral datta
                string textLine = currentFolder.PadRight(25) + testFilePaths.Count().ToString().PadLeft(5);
                //Add a line to the text file...The extra true paramters states that we want to append text to the end
                StreamWriter collateralFile = new StreamWriter(textFilePath, true);
                collateralFile.WriteLine(textLine);
                collateralFile.Close();
            }

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, myIndexDictionary, textFilePath);
        }

        // Insert logic for processing found files here. 
        // Used as a log of what files have been processed to help with debugging
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
