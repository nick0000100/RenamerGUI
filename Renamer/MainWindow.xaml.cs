using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace Renamer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RenameButton_Click(object sender, RoutedEventArgs e)
        {
            String errorMessage;
            if(FolderPath.Text == "" && NameList.Text == "")
            {
                errorMessage = "Enter a list of names and the folder path to continue.";
            }
            else if(FolderPath.Text == "")
            {
                errorMessage = "Enter the folder path to continue.";
            }
            else if(NameList.Text == "")
            {
                errorMessage = "Enter a list of names to continue.";
            }
            else if((!NameOrderButtonYes.IsChecked == false && NameOrderButtonNo.IsChecked == false) || (FileOrderFirst.IsChecked == false && FileOrderLast.IsChecked == false))
            {
                errorMessage = "Make sure the checkboxes are selected.";
            }
            else
            {
                ExecuteRename();
                return;
            }
            MessageBox.Show(errorMessage);
        }

        private void ExecuteRename()
        {
            String folderPath = FolderPath.Text;
            String prefix = PrefixInput.Text;
            String suffix = SuffixInput.Text;

            // Gets list of names from inputted data.
            StringReader Reader = new StringReader(NameList.Text);
            List<String> Names = new List<String>();
            String newName;
            while ((newName = Reader.ReadLine()) != null)
            {
                Names.Add(newName);
            }

            // Switches the order of the names
            if (NameOrderButtonYes.IsChecked == FileOrderFirst.IsChecked)
            {
                Names = Flipper(Names);
            }

            // Gets the directory and files to rename
            DirectoryInfo dir = new DirectoryInfo(@folderPath);

            FileInfo[] Files = dir.GetFiles();
            foreach (FileInfo CurrentFile in Files)
            {
                String FileName = Regex.Replace(Path.GetFileNameWithoutExtension(CurrentFile.FullName), @"[_0-9]+", "");
                String Ex = Path.GetExtension(CurrentFile.FullName);

                foreach (String Name in Names)
                {
                    // Renames the file
                    if (Name.ToLower().StartsWith(FileName.ToLower()))
                    {
                        int Count = 1;
                        String NewFileName;
                        if (prefix != "" && suffix != "")
                        {
                            NewFileName = CurrentFile.FullName.Replace(CurrentFile.Name, $"{prefix} {Name} {suffix}{Ex}");
                        }
                        else if (prefix == "" && suffix != "")
                        {
                            NewFileName = CurrentFile.FullName.Replace(CurrentFile.Name, $"{Name} {suffix}{Ex}");
                        }
                        else if (prefix != "" && suffix == "")
                        {
                            NewFileName = CurrentFile.FullName.Replace(CurrentFile.Name, $"{prefix} {Name}{Ex}");
                        }
                        else
                        {
                            NewFileName = CurrentFile.FullName.Replace(CurrentFile.Name, $"{Name}{Ex}");
                        }

                        // Checks to see if a file with the same name exists.
                        while (File.Exists(NewFileName))
                        {
                            String TempFileName = $"{Name} ({++Count}){Ex}";
                            NewFileName = CurrentFile.FullName.Replace(CurrentFile.Name, TempFileName);
                        }
                        File.Move(CurrentFile.FullName, NewFileName);
                        break;
                    }
                }
            }
        }

        // Switches the format of the names.
        private static List<String> Flipper(List<String> Names)
        {
            List<String> ReversedNames = new List<String>();
            foreach (String Name in Names)
            {
                String NameOne = "";
                String NameTwo = "";
                Boolean Switch = false;
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i].ToString() == ",")
                    {
                        Switch = true;
                        i++;
                    }
                    if (!Switch)
                    {
                        NameOne += Name[i];
                    }
                    else
                    {
                        NameTwo += Name[i];
                    }
                }
                String Reversed = $"{NameTwo}, {NameOne}".Trim();
                ReversedNames.Add(Reversed);
            }
            return ReversedNames;
        }
    }
}
