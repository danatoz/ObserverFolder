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
            tbTerminal.Text = Terminal;
            WatcherAcync();
        }

        private void Watcher()
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

            watcher.Filter = "";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

        }

        async void WatcherAcync()
        {
            await Task.Run(() => Watcher());
        }

        private void DisplayMessage(string message)
        {
            Terminal = message;
        }
    }
}
