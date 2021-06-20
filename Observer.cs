﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observer
    {
        public delegate void ObserverHandler(string message);

        public event ObserverHandler Notify;
        public void Onchanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Notify?.Invoke($"Changed: {e.FullPath}|\n\r");
        }

        public void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}|\n\r";
            Notify?.Invoke(value);
        }
        public void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Notify?.Invoke($"Deleted: {e.FullPath}|\n\r");
        }
        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            Notify?.Invoke($"Renamed:");
            Notify?.Invoke($"   Old: {e.OldFullPath}|\n\r");
            Notify?.Invoke($"   New: {e.FullPath}|\n\r");
        }

        public void OnError(object sender, ErrorEventArgs e) => 
            PrintException(e.GetException());

        private void PrintException(Exception ex)
        {
            if (ex != null)
            {
                Notify?.Invoke($"Message: {ex.Message}|\n\r");
                Notify?.Invoke($"Stacktrace:");
                Notify?.Invoke(ex.StackTrace);

                PrintException(ex.InnerException);
            }
        }
    }
}
