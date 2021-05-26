using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ZEF
{
    public partial class FormMain : Form
    {
        public Process gProcess;
        public List<ProcessModule> gModules;

        public FormMain()
        {
            InitializeComponent();
            gProcess = new Process();
        }

        private enum LogLevel
        {
            None, Info, Warn, Error
        }

        /// <summary>Logs text to a specified TextBox with specified LogLevel.</summary>
        private void Log(string str, TextBox txt, LogLevel level = LogLevel.None)
        {
            txt.AppendText($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}] - " +
                $"{(level == LogLevel.Info ? "Info: " : (level == LogLevel.Warn ? "Warning: " : (level == LogLevel.Error ? "Error: " : "")))}{str}\r\n");
        }
    }
}
