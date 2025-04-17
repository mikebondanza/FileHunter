using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using System.Threading;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace FileHunter
{

    public partial class MainFrm : Telerik.WinControls.UI.RadForm
    {
        public static string ImgSrcVal = string.Empty;
        public static string ImgDstVal = string.Empty;
        public static string ImgFileVal = string.Empty;
        public static string frmTheme = "Windows11Dark";
        StringBuilder sb = new StringBuilder();
        public static string UserName = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        public static string[] imagesOnly = new string[] { ".jpg", ".jpeg", ".png", ".tif", ".tiff" };
        public static string usrDownloadsKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
        public static string usrDownloadsNode = "{374DE290-123F-4565-9164-39C4925E467B}";

        public MainFrm()
        {
            InitializeComponent();
        }

        // Root Path to search for files in
        private void radButton2_Click(object sender, EventArgs e)
        {
            radOpenFolderDialog1.OpenFolderDialogForm.ThemeName = frmTheme;
            radOpenFolderDialog1.InitialDirectory = DownloadFolder();
            radOpenFolderDialog1.ShowDialog();
            lblImgSrc.Text = radOpenFolderDialog1.FileName;
        }

        // Destination to copy files to
        private void radButton3_Click(object sender, EventArgs e)
        {
            radOpenFolderDialog2.OpenFolderDialogForm.ThemeName = frmTheme;
            radOpenFolderDialog2.InitialDirectory = DownloadFolder();
            radOpenFolderDialog2.ShowDialog();
            lblImgDest.Text = radOpenFolderDialog2.FileName;
        }

        // Text document of files to search for.
        // One file name or partial file name per line
        // Individual lines can be treated as rename items with the following syntax [filename]:[newname]
        private void radButton4_Click(object sender, EventArgs e)
        {
            radOpenFileDialog1.OpenFileDialogForm.ThemeName = frmTheme;
            radOpenFileDialog1.Filter = "Text Documents | *.txt;";
            radOpenFileDialog1.InitialDirectory = DownloadFolder();
            DialogResult dr = radOpenFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                lblImgFile.Text = radOpenFileDialog1.OpenFileDialogForm.FileName;
            }
                
        }

        /// <summary>
        /// main button to execute the search for files.
        /// </summary>
        private async void radButton1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblProcessing.Text = "Hunting for file: ";

            if (lblImgSrc.Text != String.Empty && lblImgDest.Text != String.Empty && lblImgFile.Text != String.Empty)
            {
                ImgSrcVal = lblImgSrc.Text;
                ImgDstVal = lblImgDest.Text;
                ImgFileVal = lblImgFile.Text;

                using (StreamReader readtext = new StreamReader(ImgFileVal))
                {

                    // This is necessary because a VPC can contain a partial name of another VPC of greater length
                    // This can cause collisions and errors in renaming
                    // The solution is to sort descending based on the string length, processing the longer ones first.
                    var file = readtext.ReadToEnd();
                    var lines = file.Split(new char[] { '\n' });

                    List<string> DataText = new List<string>();

                    foreach(string ln in lines)
                    {
                        DataText.Add(ln);
                    }

                    DataText.Sort((x, y) => x.Length.CompareTo(y.Length));
                    DataText.Reverse();


                    var count = DataText.Count();

                    lblProcessing.Visible = true;
                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = count;

                    // Hunt!
                    foreach (string name in DataText)
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            // The hunt begins...
                            // if the name, or line item contains a colon, it is regarded as a file that needs to be renamed and copied
                            // otherwise, just copy the file as-is to the destination
                            // run the process task in a new thread to keep the UI responsive.
                            if(name.Contains(":"))
                            {
                                lblProcessing.Text = "Hunting/Renaming File: " + name;
                                await Task.Run(() => HuntRenameFile(name, ImgSrcVal, ImgDstVal));
                            }
                            else
                            {
                                lblProcessing.Text = "Hunting For File: " + name;
                                await Task.Run(() => HuntForFile(name, ImgSrcVal, ImgDstVal));
                            }

                            // update the label and progress bar so the user doesn't wonder if it's working
                            lblProcessing.Refresh();
                            progressBar1.Increment(1);
                        }
                    }

                    // Process is completed!!!
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        RadMessageBox.Show("Done!", "Hunt Completed", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    }

                    // Write to log and clear stringbuilder
                    // Open the log file to the user to see results.
                    WriteLog(sb.ToString());
                    sb.Clear();
                
                }            
            }
            else
            {
                RadMessageBox.Show("Missing Input Data!", "OOPS!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        /// <summary>
        /// Process the file search and copy images as-is to the destination location
        /// Saves the end user a lot of time from having to go through directories to locate files.
        /// </summary>
        /// <param name="srchFile"></param>
        /// <param name="dirSrc"></param>
        /// <param name="dirDest"></param>
        private void HuntForFile(string srchFile, string dirSrc, string dirDest)
        {
            string partialName = srchFile.Replace("\r", "").Trim();
            DirectoryInfo srchDir = new DirectoryInfo(dirSrc);

            FileInfo[] filesInDir = { };

            // Get Image file types only!
            if (radImages.IsChecked) {

                filesInDir = HuntOnlyImages(partialName).ToArray();

            }  else // Get all file types
            {
                filesInDir = HuntAllFiles(partialName).ToArray();
            }

            if (filesInDir.Length == 0) // if file not found, log it
            {
                sb.AppendLine(partialName);
            }
            else
            {
                foreach (FileInfo foundFile in filesInDir) // if file(s) found, hunt 'em down & copy 'em!
                {
                    string fullName = foundFile.FullName;
                    File.Copy(foundFile.FullName, dirDest + "/" + foundFile.Name, true);
                }
            }
        }

        /// <summary>
        /// Process the file search, but also rename files in the process.
        /// This saves the user an extra step of having to rename files after copying them.
        /// </summary>
        /// <param name="srchFile"></param>
        /// <param name="dirSrc"></param>
        /// <param name="dirDest"></param>
        private void HuntRenameFile(string srchFile, string dirSrc, string dirDest)
        {
            string line = srchFile.Replace("\r", "").Trim();
            string partialName = line.Split(':')[0];
            string rename = line.Split(':')[1];

            DirectoryInfo srchDir = new DirectoryInfo(dirSrc);

            FileInfo[] filesInDir = { };

            // Get Image file types only!
            if (radImages.IsChecked)
            {

                filesInDir = HuntOnlyImages(partialName).ToArray();

            }
            else // Get all file types
            {
                filesInDir = HuntAllFiles(partialName).ToArray();
            }

            if (filesInDir.Length == 0) // if file not found, log it
            {
                sb.AppendLine(partialName);
            }
            else
            {
                foreach (FileInfo foundFile in filesInDir) // if file(s) found, hunt 'em down, rename & copy 'em!
                {
                    string fullName = foundFile.FullName;
                    File.Copy(foundFile.FullName, dirDest + "/" + rename + foundFile.Extension, true);
                }
            }

        }

        /// <summary>
        /// Searches for all file types in the selected folder and all subfolders.
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        private List<FileInfo> HuntAllFiles(string partialName)
        {
            IEnumerable<string> srchImgFiles = Directory.EnumerateFiles(ImgSrcVal, "*" + partialName + "*", SearchOption.AllDirectories);

            List<FileInfo> files = new List<FileInfo>();

            foreach (string f in srchImgFiles)
            {
                files.Add(new FileInfo(f));
            }

            return files;

        }

        /// <summary>
        /// Only search directories for image files only in the selected folder and all subfolders, file types defined in the static string "imagesOnly"
        /// </summary>
        /// <param name="partialName"></param>
        /// <returns></returns>
        private List<FileInfo> HuntOnlyImages(string partialName)
        {

            IEnumerable<string> srchImgFiles = Directory.EnumerateFiles(ImgSrcVal, "*" + partialName + "*", SearchOption.AllDirectories)
            .Where(file => imagesOnly.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))).ToArray();

            List<FileInfo> files = new List<FileInfo>();

            foreach (string f in srchImgFiles)
            {
                files.Add(new FileInfo(f));
            }

            return files;
        }

        /// <summary>
        /// Write the log file and display it to the end user - requires the final stringbuilder string, even if empty.
        /// </summary>
        /// <param name="sb"></param>
        private void WriteLog(string sb)
        {
            string logfile = ImgDstVal + "\\" + "HuntLog.txt";

            // Log the "not founds" and open the log file.  If all found, notify as well.
            FileInfo log = new FileInfo(logfile);
            using (FileStream fs = new FileStream(logfile, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string missingCount = Regex.Matches(sb.ToString(), Environment.NewLine).Count.ToString();

                    if (sb.Length == 0)
                    {
                        sw.WriteLine("************ FILE HUNT RESULTS: ALL FILES FOUND! :) ************");

                    }
                    else
                    {
                        sw.WriteLine("************ FILE HUNT RESULTS: " + missingCount + " FILES NOT FOUND :( ************");

                    }
                    sw.WriteLine("************ (" + UserName + ") :: " + DateTime.Now.ToString() + "  ************");
                    sw.WriteLine(sb.ToString());
                }
            }

            Process proc = new Process();
            proc.StartInfo.FileName = "Notepad.exe";
            proc.StartInfo.Arguments = logfile;
            proc.Start();

        }

        // returns the users local downloads folder path from the registry.
        string DownloadFolder()
        {
            return Registry.GetValue(usrDownloadsKey, usrDownloadsNode, String.Empty).ToString();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName(frmTheme);
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rmnuAbout_Click(object sender, EventArgs e)
        {
            Form abt = new fhAbout();
            abt.ShowDialog();
        }

        private void radImages_ScreenTipNeeded(object sender, ScreenTipNeededEventArgs e)
        {
            string imgs = string.Empty;
            foreach(string i in imagesOnly)
            {
                imgs += i.Trim() + " ";
            }

            var screenTip = new RadOffice2007ScreenTipElement();
            screenTip.EnableCustomSize = true;
            screenTip.AutoSize = false;
            screenTip.Size = new System.Drawing.Size(180, 60);
            screenTip.MainTextLabel.TextWrap = true;
            screenTip.CaptionLabel.Text = "Image File Types:";
            screenTip.MainTextLabel.Text = imgs;
            radImages.ButtonElement.ScreenTip = screenTip;

        }

    }
}
