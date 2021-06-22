using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Diagnostics;
using System.Media;

namespace Observer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string Terminal { get; set; }
        public string ChooseFolder { get; set; }
        public string Filter { get; set; }
        public Form()
        {
            InitializeComponent();
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            Filter = tbFilter.Text;
            
        }

        private void ExitToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            MessageBox.Show("About");
        }

        private void Watcher()
        {
            try
            {
                var watcher = new FileSystemWatcher(ChooseFolder,Filter);
                Observer observ = new Observer();
                observ.Notify += DisplayMessage;
                //watcher.NotifyFilter = NotifyFilters.Attributes
                //                       | NotifyFilters.CreationTime
                //                       | NotifyFilters.DirectoryName
                //                       | NotifyFilters.FileName
                //                       | NotifyFilters.LastAccess
                //                       | NotifyFilters.LastWrite
                //                       | NotifyFilters.Security
                //                       | NotifyFilters.Size;






                if (cbChanged.Checked == false)
                {
                    watcher.Changed += null;
                    //Beep();
                }
                else
                {
                    watcher.Changed += observ.Onchanged;
                }
                if (cbDeleted.Checked == true)
                    watcher.Deleted += observ.OnDeleted;
                if (cbRenamed.Checked == true)
                    watcher.Renamed += observ.OnRenamed;
                if (cbCreated.Checked == true)
                    watcher.Created += observ.OnCreated;
                if (cbError.Checked == true)
                    watcher.Error += observ.OnError;
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

            }
            catch (Exception e)
            {
                Terminal = e.ToString();
            }

        }

        async void WatcherAcync()
        {
            //await Task.Run(() => Watcher());
        }

        private void DisplayMessage(string message)
        {
            tbTerminal.Text += message + Environment.NewLine;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Watcher();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbTerminal.Clear();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ChooseFolder = fbd.SelectedPath;
                lblLinkPath.Text = ChooseFolder;
            }
        }

        private void lblLinkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", ChooseFolder);
        }

        private void Beep()
        {
            SystemSounds.Beep.Play();
        }
    }
}
