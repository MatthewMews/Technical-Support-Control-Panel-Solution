using System;
using IWshRuntimeLibrary;
using System.IO;
using System.Windows.Forms;

namespace OfficeApps
{
    class OfficeAppShortcuts
    {
        private static string officePathOne = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Microsoft Office\root\Office16\";
        private static string officePathTwo = @"C:\Program Files\Microsoft Office\Office16\";
        private static string officePathThree = @"C:\Program Files\Microsoft Office 16\ClientX64\Root\Office16\";
        private static string officePathFour = @"C:\Program Files\Microsoft Office\root\Office16\";

        public static bool emptyFolder = false;

        public static void GetShortcuts()
        {
            bool gotFiles = OfficeCheck();

            if (!gotFiles)
            {
                MessageBox.Show("Error attempting to add shortcut files to the desktop.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Office shortcuts have now been added to the desktop.", "Technical Supoort Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // check that ther office folders exist
        public static bool OfficeCheck()
        {
            // Program data path
            if(Directory.Exists(officePathOne))
            {
                bool officePathOneExists = OfficeCheckOne();

                if(officePathOneExists == true && emptyFolder == true)
                {
                    ;
                    emptyFolder = false;
                }
                else
                {
                    return officePathOneExists;
                }
            }

             //Click-To-Run
            if (Directory.Exists(officePathTwo))
            {
                bool officePathTwoExists = OfficeCheckTwo();

                if (officePathTwoExists == true && emptyFolder == true)
                {
                    ;
                    emptyFolder = false;
                }
                else
                {
                    return officePathTwoExists;
                }
            }
            // Office 2016
            if (Directory.Exists(officePathThree))
            {
                bool officePathThreeExists = OfficePathThree();

                if (officePathThreeExists == true && emptyFolder == true)
                {
                    ;
                    emptyFolder = false;
                }
                else
                {
                    return officePathThreeExists;
                }
            }

            //Root Directory
            if (Directory.Exists(officePathFour))
            {
                bool officePathFourExists = OfficePathFour();

                if (officePathFourExists == true && emptyFolder == true)
                {
                    ;
                    emptyFolder = false;
                }
                else
                {
                    return officePathFourExists;
                }
            }

            return false;
        }

        // Find the exe files and copy them to the desktop.
        public static bool OfficeCheckOne()
        {
            string outlookPath = officePathOne + "OUTLOOK.exe";
            string oneNotePath = officePathOne + "ONENOTE.exe";
            string powerPointPath = officePathOne + "POWERPNT.exe";
            string excelPath = officePathOne + "EXCEL.exe";
            string wordPath = officePathOne + "WINWORD.exe";

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();

            //Outlook
            if (System.IO.File.Exists(outlookPath))
            {
                string outlookAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Outlook 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(outlookAddress);
                shortcut.Description = "Manage your email, schedules, contacts, and to-dos.";
                shortcut.TargetPath = outlookPath;
                shortcut.Save();
            }
            // OneNote
            if (System.IO.File.Exists(oneNotePath))
            {
                string oneNoteAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\OneNote 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(oneNoteAddress);
                shortcut.Description = "Take notes and have them when you need them.";
                shortcut.TargetPath = oneNotePath;
                shortcut.Save();
            }
            // PowerPoint
            if (System.IO.File.Exists(powerPointPath))
            {
                string powerPointAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\PowerPoint 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(powerPointAddress);
                shortcut.Description = "Design and deliver beautiful presentations with ease and confidence.";
                shortcut.TargetPath = powerPointPath;
                shortcut.Save();
            }
            // Excel
            if (System.IO.File.Exists(excelPath))
            {
                string excelPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Excel 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(excelPathAddress);
                shortcut.Description = "Easily discover, visualize, and share insights from your data.";
                shortcut.TargetPath = excelPath;
                shortcut.Save();
            }
            // Word
            if (System.IO.File.Exists(wordPath))
            {
                string wordPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Word 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(wordPathAddress);
                shortcut.Description = "Create beautiful documents, easily work with others, and enjoy the read.";
                shortcut.TargetPath = wordPath;
                shortcut.Save();
            }

            // if the folder exists, but the files aren't there, call the next method.
            if ((!System.IO.File.Exists(outlookPath)) || !System.IO.File.Exists(oneNotePath) || !System.IO.File.Exists(powerPointPath) || !System.IO.File.Exists(excelPath) || !System.IO.File.Exists(wordPath))
            {
                emptyFolder = true;
            }
            return true;
        }

        public static bool OfficeCheckTwo()
        {
            string outlookPath = officePathTwo + "OUTLOOK.exe";
            string oneNotePath = officePathTwo + "ONENOTE.exe";
            string powerPointPath = officePathTwo + "POWERPNT.exe";
            string excelPath = officePathTwo + "EXCEL.exe";
            string wordPath = officePathTwo + "WINWORD.exe";

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();

            //Outlook
            if (System.IO.File.Exists(outlookPath))
            {
                string outlookAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Outlook 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(outlookAddress);
                shortcut.Description = "Manage your email, schedules, contacts, and to-dos.";
                shortcut.TargetPath = outlookPath;
                shortcut.Save();
            }
            // One Note
            if (System.IO.File.Exists(oneNotePath))
            {
                string oneNoteAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\OneNote 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(oneNoteAddress);
                shortcut.Description = "Take notes and have them when you need them.";
                shortcut.TargetPath = oneNotePath;
                shortcut.Save();
            }
            // PowerPoint
            if(System.IO.File.Exists(powerPointPath))
            {
                string powerPointAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\PowerPoint 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(powerPointAddress);
                shortcut.Description = "Design and deliver beautiful presentations with ease and confidence.";
                shortcut.TargetPath = powerPointPath;
                shortcut.Save();
            }
            // Excel
            if (System.IO.File.Exists(excelPath))
            {
                string excelPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Excel 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(excelPathAddress);
                shortcut.Description = "Easily discover, visualize, and share insights from your data.";
                shortcut.TargetPath = excelPath;
                shortcut.Save();
            }
            // Word
            if (System.IO.File.Exists(wordPath))
            {
                string wordPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Word 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(wordPathAddress);
                shortcut.Description = "Create beautiful documents, easily work with others, and enjoy the read.";
                shortcut.TargetPath = wordPath;
                shortcut.Save();
            }

            // if the folder exists, but the files aren't there, call the next method.
            if ((!System.IO.File.Exists(outlookPath)) || !System.IO.File.Exists(oneNotePath) || !System.IO.File.Exists(powerPointPath) || !System.IO.File.Exists(excelPath) || !System.IO.File.Exists(wordPath))
            {
                emptyFolder = true;
            }

            return true;
        }

        public static bool OfficePathThree()
        {
            string outlookPath = officePathThree + "OUTLOOK.exe";
            string oneNotePath = officePathThree + "ONENOTE.exe";
            string powerPointPath = officePathThree + "POWERPNT.exe";
            string excelPath = officePathThree + "EXCEL.exe";
            string wordPath = officePathThree + "WINWORD.exe";

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();

            // Outlook
            if (System.IO.File.Exists(outlookPath))
            {
                string outlookAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Outlook 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(outlookAddress);
                shortcut.Description = "Manage your email, schedules, contacts, and to-dos.";
                shortcut.TargetPath = outlookPath;
                shortcut.Save();
            }
            // One Note
            if (System.IO.File.Exists(oneNotePath))
            {
                string oneNoteAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\OneNote 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(oneNoteAddress);
                shortcut.Description = "Take notes and have them when you need them.";
                shortcut.TargetPath = oneNotePath;
                shortcut.Save();
            }
            // PowerPoint
            if (System.IO.File.Exists(powerPointPath))
            {
                string powerPointAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\PowerPoint 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(powerPointAddress);
                shortcut.Description = "Design and deliver beautiful presentations with ease and confidence.";
                shortcut.TargetPath = powerPointPath;
                shortcut.Save();
            }
            // Excel
            if (System.IO.File.Exists(excelPath))
            {
                string excelPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Excel 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(excelPathAddress);
                shortcut.Description = "Easily discover, visualize, and share insights from your data.";
                shortcut.TargetPath = excelPath;
                shortcut.Save();
            }
            // Word
            if (System.IO.File.Exists(wordPath))
            {
                string wordPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Word 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(wordPathAddress);
                shortcut.Description = "Create beautiful documents, easily work with others, and enjoy the read.";
                shortcut.TargetPath = wordPath;
                shortcut.Save();
            }

            // if the folder exists, but the files aren't there, call the next method.
            if ((!System.IO.File.Exists(outlookPath)) || !System.IO.File.Exists(oneNotePath) || !System.IO.File.Exists(powerPointPath) || !System.IO.File.Exists(excelPath) || !System.IO.File.Exists(wordPath))
            {
                emptyFolder = true;
            }

            return true;
        }

        public static bool OfficePathFour()
        {
            string outlookPath = officePathFour + "OUTLOOK.exe";
            string oneNotePath = officePathFour + "ONENOTE.exe";
            string powerPointPath = officePathFour + "POWERPNT.exe";
            string excelPath = officePathFour + "EXCEL.exe";
            string wordPath = officePathFour + "WINWORD.exe";

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();

            // Outlook
            if (System.IO.File.Exists(outlookPath))
            {
                string outlookAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Outlook 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(outlookAddress);
                shortcut.Description = "Manage your email, schedules, contacts, and to-dos.";
                shortcut.TargetPath = outlookPath;
                shortcut.Save();
            }
            // One Note
            if (System.IO.File.Exists(oneNotePath))
            {
                string oneNoteAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\OneNote 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(oneNoteAddress);
                shortcut.Description = "Take notes and have them when you need them.";
                shortcut.TargetPath = oneNotePath;
                shortcut.Save();
            }
            // PowerPoint
            if (System.IO.File.Exists(powerPointPath))
            {
                string powerPointAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\PowerPoint 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(powerPointAddress);
                shortcut.Description = "Design and deliver beautiful presentations with ease and confidence.";
                shortcut.TargetPath = powerPointPath;
                shortcut.Save();
            }
            // Excel
            if (System.IO.File.Exists(excelPath))
            {
                string excelPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Excel 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(excelPathAddress);
                shortcut.Description = "Easily discover, visualize, and share insights from your data.";
                shortcut.TargetPath = excelPath;
                shortcut.Save();
            }
            // Word
            if (System.IO.File.Exists(wordPath))
            {
                string wordPathAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Word 2016.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(wordPathAddress);
                shortcut.Description = "Create beautiful documents, easily work with others, and enjoy the read.";
                shortcut.TargetPath = wordPath;
                shortcut.Save();
            }

            // if the folder exists, but the files aren't there, call the next method.
            if ((!System.IO.File.Exists(outlookPath)) || !System.IO.File.Exists(oneNotePath) || !System.IO.File.Exists(powerPointPath) || !System.IO.File.Exists(excelPath) || !System.IO.File.Exists(wordPath))
            {
                emptyFolder = true;
            }
            return true;
        } 

        public static bool CheckOutlookExists()
        {
            string outlookPathOne = officePathOne + "OUTLOOK.exe";
            string outlookPathTwo = officePathTwo + "OUTLOOK.exe";
            string outlookPathThree = officePathThree + "OUTLOOK.exe";
            string outlookPathFour = officePathFour + "OUTLOOK.exe";

            if (System.IO.File.Exists(outlookPathOne))
            {
                return true;
            } else if (System.IO.File.Exists(outlookPathTwo))
            {
                return true;
            } else if (System.IO.File.Exists(outlookPathThree))
            {
                return true;
            } else if (System.IO.File.Exists(outlookPathFour))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
