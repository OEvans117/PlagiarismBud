using Newtonsoft.Json;
using PlagiarismBud.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagiarismBud
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<PFile> PFile;
        private List<PFiles> PFiles;
        private int CurrentPage;
        private string SelectedPath;

        private void ProcessFiles(bool ThroughFolder)
        {
            PFile = new List<PFile>(); PFiles = new List<PFiles>();
            CurrentPage = 0; string[] FilesToProcess = { }; lvFiles.Objects = null; 
            btnPrevious.Text = "[Page 0] Previous"; btnNext.Text = "[Page 0] Next";

            if (ThroughFolder)
            {
                FolderBrowserDialog BrowserDialog = new FolderBrowserDialog();
                BrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                BrowserDialog.ShowDialog();

                if (BrowserDialog.SelectedPath == Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) { return; }
                SelectedPath = BrowserDialog.SelectedPath;
                FilesToProcess = Directory.GetFiles(SelectedPath);
            }
            else
            {
                OpenFileDialog opd = new OpenFileDialog();
                opd.Multiselect = true;
                opd.Filter = "Text files|*.txt";
                opd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opd.ShowDialog();

                SelectedPath = Path.GetDirectoryName(opd.FileNames[0]);
                FilesToProcess = opd.FileNames;
            }

            // Gather each file in directory, and add it to list.
            // Do this in parallel to make it faster.
            Parallel.ForEach(FilesToProcess, pfile =>
            {
                // Gather file data.
                FileInfo fi = new FileInfo(pfile);
                string name = fi.Name;
                string location = pfile;
                DateTime created = fi.CreationTime;
                DateTime lastmodified = fi.LastWriteTime;

                // Create file object.
                PFile p = new PFile(name, location, created, lastmodified);
                if (!PFile.Contains(p)) { PFile.Add(p); }
            });

            // Loop through each PFile, check if any other PFile has the same created/modified params.
            foreach (PFile p in PFile.ToList())
            {
                PFiles plagiarisedFiles = new PFiles();

                foreach (PFile p2 in PFile.ToList())
                {
                    if (p.FileCreated.Equals(p2.FileCreated) && !p.Equals(p2) || p.FileModified.Equals(p2.FileModified) && !p.Equals(p2))
                    {
                        // Check if it already contains plagiarised file. If not, add it.
                        if (!plagiarisedFiles.PlagiarisedFiles.Contains(p)) { plagiarisedFiles.AddFile(p); }
                        if (!plagiarisedFiles.PlagiarisedFiles.Contains(p2)) { plagiarisedFiles.AddFile(p2); PFile.Remove(p2); }
                    }
                }

                // Check that the plagiarisedfiles list doesn't already contain current object.
                if (plagiarisedFiles.PlagiarisedFiles.Count > 0)
                {
                    if (!PFiles.Any(t => t.PlagiarisedFiles[0].FileModified == plagiarisedFiles.PlagiarisedFiles[0].FileModified))
                    {
                        if (plagiarisedFiles.PlagiarisedFiles.Count > 0 && !PFiles.Contains(plagiarisedFiles)) { PFiles.Add(plagiarisedFiles); }
                    }
                }
            }

            if (PFiles.Count == 0) { return; }
            btnNext.Visible = true; btnPrevious.Visible = true; lvFiles.ContextMenuStrip = cmsFileSettings;

            foreach (PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                lvFiles.AddObject(p);
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            ProcessFiles(true);
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            ProcessFiles(false);
        }

        private void btnImportPCheck_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Text files|*.txt";
            opd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opd.ShowDialog();

            PFile = new List<PFile>(); PFiles = new List<PFiles>();
            CurrentPage = 0; lvFiles.Objects = null; 
            SelectedPath = Directory.GetParent(opd.FileName).FullName;
            btnPrevious.Text = "[Page 0] Previous"; btnNext.Text = "[Page 0] Next";

            foreach(string PFilesS in File.ReadAllLines(opd.FileName))
            {
                PFiles.Add(JsonConvert.DeserializeObject<PFiles>(PFilesS));
            }

            foreach (PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                lvFiles.AddObject(p);
            }

            btnNext.Visible = true; btnPrevious.Visible = true; lvFiles.ContextMenuStrip = cmsFileSettings;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage == PFiles.Count - 1) { return; }

            CurrentPage += 1; lvFiles.Objects = null;
            btnNext.Text = "[Page " + CurrentPage.ToString() + "] Next";
            btnPrevious.Text = "[Page " + CurrentPage.ToString() + "] Previous";

            foreach (PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                lvFiles.AddObject(p);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 0) { return; }

            CurrentPage -= 1; lvFiles.Objects = null;
            btnPrevious.Text = "[Page " + CurrentPage.ToString() + "] Previous";
            btnNext.Text = "[Page " + CurrentPage.ToString() + "] Previous";

            foreach (PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                lvFiles.AddObject(p);
            }
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                Process.Start(p.FileLocation);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PFile p in lvFiles.SelectedObjects)
            {
                Process.Start(p.FileLocation);
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            Process.Start(Path.GetDirectoryName(PFiles[CurrentPage].PlagiarisedFiles[0].FileLocation));
        }

        private void WriteDebug(string Text, bool AllPages)
        {
            string currentTime = ("[" + DateTime.Now.ToString("h:mm:ss") + "] ").Replace(":", "-");
            string filename = string.Empty;

            if (AllPages){filename = SelectedPath + "//Extracted//ExtractedAll " + currentTime + ".txt";}
            else{filename = SelectedPath + "//Extracted//ExtractedCurrent " + currentTime + ".txt";}

            Directory.CreateDirectory(SelectedPath + "//Extracted");
            File.WriteAllText(filename, Text);
            Process.Start(filename);
        }

        private void allPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AllObjectsSerialized = string.Empty;

            foreach(PFiles pf in PFiles)
            {
                string SerializedObj = JsonConvert.SerializeObject(pf);
                AllObjectsSerialized += SerializedObj + "\r\n";
            }

            WriteDebug(AllObjectsSerialized, true);
        }

        private void selectedEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AllObjectsSerialized = string.Empty;
            if (lvFiles.SelectedObjects.Count == 0) { return; }

            foreach (PFile p in lvFiles.SelectedObjects)
            {
                string SerializedObj = JsonConvert.SerializeObject(p);
                AllObjectsSerialized += SerializedObj + "\r\n";
            }

            WriteDebug(AllObjectsSerialized, false);
        }

        private void allEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AllObjectsSerialized = string.Empty;

            foreach (PFile p in PFiles[CurrentPage].PlagiarisedFiles)
            {
                string SerializedObj = JsonConvert.SerializeObject(p);
                AllObjectsSerialized += SerializedObj + "\r\n";
            }

            WriteDebug(AllObjectsSerialized, false);
        }
    }
}
