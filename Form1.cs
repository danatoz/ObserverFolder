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

namespace Observer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string Terminal { get; set; }
        public Form()
        {
            InitializeComponent();
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Watcher()
        {
            try
            {
                var watcher = new FileSystemWatcher(@"C:\Users\Dante\Desktop\ivent");
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

                watcher.Filter = "*.xlsx";
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
            await Task.Run(() => Watcher());
        }

        private void DisplayMessage(string message)
        {
            tbTerminal.Text += message + Environment.NewLine;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            WatcherAcync();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbTerminal.Clear();
        }
    }
}
