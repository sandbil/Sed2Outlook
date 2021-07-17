﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Sed2Outlook.CsHTTPServer
{
    public static class Paths
    {
        private static readonly string ExecutablePath = Application.StartupPath;

        private static readonly string AppDataPath = Path.Combine(ExecutablePath, "Data");

        private static readonly string TempPath = Path.Combine(ExecutablePath, "temp");

        private static readonly string RecoveryPath = Path.Combine(AppDataPath, "recovery");

        private static readonly string ComponentsPath = Path.Combine(AppDataPath, "components");

        public static string AppData => EnsureFolderExists(AppDataPath);

        public static string Executable => EnsureFolderExists(ExecutablePath);

        public static string Temp => EnsureFolderExists(TempPath);

        public static string Recovery => EnsureFolderExists(RecoveryPath);

        public static string Components => EnsureFolderExists(ComponentsPath);

        /// <summary>
        /// Safely deletes the Sed2Outlook temp folder. If other NAPS2 or NAPS2.Console processes are running, the folder will be left alone.
        /// </summary>
        public static void ClearTemp()
        {
            try
            {
                if (!Directory.Exists(TempPath)) return;

                var otherNaps2Processes = Process.GetProcesses().Where(x =>
                    x.ProcessName.IndexOf("Sed2Outlook", StringComparison.OrdinalIgnoreCase) >= 0 &&
                    x.Id != Process.GetCurrentProcess().Id);
                if (!otherNaps2Processes.Any())
                {
                    Directory.Delete(TempPath, true);
                }
            }
            catch (Exception e)
            {
               // Log.ErrorException("Error clearing temp files", e);
            }
        }

        private static string EnsureFolderExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return folderPath;
        }
    }
}
