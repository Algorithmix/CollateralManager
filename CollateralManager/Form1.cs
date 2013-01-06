using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollateralManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCollateral_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //File to keep track of what test collateral we have.
                string collateralFile = @"C:\Users\Richard\Desktop\AlgorithmixProjects\Collateral\Collateral_Tracker.txt";

                //Clear the list box
                InputListBox.Items.Clear();
                //Dictionary to store test collateral from origal chosen folder
                //key -> folder, value -> list of files associated with folder
                Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

                //Dictionary to store copied directory
                //key -> folder, value -> list of files associated with folder
                Dictionary<string, List<string>> workingCollateral = new Dictionary<string, List<string>>();


                //Directory where we keep all of our test collateral
                string startingDirectory = folderBrowserDialog1.SelectedPath;
                string path = startingDirectory;
                //
                string workingDirectory = @"C:\Users\Richard\Desktop\AlgorithmixProjects\TestingFolder\Input";

                if (File.Exists(path))
                {
                    // This path is a file
                    FileFolderFunctions.ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    // Pass the path and the hash of test collateral indice
                    // how many sets of test collateral there are to be tested
                    FileFolderFunctions.ProcessDirectory(path, myDictionary, collateralFile);
                }
                else
                {
                    //MessageBox.Show
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }

                //Copy the test collateral into our working directory
                //Loop through all folders (keys) in the dictionary
                foreach (KeyValuePair<string, List<string>> kvp in myDictionary)
                {
                    string[] folders = kvp.Key.Split('\\');
                    string currentFolder = folders[folders.Count() - 1];
                    string fullImagePath;
                    //List to store image files from the folders of the copied test collateral directory
                    List<string> copiedFilePaths = new List<string>();

                    //Current directory where we are copying test collateral into
                    string currentDirectory = Path.Combine(workingDirectory, currentFolder);

                    //If the currentDirectory path does not exist, create it
                    if (!Directory.Exists(currentDirectory))
                    {
                        Directory.CreateDirectory(currentDirectory);
                    }
                    //Loop through all files (values) associated with the folder
                    foreach (string file in kvp.Value)
                    {
                        //get the image file name from the path
                        string[] fileSplit = file.Split('\\');
                        string imageFile = fileSplit[fileSplit.Count() - 1];

                        //uses the Path.Combine method to safely append the file name to the path
                        //Will overwrite if the file already exists
                        fullImagePath = Path.Combine(currentDirectory, imageFile);
                        File.Copy(file, fullImagePath, true);
                        copiedFilePaths.Add(fullImagePath);
                    }

                    workingCollateral.Add(currentDirectory, copiedFilePaths);
                }

                foreach (KeyValuePair<string, List<string>> kvp in workingCollateral)
                {
                    string[] folders = kvp.Key.Split('\\');
                    string currentFolder = folders[folders.Count() - 1];
                    InputListBox.Items.Add(new ListBoxData() { Value = kvp.Key, Text = currentFolder });
                }
                InputListBox.DisplayMember = "Text";

            }

        }

        private void viewInputFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string value = (InputListBox.SelectedItem as ListBoxData).Value;
                System.Diagnostics.Process.Start("explorer", value);
            }
            catch
            {
                MessageBox.Show("Please select a folder to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }


        private void InputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        
    }
}
