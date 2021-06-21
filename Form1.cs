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
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItemOnClick;
            exitToolStripMenuItem.Click += ExitToolStripMenuItemOnClick;
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
                var watcher = new FileSystemWatcher(ChooseFolder);
                Observer observ = new Observer();
                observ.Notify += DisplayMessage;
                watcher.NotifyFilter = NotifyFilters.Attributes
                                       | NotifyFilters.CreationTime
                                       | NotifyFilters.DirectoryName
                                       | NotifyFilters.FileName
                                       | NotifyFilters.LastAccess
                                       | NotifyFilters.LastWrite
                                       | NotifyFilters.Security
                                       | NotifyFilters.Size;

                watcher.Changed += observ.Onchanged;
                watcher.Created += observ.OnCreated;
                watcher.Deleted += observ.OnDeleted;
                watcher.Renamed += observ.OnRenamed;
                watcher.Error += observ.OnError;

                watcher.Filter = Filter;
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


        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ChooseFolder = fbd.SelectedPath;
                lblLinkPath.Text = ChooseFolder;

            }
        }
    }
}
