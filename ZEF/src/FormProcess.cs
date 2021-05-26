using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZEF
{
    public partial class FormMain
    {
        // Get Process Button Clicked:
        private void btn_GetProcess_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_ProcID.Text))
            {
                int procID = -1;
                if(Int32.TryParse(txt_ProcID.Text, out procID))
                {
                    try
                    {
                        gProcess = Process.GetProcessById(procID);
                    }
                    catch
                    {
                        Log("Couldn't find process with given ID.", txt_Console, LogLevel.Error);
                        procID = -1;
                    }
                }
                else
                {
                    Log("Invalid Process ID.", txt_Console, LogLevel.Error);
                }

                if(procID > -1)
                {
                    Log($"Successfully found process by it's ID: \"{gProcess.ProcessName}\" ({gProcess.Id})", txt_Console, LogLevel.Info);
                    txt_ProcName.Text = gProcess.ProcessName;
                    return;
                }
            }

            if(!String.IsNullOrEmpty(txt_ProcName.Text))
            {
                Process[] procList = Process.GetProcessesByName(txt_ProcName.Text);

                if(procList.Length == 0)
                {
                    Log($"Process \"{txt_ProcName.Text}\" not found.", txt_Console, LogLevel.Error);
                    return;
                }

                if(procList.Length > 1)
                {
                    Log($"Multiple process with the name \"{txt_ProcName.Text}\" found. Please choose process by it's ID:", txt_Console, LogLevel.Warn);
                    foreach(Process x in procList)
                    {
                        txt_Console.AppendText($"{x.ProcessName} : {x.Id.ToString()}\r\n");
                    }
                    return;
                }

                gProcess = procList[0];
                Log($"Successfully found process by it's name: \"{gProcess.ProcessName}\" ({gProcess.Id})", txt_Console, LogLevel.Info);
                txt_ProcID.Text = gProcess.Id.ToString();
                this.Text = $"ZEF - {gProcess.ProcessName} ({gProcess.Id})";
                return;
            }
            else
            {
                Log("A process is needed first. Find it by name or ID.", txt_Console, LogLevel.Warn);
            }
        }

        // Enter pressed:
        private void btn_GetProcess_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_GetProcess_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
        // Enter pressed - Prevent bell sound:
        private void btn_GetProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btn_ProcessInfo_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
