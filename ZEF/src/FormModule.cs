using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEF
{
    public partial class FormMain
    {
        private void btn_ShowModules_Click(object sender, EventArgs e)
        {
            if(!Proc.IsValidProcess(gProcess))
            {
                Log("Couldn't find the process to find modules. Make sure to choose a process first.", txt_Console, LogLevel.Error);
                return;
            }

            gModules = Proc.GetModules(gProcess);
            if(gModules == null)
            {
                Log($"Couldn't get modules for {gProcess.ProcessName}. Make sure to choose a process first.", txt_Console, LogLevel.Error);
            }
            else
            {
                Log($"Modules for {gProcess.ProcessName} ({gProcess.Id}):", txt_Console);
                foreach(ProcessModule x in gModules)
                {
                    txt_Console.AppendText($"{x.BaseAddress.ToString("X")} - {x.ModuleName}\r\n");
                }
            }
        }

        private void btn_GetModule_Click(object sender, EventArgs e)
        {
            if(!Proc.IsValidProcess(gProcess))
            {
                Log("Couldn't find the process to find modules. Make sure to choose a process first.", txt_Console, LogLevel.Error);
                return;
            }

            gModules = Proc.GetModules(gProcess);
            if(gModules == null)
            {
                Log($"Couldn't get modules for {gProcess.ProcessName}. Make sure to choose a process first.", txt_Console, LogLevel.Error);
            }
            else
            {
                foreach(ProcessModule x in gModules)
                {
                    if(x.ModuleName == txt_ModuleName.Text)
                    {
                        Log($"Found module \"{x.ModuleName}\" at 0x{x.BaseAddress.ToString("X")}.", txt_Console, LogLevel.Info);
                        return;
                    }
                }
            }
        }
    }
}
